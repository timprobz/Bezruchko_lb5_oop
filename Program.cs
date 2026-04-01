using System;

namespace Lab05_Variant2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char c1, c2, c3;

            try
            {
                Console.WriteLine("Введіть три символи (кожен з нового рядка):");

                
                c1 = Console.ReadKey().KeyChar;
                Console.WriteLine(); 
                c2 = Console.ReadKey().KeyChar;
                Console.WriteLine();
                c3 = Console.ReadKey().KeyChar;
                Console.WriteLine("\n---");

                
                string combinedString = $"{c1}{c2}{c3}";

                
                if (int.TryParse(combinedString, out int result))
                {
                    
                    Console.WriteLine($"Число успішно утворене: {result}");
                }
                else
                {
                    
                    Console.WriteLine("Помилка: Число не може бути утворене (введені символи не є цифрами).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }

            
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}