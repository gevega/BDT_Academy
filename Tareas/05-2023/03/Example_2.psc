Algoritmo sin_titulo
	Definir imp, total Como Real
	
	Mientras imp <> -1 Hacer
		Escribir "¿Cuanto quieres aportar? $" Sin Saltar
		Leer imp
		
		Si imp >= 0 Entonces
			total = total + imp
		SiNo
			Escribir "Importe no válido"
		Fin Si
	Fin Mientras
	
	Escribir "Total: ", total
FinAlgoritmo