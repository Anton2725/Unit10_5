using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calc : INumberWork
    {
        ILogger Logger { get; }
        public Calc(ILogger logger)
        {
            Logger = logger;
        }
        public decimal ReadNumber()
        {
            Logger.Event("Ввод числа с клавиатуры");
            while (true)
            {
                string numb = Console.ReadLine();
                try
                {
                    return decimal.Parse(numb);
                }
                catch
                {
                    Logger.Error("Введено не корректное значение! Попробуйте снова.");
                }
            }
        }

        public decimal Sum(decimal a, decimal b)
        {
            var sum = a + b;
            Logger.Event($"Расчет {a} + {b} = {sum}");
            return sum;
        }
    }
}
