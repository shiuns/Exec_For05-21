using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_For05___21謝孟勳
{
    //用迴圈呈現指定右側的結果
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "1", "2", "3", "4", "5" };
            
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5 - i - 1; k++)
                {
                    Console.Write("+");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write(numbers[i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
