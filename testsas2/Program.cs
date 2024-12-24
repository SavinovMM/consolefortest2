using System;
using mylibrary1;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса для вычисления
            Class1 evaluator = new Class1();

            Console.WriteLine("Введите коэффициенты квадратного уравнения (ax^2 + bx + c = 0):");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Вычисляем дискриминант
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                // Один корень
                double x = -b / (2 * a);
                Console.WriteLine($"Корень уравнения: x = {x}");
            }
            else
            {
                // Нет действительных корней
                Console.WriteLine("Уравнение не имеет действительных корней.");
            }
        }
    }
}