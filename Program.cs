using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._0
{
    class Program
    {

       
        static void Main(string[] args)
        {
            int[] array = new int[20];

            int count = 0;

            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = r.Next(-10000, 10000);
                
                if (i % 3 == 0 && i + 1 % 3 == 0)
                {
                    count = count + 0;
                }
                


                    if (i % 3 != 0 && i + 1 % 3 != 0)
                    {

                        count = count + 0;
                    }
                

                 

                else
                    count++;

            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

    }
}
