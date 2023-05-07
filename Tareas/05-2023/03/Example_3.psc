Algoritmo example_3
	Definir imp, total Como Real
	Definir continuar Como Entero
	Continuar = 1
	
	Repetir
		Escribir "¿Cuanto quieres aportar? $" Sin Saltar
		Leer imp
		
		Si imp >= 0 Entonces
			total = total + imp
		SiNo
			Escribir "Importe no válido"
		Fin Si
		
		Si total <> 0 Entonces
			Escribir "¿Continuar? (1- Sí)" Sin Saltar
			Leer continuar
		Fin Si
	Hasta Que continuar <> 1
	
	Escribir "Total: ", total
FinAlgoritmo