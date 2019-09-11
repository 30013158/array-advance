using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Please enter ten numbers for this program\n\n");
            double[] elements = new double[10];
            for(int i=0; i<elements.Length; i++)
            {
                Console.Write($"Please enter {i + 1} element: ");
                elements[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The numbers you entered were: ");
            foreach(double e in elements)
            {
                
                Console.WriteLine(e);
                
            }
            Console.ReadLine();
        }
    }
}
