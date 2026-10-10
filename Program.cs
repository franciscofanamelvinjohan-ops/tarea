
Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la primera calificacion:");
    double calificacion1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la segunda calificacion:");
    double calificacion2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la tercera calificacion:");
    double calificacion3 = double.Parse(Console.ReadLine());
    double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;
    string resultado;
    if (promedio >= 90)
    {
        resultado = "A - Excelente";
    }
    else if (promedio >= 80)
    {
        resultado = "B - Bueno";
    }
    else if (promedio >= 70)
    {
        resultado = "C - Suficiente";
    }
    else
    {
        resultado = "D - Reprobado";
    }
    Console.WriteLine("\n--- Resultado Del Estudiante ---");
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("Calificacion 1: " + calificacion1);
    Console.WriteLine("Calificacion 2: " + calificacion2);
    Console.WriteLine("Calificacion 3: " + calificacion3);
    Console.WriteLine("Promedio: " + promedio);
    Console.WriteLine("Resultado: " + resultado);
