using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Calcular precio de venta con 15% de ganancia");
            Console.WriteLine("2. Campeonato estudiantil (mostrar puntaje total)");
            Console.WriteLine("3. Campeonato estudiantil (indicar si pasa a la última etapa)");
            Console.WriteLine("4. Suma de dígitos (número de 4 dígitos)");
            Console.WriteLine("5. Suma de dígitos (número con cualquier cantidad de dígitos)");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularPrecioVenta();
                    break;
                case 2:
                    CampeonatoSimple();
                    break;
                case 3:
                    CampeonatoConClasificacion();
                    break;
                case 4:
                    SumarDigitosFijos();
                    break;
                case 5:
                    SumarDigitosVariable();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida, intente nuevamente.");
                    break;
            }

        } while (opcion != 0);
    }

    // Punto 1
    static void CalcularPrecioVenta()
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());
        double precioFinal = precio * 1.15;
        Console.WriteLine($"El precio final de venta es: {precioFinal:F2}");
    }

    // Punto 2
    static void CampeonatoSimple()
    {
        string nombre;
        do
        {
            Console.Write("Ingrese el nombre del participante (FIN para terminar): ");
            nombre = Console.ReadLine();

            if (nombre.ToUpper() != "FIN")
            {
                Console.Write("Ingrese puntaje del jurado 1: ");
                int j1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese puntaje del jurado 2: ");
                int j2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese puntaje del jurado 3: ");
                int j3 = int.Parse(Console.ReadLine());

                int total = j1 + j2 + j3;

                Console.WriteLine($"Participante: {nombre}, Puntaje total: {total}");
            }

        } while (nombre.ToUpper() != "FIN");
    }

    // Punto 3
    static void CampeonatoConClasificacion()
    {
        string nombre;
        do
        {
            Console.Write("Ingrese el nombre del participante (FIN para terminar): ");
            nombre = Console.ReadLine();

            if (nombre.ToUpper() != "FIN")
            {
                Console.Write("Ingrese puntaje del jurado 1: ");
                int j1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese puntaje del jurado 2: ");
                int j2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese puntaje del jurado 3: ");
                int j3 = int.Parse(Console.ReadLine());

                int total = j1 + j2 + j3;

                Console.WriteLine($"Participante: {nombre}, Puntaje total: {total}");

                if (total > 80)
                    Console.WriteLine(">>> Pasa a la última etapa 🎉");
                else
                    Console.WriteLine(">>> No alcanzó la última etapa 😢");
            }

        } while (nombre.ToUpper() != "FIN");
    }

    // Punto 4
    static void SumarDigitosFijos()
    {
        Console.Write("Ingrese un número entero de 4 dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 1000 || numero > 9999)
        {
            Console.WriteLine("El número no tiene 4 dígitos.");
            return;
        }

        string numStr = numero.ToString();
        int suma = 0;

        Console.Write("Suma: ");
        for (int i = 0; i < numStr.Length; i++)
        {
            int digito = int.Parse(numStr[i].ToString());
            suma += digito;

            Console.Write(numStr[i]);
            if (i < numStr.Length - 1)
                Console.Write(" + ");
        }
        Console.WriteLine($" = {suma}");
    }

    // Punto 5
    static void SumarDigitosVariable()
    {
        Console.Write("Ingrese un número entero (cualquier cantidad de dígitos): ");
        string numStr = Console.ReadLine();

        int suma = 0;

        Console.Write("Suma: ");
        for (int i = 0; i < numStr.Length; i++)
        {
            int digito = int.Parse(numStr[i].ToString());
            suma += digito;

            Console.Write(numStr[i]);
            if (i < numStr.Length - 1)
                Console.Write(" + ");
        }
        Console.WriteLine($" = {suma}");
    }
}
