using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto5_Prova_Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, num;

            while(i <= 100)
            {
                i++;
                num = i % 2;

                if (num == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();  














        }
    }
}
