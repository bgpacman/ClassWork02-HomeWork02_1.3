using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write the \"b\" value of your triangle: ");
            decimal bSide = decimal.Parse(Console.ReadLine());

            Console.Write("Please write the \"h\" value of your triangle: ");
            decimal hSide = decimal.Parse(Console.ReadLine());

            decimal area = (bSide * hSide) / 2;
            Console.WriteLine("The area of your triangle is: {0}", area);
        }
    }
}
