Algoritmo parcial_22_05
	Definir d, socio, pos, cant_soc, vContadores Como Entero
	Definir vPlanes, vNombres, plan, estudio Como Caracter
	Definir vTotales, vPorcentajes Como Real
	Dimension vPlanes[6],vTotales[6], vContadores[6], vPorcentajes[6]
	vPlanes[1] <- 'BF'
	vPlanes[2] <- 'BI'
	vPlanes[2] <- 'GF'
	vPlanes[2] <- 'GI'
	vPlanes[2] <- 'PF'
	vPlanes[2] <- 'PI'
	iniciarTotales(vTotales,6)
	iniciarTotales(vContadores,6)
	cant_soc = 0
	Para d<-1 Hasta 31 Hacer
		socio <- ingresarSocio(cant_soc)
		Mientras socio <>-1 Hacer
			pos <- ingresarPlan(vPlanes)
			estudio <- ingresarEstudio(pos, d, vTotales, vContadores, vPorcentajes)
			socio <- ingresarSocio(cant_soc)
		FinMientras
	FinPara
FinAlgoritmo

Funcion iniciarTotales(vec por referencia,tope)
	Definir i Como Entero
	Para i<-1 Hasta tope Hacer
		vec[i] <- 0
	FinPara
FinFuncion

Funcion socio <- ingresarSocio(cant_soc Por Referencia)
	Definir socio Como Entero
	Escribir 'Ingrese el nro. de socio ' Sin Saltar
	Leer socio
	Mientras (socio < 0 o socio > 999999) y socio <> -1 Hacer
		Escribir 'Número inválido, ingresa nuevamente ' Sin Saltar
		Leer socio
	Fin Mientras
	cant_soc = cant_soc + 1
FinFuncion

Funcion pos <- ingresarPlan(planes)
	Definir pos Como Entero
	Definir plan Como Caracter
	Repetir
		Escribir 'Ingrese el código del plan ' Sin Saltar
		Leer plan
		pos <- buscarPlan[plan,planes]
	Hasta Que pos<>-1
FinFuncion

Funcion pos <- buscarPlan(plan, planes)
	definir pos, i como entero
	i <- 1
	Mientras i <= 6 y plan <> planes(i) Hacer
		i <- i + 1
	FinMientras
	Si i < 7 Entonces
		pos <- i
	SiNo
		pos <- -1
	FinSi
FinFuncion

Funcion nro <- Autoriza(plan, estudio, fecha)
	definir nro como real
	nro <- aleatorio(-2,1)
	Si nro > 0 Entonces
		nro <- azar(100000)
	FinSi
FinFuncion

Funcion estudio <- ingresarEstudio(plan, fecha, vTotales Por Referencia, vContadores Por Referencia, vPorcentajes Por Referencia)
	Definir nro Como real
	Definir estudio Como Caracter
	Escribir 'Ingrese estudio a realizar' Sin Saltar
	Leer estudio
	Mientras estudio = '' Hacer
		Escribir 'El estudio no puede estar vacio, ingresa nuevamente'
		leer estudio
	Fin Mientras
	nro <- Autoriza(plan, estudio, fecha)
	Segun nro Hacer
		-2:
			Escribir 'Esa fecha y hora ya está reservada'
		-1:
			Escribir 'El plan no habilita dicho estudio'
		0:
			Escribir 'Se puede realizar el estudio sin copago.'
		De Otro Modo:
			Escribir 'Debe pagar $', nro
			vTotales(plan) = vTotales(plan) + nro
	Fin Segun
	vContadores(plan) = vContadores(plan) + 1
Fin Funcion

Funcion porcentajes()
	
Fin Funcion
