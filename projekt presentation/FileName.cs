using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_presentation
{
    internal class FileName
    {
    }
}
class Calculator
{
    private double result = 0;
    private string expression = "";
    private bool firstInput = true;

    public void ProcessInput(string input)
    {
        ProcessInput(input, result);
    }

    public void ProcessInput(string input, double result)
    {
        if (firstInput)
        {
            
            result = double.Parse(input); 
            expression = input;
            firstInput = false;
        }
        else
        {
            expression += " " + input;

            if (double.TryParse(input, out double number))
            {
                result = number;
            }
            else
            {
                Operation operation = new Operation(input, result);
                result = operation.Execute();
            }
        }

        Console.WriteLine($"Resultat: {result}");
        Console.WriteLine($"{expression} = {result}");
    }
}
