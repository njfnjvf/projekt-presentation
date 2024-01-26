using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_presentation
{
    internal class kknnwe
    {
    }
}
class Operation
{
    private string operation;
    private double result;

    public Operation(string operation, double result)
    {
        this.operation = operation;
        this.result = result;
    }

    public double Execute()
    {
        double operand = double.Parse(Console.ReadLine());

        switch (operation)
        {
            case "+":
                result += operand;
                break;
            case "-":
                result -= operand;
                break;
            case "*":
                result *= operand;
                break;
            case "/":
                if (operand == 0)
                {
                    Console.WriteLine("Kan inte dividera med noll. Försök igen.");
                }
                else
                {
                    result /= operand;
                }
                break;
            case "^":
                result = Math.Pow(result, operand);
                break;
            case "sqrt":
                if (result < 0)
                {
                    Console.WriteLine("Kan inte ta kvadratroten av ett negativt tal. Försök igen.");
                }
                else
                {
                    result = Math.Sqrt(result);
                }
                break;
            default:
                Console.WriteLine("Ogiltigt räknesätt. Försök igen.");
                break;
        }
        return result;
    }
}

