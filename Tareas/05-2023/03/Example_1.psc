Algoritmo example_1
	Definir i Como Entero
	Definir imp, total Como Real
	
	Para i = 1 Hasta 31 Con Paso 1 Hacer
		Escribir "¿Cuanto quieres aportar? $" Sin Saltar
		Leer imp
		
		Si imp >= 0 Entonces
			total = total + imp
		SiNo
			Escribir "Importe no válido"
			i = i - 1
		Fin Si
	Fin Para
	
	Escribir "Total: ", total
FinAlgoritmo