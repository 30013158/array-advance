using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            

            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {  
                int num = rand.Next(1,5);
                numbers[i] = num;
            }
            foreach(int n in numbers)
            { Console.WriteLine(n); }

           int counter = 0;
            if(numbers[counter] == 1)
            { counter++;
                Console.WriteLine($"The frequency of  number 1 is {counter} ");
                
            }


            Console.ReadLine();
        }
        
    }
}
