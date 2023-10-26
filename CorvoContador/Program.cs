
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorvoContador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] results = new int[3];
            int resultIndex = 0;
            int currentNumber = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == null)
                    break;

                if (input == "caw caw")
                {
                    results[resultIndex] = currentNumber;
                    resultIndex++;

                    if (resultIndex == 3)
                        break;

                    currentNumber = 0;
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        char eye = input[i];
                        if (eye == '*')
                        {
                            currentNumber |= 1 << (2 - i); 
                        }
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(results[i]);

            }
            Console.ReadLine();
        }
    }
}

