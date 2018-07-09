using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string expression;

            Console.WriteLine("Введите выражение вида: 'X действие Y'");
            expression = Console.ReadLine();
            string pattern = @"(\d+)\s?([-+*/])\s?(\d+)";
            foreach (Match m in Regex.Matches(expression, pattern))
            {
                firstValue = Int32.Parse(m.Groups[1].Value);
                secondValue = Int32.Parse(m.Groups[3].Value);
                switch (m.Groups[2].Value)
                {
                    case "+":
                        Console.WriteLine("{0} = {1}", m.Value, firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine("{0} = {1}", m.Value, firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine("{0} = {1}", m.Value, firstValue * secondValue);
                        break;
                    case "/":
                        Console.WriteLine("{0} = {1:N2}", m.Value, firstValue / secondValue);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
