using System;

namespace Task2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            //Реализуйте механизм внедрения зависимостей: добавьте в мини - калькулятор логгер, используя материал из скринкаста юнита 10.1.
            //Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.

            Logger = new Logger();

            Console.WriteLine("Для сложения введите последовательно два числа:");

            var calc = new Calc(Logger);

            var a = calc.ReadNumber();
            var b = calc.ReadNumber();

            var sum = calc.Sum(a, b);
            Console.WriteLine($"{a} + {b} = {sum}");

            Console.ReadKey();
        }
    }
}
