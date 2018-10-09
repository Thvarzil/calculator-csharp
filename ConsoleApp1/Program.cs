using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string operand = Console.ReadLine();
            string secondNum = Console.ReadLine();
            int parsed1;
            int parsed2;
            bool check1 = int.TryParse(firstNum, out parsed1);
            bool check2 = int.TryParse(secondNum, out parsed2);


            if(!check1 || !check2){
                Console.WriteLine("Error: non-integer value detected");
            }
            else if (operand=="*") {
                Console.WriteLine(parsed1 * parsed2);
            }
            else if (operand == "/")
            {
                Console.WriteLine(parsed1 / parsed2);
            }
            else if (operand == "+")
            {
                Console.WriteLine(parsed1 + parsed2);
            }
            else if (operand == "-")
            {
                Console.WriteLine(parsed1 - parsed2);
            }
            else
            {
                Console.WriteLine("Error: Unsupported operand");
            }
        }
    }
}
