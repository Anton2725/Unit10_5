using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calc : INumberWork
    {
        static public decimal ReadNumber()
        {
            while (true)
            {
                string numb = Console.ReadLine();
                try
                {
                    return decimal.Parse(numb);
                }
                catch
                {
                    Console.WriteLine("Введено не корректное значение! Попробуйте снова.");
                }
            }
        }

        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
