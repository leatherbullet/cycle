using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userRepeat;

            Console.Write("введите количество повторений: ");
            userRepeat = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < userRepeat; i++)
            {
                Console.WriteLine("повторяется " + (userRepeat) + " раз.");
            }
        }
    }
}
