Algoritmo example_1
	Definir total Como Real
	Definir i Como Entero
	total = 0
	Para i=1 Hasta 2 Hacer
		ingresar_datos('¿Cuanto quieres aportar? ', total)
	Fin Para
	Escribir "Total: ", total
FinAlgoritmo

Funcion ingresar_datos (text, total Por Referencia)
	Definir imp como Real
	Escribir text Sin Saltar
	Leer imp
	validar_importe(total, imp, 0,'Valor inválido, ingresar nuevamente')
	total = total + imp
Fin Funcion

Funcion validar_importe (total Por Referencia, imp, piso, error)
	Mientras imp < piso Hacer
		Escribir error
		Escribir "Imp: ", imp
		Escribir "Total: ", total
		ingresar_datos('¿Cuanto quieres aportar? ', total)
	Fin Mientras
Fin Funcion