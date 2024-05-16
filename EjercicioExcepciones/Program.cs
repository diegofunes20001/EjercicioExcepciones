using EjercicioExcepciones;

OpeeracionesBasicas operaciones = new OpeeracionesBasicas();

while (true)
{
    Console.WriteLine("Menú de operaciones básicas");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");

    Console.Write("Ingrese una opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La suma es: {operaciones.Sumar(num1, num2)}");
            break;
        case 2:
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La resta es: {operaciones.Restar(num1, num2)}");
            break;
        case 3:
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La multiplicación es: {operaciones.Multiplicar(num1, num2)}");
            break;
        case 4:
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            try
            {
                Console.WriteLine($"La división es: {operaciones.Dividir(num1, num2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case 5:
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }

    Console.WriteLine();
}
