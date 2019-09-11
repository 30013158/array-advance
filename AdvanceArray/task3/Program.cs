using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unique = new int[100];
            Random rand = new Random();
            for(int i=0; i<unique.Length; i++)
            {
                int populate = rand.Next(100, 300);
                while (unique.Contains(populate))
                    populate = rand.Next(100, 300);
                Array.Sort(unique);
                unique[i] = populate;
                   
            }
            foreach (int x in unique)
                Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
