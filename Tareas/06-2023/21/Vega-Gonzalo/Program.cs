//INICIO PROGRAMA PRINCIPAL
string[] nom = new string[3] { "River Plate", "San Lorenzo", "Racing Club" };
string[] code = new string[3] { "RIV", "SLO", "RAC" };
string[,] jug = new string[3, 3] { { "RIV001", "RIV002", "RIV003" }, { "SLO001", "SLO002", "SLO003" }, { "RAC001", "RAC002", "RAC003" } };
string jug_s = "";

for (int i = 0; i < 3; i++)
{
    mostrar(nom, code, i);
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"\n|   FECHA {j}   |");

        ingresar(ref jug_s, jug, i);
        while (jug_s.ToUpper() != "FIN")
        {
            ingAmon();
            ingresar(ref jug_s, jug, i);
        }
    }
}
//FIN PROGRAMA PRINCIPAL

static void mostrar(string[] nom, string[] code, int i)
{
    Console.WriteLine($"Código: {code[i]}    |   {nom[i]}");
}

static void ingresar(ref string var, string[,] jug, int i)
{
    Console.Write("Ingrese jugador amonestado: ");
    var = Console.ReadLine()!;
    validar(var, jug, i);
}

static void validar(string var, string[,] jug, int i)
{
    string[] c_jug = new string[3];
    for (int j = 0; j < 3; j++)
    {
        c_jug[j] = jug[i,j];
    }
    while(Array.IndexOf(c_jug, var) == -1 && var.ToUpper() != "FIN")
    {
        Console.WriteLine("Código inválido o vacío, ingresa nuevamente");
        ingresar(ref var, jug, i);
    }
}

static void ingAmon()
{
    
}
