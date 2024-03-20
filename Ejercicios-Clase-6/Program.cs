//Ejercicios con Funciones
using System.ComponentModel;

static void ejercicio1()
{
    int[] numEntero = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int suma = 0;
    for (int i = 0; i < numEntero.Length; i++)
    {
        if (numEntero[i] % 2 == 0)
        {
            suma += numEntero[i];
        }
    }
    Console.WriteLine($"La suma de los elementos pares es: {suma}");
}

static void ejercicio2()
{
    int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int[] invertido = new int [original.Length];

    for (int i = 0; i < original.Length; i++)
    {
        invertido[i] = original[original.Length - 1 - i];
    }
    Console.WriteLine("Arreglo original: ");
    impresion(original);
    Console.WriteLine("Arreglo invertido: ");
    impresion(invertido); 
}

static void impresion(int[] arreglo)
{
    foreach (int num in arreglo)
    {
        Console.Write(num + " , ");
    }
    Console.WriteLine();
}

static void ejercicio3()
{
    int[] arreglo = { 4, 7, 9, 10, 15};
    int maximo = busMaximo(arreglo);
    Console.WriteLine($"El maximo es {maximo}");
}

static int busMaximo(int[] numeros)
{
    int maximo = numeros[0];

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] > maximo)
        {
            maximo = numeros[i];
        }
    }
    return maximo;
}

static void ejercicio4()
{
    int[] arreglo = { 1, 2, 3, 4, 5, 6};
    int ValBuscar = 6;

    int posicion = busVal(arreglo, ValBuscar);

    if (posicion != -1)
    {
        Console.WriteLine($"El valor {ValBuscar} esta en la posicion {posicion} de este arreglo");
    }
    else
    {
        Console.WriteLine($"El valor {ValBuscar} no se encuentra en este arreglo");
    }
}

static int busVal(int[] numeros, int valor)
{
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] == valor)
        {
            return i;
        }
    }
    return -1;
}

static void ejercicio5()
{
    int[] arreglo = { 3, 8, 2, 5, 9, 1 };
    int[] OrdenarArreglo = Organizacion(arreglo);
    Console.WriteLine("Arreglo Original");
    Impresion(arreglo);
    Console.WriteLine("Arreglo Ordenado");
    Impresion(OrdenarArreglo);
}

static int[] Organizacion(int[] arreglo)
{
    int[] OrdenarArreglo = new int[arreglo.Length];
    Array.Copy(arreglo, OrdenarArreglo, arreglo.Length);
    Array.Sort(OrdenarArreglo);
    return OrdenarArreglo;
}

static void Impresion(int[] arreglo)
{
    foreach(int num in arreglo)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

//Utilización de metodos Array

static void ejer1()
{
    Console.WriteLine("Ingrese una lista de nombres separados por coma: ");
    String entrada = Console.ReadLine();
    String[] nombres = entrada.Split(",");
    String[] nombresOrdenados = orden(nombres);
    Console.WriteLine("Nombres Ordenados");
    Imprimir(nombresOrdenados);
}

static string[] orden(string[]nombres)
{
    string[] nombreOrdenado = new string[nombres.Length];
    Array.Copy(nombres, nombreOrdenado, nombres.Length);
    Array.Sort(nombreOrdenado);
    return nombreOrdenado;
}

static void Imprimir(String[]nombres)
{
    foreach (string name in nombres)
    {
        Console.Write(name + " ");
    }
    Console.WriteLine();
}

static void ejer2()
{
    Console.WriteLine("Ingrese una lista de numeros enteros separados por espacios:");
    String Entrada = Console.ReadLine();

    String[] NumS = Entrada.Split(' ');
    int[] NumI = new int[NumS.Length];

    for (int i = 0; i < NumS.Length; i++)
    {
        NumI[i] = int.Parse(NumS[i]);
    }
    int maximo = NumI.Max();
    int minimo = NumI.Min();

    Console.WriteLine($"El numero maximo es: {maximo}");
    Console.WriteLine($"El numnero minimo es: {minimo}");
}



static void ejer3()
{
    String[] paises = {"Guatemala", "El Salvador", "Canada", "Mexico", "Suiza"};
    Console.WriteLine("Ingrese el nombre del pais que desea buscar: ");
    String Entrada = Console.ReadLine();
    int Bus = Array.IndexOf(paises, Entrada);
    if (Bus != -1)
    {
        Console.WriteLine($"El nombre del pais {Entrada} si se encuentra en el arreglo en la posicion {Bus}");
    }
    else
    {
        Console.WriteLine($"El nombre del pais {Entrada} no se encuentra en el arreglo");
    }

}


static void ejer4()
{
    int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
    Console.WriteLine("Orden Original");
    impresionarreglo(num);
    Array.Reverse(num);

    Console.WriteLine("\nOrden Invertido");
    impresionarreglo(num);
}


static void impresionarreglo(int[] arreglo)
{
    foreach(int n in arreglo)
    {
        Console.Write(n + " ");
    }
}



static void ejer5()
{
    
    Console.WriteLine("Ingrese una lista de calificaciones separadas por coma:");
    string entrada = Console.ReadLine();

   
    string[] calificacioneS = entrada.Split(',');

    
    int[] calificaciones = new int[calificacioneS.Length];
    for (int i = 0; i < calificacioneS.Length; i++)
    {
        calificaciones[i] = int.Parse(calificacioneS[i].Trim());
    }

    
    bool val = Array.Exists(calificaciones, x => x >= 90);

   
    if (val)
    {
        Console.WriteLine("Se encontraron calificaciones sobresalientes en la lista.");
    }
    else
    {
        Console.WriteLine("No se encontraron calificaciones sobresalientes en la lista.");
    }

    Console.ReadLine();
}