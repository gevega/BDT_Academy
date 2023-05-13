Algoritmo example_1
	Definir total, imp Como Real
	Definir i Como Entero
	total = 0
	Para i=1 Hasta 2 Hacer
		ingresar_datos('¿Cuanto quieres aportar? ', total, imp)
	Fin Para
	Escribir "Total: ", total
FinAlgoritmo

Funcion ingresar_datos (text, total Por Referencia, imp Por Referencia)
	Escribir text Sin Saltar
	Leer imp
	validar_importe(total, imp, 0,'Valor inválido, ingresar nuevamente')
Fin Funcion

Funcion validar_importe (total Por Referencia, imp Por Referencia, piso, error)
	Si imp < piso Entonces
		ingresar_datos('¿Cuanto quieres aportar? ', total, imp)
	SiNo
		total = total + imp
	FinSi
Fin Funcion