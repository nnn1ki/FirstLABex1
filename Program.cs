using System;

/* 11
Даны вещественные положительные числа a, b, c. 
Если существует треугольник со сторонами a, b, c, то определить, является ли он прямоугольным. 
*/

namespace FirstLAB
{
    public class Program
    {
        //сравнение двух сторон треугольника
        public static bool Logic(int x, int y)
        {
            if (x > y)
            {
                return true;
            }
            else return false;
        }

        //прямоугольный треугольник или нет
        public static bool IsRectangle(int a, int b, int c)
        {
            var mass = new int[] { a, b, c };
            Array.Sort(mass);

            if (Math.Pow(mass[2], 2) >= Math.Pow(mass[1], 2) + Math.Pow(mass[0], 2))
            {
                return true;
            }
            else return false;
        }

        //функция стравнения
        public static String Compare(int a, int b, int c)
        {
            String ans = "";
            
            if (Logic(a + b, c) && Logic(a + c, b) && Logic(b + c, a))
            {
                ans = "Треугольник существует!";
                if (IsRectangle(a, b, c))
                {
                    ans += "Треугольник прямоугольный!";
                }
                else ans += "Треугольник НЕ прямоугольный!";
            }
            else
            {
                ans = "Треугольника не существует!";
            }

            return ans;
        }

        //ввод значений
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника: ");

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            int numA = int.Parse(a);
            int numB = int.Parse(b);
            int numC = int.Parse(c);

            Console.WriteLine(Compare(numA, numB, numC));            
        }
    }
}
