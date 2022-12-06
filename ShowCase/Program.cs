using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Ingrese texto: {input}");
            Console.WriteLine("Comienza con mayúsculas? " +
                 $"{(input.StartsWithUpper() ? "Sí" : "No")}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Pulse cualquier tecla para continuar...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Presione <Enter> solo para salir; de lo contrario, ingrese una cadena y presione <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}