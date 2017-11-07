using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameR
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(10);
            int count = 1;

            Class Tekst = new Class();
            Tekst.ShowResult();
            
            int k = Convert.ToInt32(Console.ReadLine());
            while(count <= 5)
            {
                if (i == k)
                {
                    Console.WriteLine("Ура! Компютер загадав число " + k + "!");
                    break;
                }
                else
                {
                    count++;
                    if (count == 6)
                    {
                        Console.WriteLine("Нажаль ви не вгадали число. Це число " + i + "!");
                        break;
                    }
                    Console.WriteLine("Нажаль це не число " + k + "!");
                    Console.WriteLine("Спроба № " + count + ":");

                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
