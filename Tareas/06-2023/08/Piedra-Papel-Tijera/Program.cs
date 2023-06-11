static void ingresar(ref int jug, ref int rondas, ref string[] nom)
{
    Console.Write("¿Cuantos jugadores van a jugar? ");
    jug = Convert.ToInt16(Console.ReadLine());
    validarNum(ref jug, 0, 10);
    Array.Resize(ref nom, jug);
    Console.Write("¿Cuantas rondas? ");
    rondas = Convert.ToInt16(Console.ReadLine());
    validarNum(ref rondas, 0, 10);

    for (int i = 0; i < jug; i++)
    {
        Console.Write($"Ingrese nombre del {i + 1}° jugador: ");
        nom[i] = Console.ReadLine()!;
        validarString(ref nom, i);
    }
}

static void validarNum(ref int var, int piso, int tope)
{
    while (var <= 0 || var > 10)
    {
        Console.Write("El valor debe estar entre 1-10, ingrese nuevamente: ");
        var = Convert.ToInt16(Console.ReadLine());
    }
}

static void validarString(ref string[] var, int i)
{
    while (String.IsNullOrEmpty(var[i]))
    {
        Console.Write("La cadena no puede ser vacía, ingrese nuevamente: ");
        var[i] = Console.ReadLine()!;
    }
}

static int validarElec(ref string var)
{
    while (var != "R" && var != "P" && var != "T")
    {
        Console.Write("Opción inválida, ingrese nuevamente: ");
        var = Console.ReadLine()!;
    }
    return var == "R" ? 0 : var == "P" ? 1 : 2;
}

static void jugar(ref int[] puntos, int i, ref int[] parc)
{
    string[] opc = new string[] { "Piedra", "Papel", "Tijera" };
    int[] opc_per = new int[] { 1, 2, 0 };

    Console.Write($"¿Que elegís? (R-Piedra | P-Papel | T-Tijera): ");
    string elec = Console.ReadLine()!;
    int elec_t = validarElec(ref elec);
    Random num = new Random();
    int num_t = Convert.ToInt16(num.Next(0, 3));

    if (opc_per[elec_t] == num_t)
    {
        Console.WriteLine($"Elegí {opc[num_t]}, perdiste :D");
        puntuacion(ref puntos, i, -1, ref parc, 2);
    }
    else if (opc_per[elec_t] != num_t && elec_t != num_t)
    {
        Console.WriteLine($"Elegí {opc[num_t]}, ganaste :c");
        puntuacion(ref puntos, i, 2, ref parc, 0);
    }
    else
    {
        Console.WriteLine($"Elegí {opc[num_t]}, empate :/");
        puntuacion(ref puntos, i, 0, ref parc, 1);
    }
}

static void puntuacion(ref int[] puntos, int i, int val, ref int[] parc, int parc_val)
{
    puntos[i] = puntos[i] + val;
    parc[parc_val]++;
    parc[3]++;
    Console.WriteLine($"{val} puntos, puntuación total: {puntos[i]}");
    Console.WriteLine($"{parc[3]}° Tiro  Gan: {parc[0]}     Emp: {parc[1]}     Perd: {parc[2]}\n");
}

static void ganador(int[] puntos, string[] nom)
{
    Array.Sort(puntos, nom);
    Array.Reverse(puntos);
    Array.Reverse(nom);
    Console.Write($"El ganador es {nom[0]}");
    int i = 1;
    while (puntos[0] == puntos[i])
    {
        Console.Write($", {nom[i]}");
        i++;
    }
    Console.WriteLine($" con {puntos[0]} puntos.\nTabla de Posiciones:");

    for(int j=0; j<nom.Length; j++)
    {
        Console.WriteLine($"{nom[j]}    {puntos[j]} puntos.");
    }
}

static void ganadorParc(ref int[] array)
{
    if (array[0] > array[2])
    {
        Console.WriteLine("Le ganaste a la máquina, ¡felicitaciones!\n");
    }
    else if (array[0] < array[2])
    {
        Console.WriteLine("Perdiste con la máquina, ¡Que mal!\n");
    }
    else
    {
        Console.WriteLine("Empataste con la máquina, ¡Que aburrido!\n");
    }

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

int jug = 0, rondas = 0;
string[] nom = new string[jug];
int[] parc = new int[] { 0, 0, 0, 0 };

ingresar(ref jug, ref rondas, ref nom);
int[] puntos = new int[nom.Length];

for (int i = 0; i < jug; i++)
{
    Console.WriteLine($"¡Bienvenido/a {nom[i]}!");
    for (int j = 0; j < rondas; j++)
    {
        jugar(ref puntos, i, ref parc);
    }
    ganadorParc(ref parc);
}
ganador(puntos, nom);