using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Vänligen ange ett tal och räknesätt (+, -, *, /, ^, sqrt) eller tryck på Enter för att avsluta:");
                string input = Console.ReadLine();
                Convert.ToDouble(input);

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                calculator.ProcessInput(input);
            }
        }
    }
}

