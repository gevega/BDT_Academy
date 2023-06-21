//INICIO PROGRAMA PRINCIPAL
const string TEXTO = "Ingrese un nombre: ";
string nom = "Messi";

ingresar(ref nom, TEXTO);

//FIN PROGRAMA PRINCIPAL

static void ingresar(ref string var, string TEXTO)
{
    Console.Write(TEXTO);
    var = Console.ReadLine()!;
}