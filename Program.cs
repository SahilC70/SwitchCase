using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Calculator");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Substract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                Console.Write("Enter Choice(1-4):");
                int ch = int.Parse(Console.ReadLine());
                int a, b, c;
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter A:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Enter B:");
                        b = int.Parse(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("Sum = {0}", c);
                        break;
                    case 2:
                        Console.Write("Enter A:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Enter B:");
                        b = int.Parse(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine("Difference = {0}", c);
                        break;
                    case 3:
                        Console.Write("Enter A:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Enter B:");
                        b = int.Parse(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine("Product = {0}", c);
                        break;
                    case 4:
                        Console.Write("Enter A:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Enter B:");
                        b = int.Parse(Console.ReadLine());
                        c = a / b;
                        Console.WriteLine("Quotient = {0}", c);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            Console.ReadLine();
        }
    }
}