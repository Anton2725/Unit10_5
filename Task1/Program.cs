using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создайте консольный мини - калькулятор, который будет подсчитывать сумму двух чисел.
            //Определите интерфейс для функции сложения числа и реализуйте его.
            //Дополнительно: добавьте конструкцию Try / Catch / Finally для проверки корректности введённого значения.

            Console.WriteLine("Для сложения введите последовательно два числа:");

            Calc calc = new Calc();
            var a = Calc.ReadNumber();
            var b = Calc.ReadNumber();

            var sum = calc.Sum(a, b);

            Console.WriteLine($"{a} + {b} = {sum}");

            Console.ReadKey();

        }

    }
}
