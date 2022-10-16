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
            //string row = string.Empty;
            
            for (int i = 0; i <= 5; i++)
            { 
                int countOfint = 4-i;
                int countOfnumber = i;
                
                string row = new string('+' , countOfint) + new string('i', countOfnumber);
                Console.WriteLine(row);

            }

        }
    }
}
