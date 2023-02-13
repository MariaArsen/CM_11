using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
           
            Line line = new Line(k,b);
            Console.WriteLine(line.Root());
            Console.ReadKey();
        }
    }
}
