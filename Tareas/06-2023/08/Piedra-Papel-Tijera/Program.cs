static void ingresar(ref int jug, ref int rondas, ref string[] nom)
{
    Console.Write("¿Cuantos jugadores van a jugar? ");
    jug = Convert.ToInt16(Console.ReadLine());
    validarNum(ref jug, 0, 10);
    Array.Resize(ref nom, jug);

    Console.Write("¿Cuantas rondas? ");
    rondas = Convert.ToInt16(Console.ReadLine());
    validarNum(ref rondas, 0, 10);

    for(int i=0; i < jug; i++)
    {
        Console.Write($"Ingrese nombre del {i+1}° jugador: ");
        nom[i] = Console.ReadLine()!;
        validarString(ref nom, i);
    }
}

static void validarNum(ref int var, int piso, int tope)
{
    while(var <= 0 || var > 10)
    {
        Console.Write("El valor debe estar entre 1-10, ingrese nuevamente: ");
        var = Convert.ToInt16(Console.ReadLine());
    }
}

static void validarString(ref string[] var, int i)
{
    while(String.IsNullOrEmpty(var[i]))
    {
        Console.Write("La cadena no puede ser vacía, ingrese nuevamente: ");
        var[i] = Console.ReadLine()!;
    }
}

static int validarElec(ref string var)
{
    while(var != "R" && var != "P" && var != "T")
    {
        Console.Write("Opción inválida, ingrese nuevamente: ");
        var = Console.ReadLine()!;
    }
    return var == "R"? 0 : var == "P"? 1 : 2;
}

static void jugar(ref int[,] puntos, int i)
{
    string[] opc = new string[]{"Piedra", "Papel", "Tijera"};
    int[] opc_per = new int[]{1, 2, 0};

    Console.Write($"¿Que elegís? (R-Piedra | P-Papel | T-Tijera): ");
    string elec = Console.ReadLine()!;
    int elec_t = validarElec(ref elec);

    Random num = new Random();
    int num_t = Convert.ToInt16(num.Next(0, 3));

    if(opc_per[elec_t] == num_t)
    {
        Console.WriteLine($"Elegí {opc[num_t]}, perdiste :D");
        puntuacion(ref puntos, i, -1);
    }
    else if (opc_per[elec_t] != num_t && elec_t != num_t)
    {
        Console.WriteLine($"Elegí {opc[num_t]}, ganaste :c");
        puntuacion(ref puntos, i, 2);
    }
    else
    {
        Console.WriteLine($"Elegí {opc[num_t]}, empate :/");
        puntuacion(ref puntos, i, 0);
    }
}

static void puntuacion(ref int[,] puntos, int i, int val)
{
    puntos[i,0] = puntos[i,0] + val;
    Console.WriteLine($"{val} puntos, puntuación total: {puntos[i,0]}\n");
}

int jug = 0, rondas = 0;
string[] nom = new string[jug];

ingresar(ref jug, ref rondas, ref nom);
int[,] puntos = new int[nom.Length,1];

for(int i=0; i < jug; i++)
{
    Console.WriteLine($"¡Bienvenido {nom[i]}!");
    for(int j=0; j < rondas; j++)
    {
        jugar(ref puntos, i);
    }
    Console.WriteLine($"El ganador es {nom[puntos[0,0]]} con {puntos[0,1]} puntos\n");
}