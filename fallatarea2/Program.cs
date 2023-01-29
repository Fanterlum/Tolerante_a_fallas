using System;

namespace CheckedUncheckedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            int b = int.MaxValue;
            int result;

            try
            {
                // Utiliza la cláusula checked para habilitar la revisión de desbordamiento
                result = checked(a + b);
                Console.WriteLine("Resultado con la cláusula checked: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Utiliza la cláusula unchecked para deshabilitar la revisión de desbordamiento
            result = unchecked(a + b);
            Console.WriteLine("Resultado con la cláusula unchecked: " + result);

            Console.ReadLine();
        }
    }
}