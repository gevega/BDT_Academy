//INICIO PROGRAMA PRINCIPAL
string[] nom = new string[3] { "River Plate", "San Lorenzo", "Racing Club" };
string[] code = new string[3] { "RIV", "SLO", "RAC" };
string[,] jug = new string[3, 3] { { "RIV001", "RIV002", "RIV003" }, { "SLO001", "SLO002", "SLO003" }, { "RAC001", "RAC002", "RAC003" } };
string jug_s = "";

for (int i = 0; i < 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        mostrar(nom, code, i);
        Console.WriteLine($"\n|   FECHA {j}   |");

        ingresar(ref jug_s, jug, i);
        while (jug_s.ToUpper() != "FIN")
        {
            ingAmon();
            ingresar(ref jug_s, jug, i);
        }
        Console.Clear();
    }
}
//FIN PROGRAMA PRINCIPAL

static void mostrar(string[] nom, string[] code, int i)
{
    Console.WriteLine($"\nCódigo: {code[i]}    |   {nom[i]}");
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
    int ama = 0, roja = 0;
    Console.Write("Ingrese cantidad de amarillas: ");
    ama = Convert.ToInt16(Console.ReadLine()!);
    validarTarj(ref ama, 0, 2);
    if(ama < 2)
    {
        Console.Write("Ingrese 1 si fue expulsado: ");
        roja = Convert.ToInt16(Console.ReadLine()!);
        validarTarj(ref roja, 0, 1);
    }
    else
    {
        Console.WriteLine("¡Fue expulsado!");
    }
}

static void validarTarj(ref int ama, int piso, int tope){
    while(ama < piso || ama > tope)
    {
        Console.Write("Cantidad inválida, ingresar nuevamente: ");
        ama = Convert.ToInt16(Console.ReadLine()!);
    }
}