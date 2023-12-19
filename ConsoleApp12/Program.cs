using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Вычислить значение функции для целых аргументов двумя способами (1-й способ: полный условный оператор; 2-й способ: тернарная операция):


            // Console.Write("Введите x: ");
            //int x = int.Parse(Console.ReadLine());
            /*   ПОЛНЫЙ УСЛОВНЫЙ ОПЕРАТОР
            if (x > 0)
            {
                double y = Math.Pow(Math.Sin(x), 2) * x;
                Console.Write(y);
            }
            else 
            {
                double y = 1 - 2 * Math.Sin(x) * Math.Pow(x, 2);
                Console.Write(y);
            }
            */

            //ТЕРНАРНАЯ ОПЕРАЦИЯ

            /*
            double y; 
            y = x>0?  y = Math.Pow(Math.Sin(x), 2) * x:  y = 1 - 2 * Math.Sin(x) * Math.Pow(x, 2);
            Console.WriteLine(y);
            */

            //2. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            /*
            Random rnd = new Random();
            int numb = rnd.Next(10, 99);
            string answer = numb % 2 == 0 ? "Число четное" : "Число нечетное";
            Console.WriteLine($"Сгенерированное число {numb} - {answer}");
            */

            //3. Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1; если хотя бы одно из них четное, уменьшить на 1;
            //если четных чисел нет, каждое число увеличить в 2 раза.

            /*
            Console.Write("Введеите первое число ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введеите второе число ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введеите третье число ");
            int c = int.Parse(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            {                
                a += 1;
                b += 1;
                c += 1;
            }
            else if (a % 2 == 0 | b % 2 == 0 | c % 2 == 0)
            {
                a -= 1; b -= 1; c -= 1;
            }
            else
            {
                a += 2;
                b += 2;
                c += 2;
            }


            Console.WriteLine($"Первое число = {a}\nВторое число = {b}\nТретье число = {c} ");
            */


            //4. По введенному номеру месяца выводится название поры года (зима, весна, лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр

            /*
            Console.Write("Введите номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:Console.Write("Время года - зима\n1 семестр");break;
                case 1:
                case 2:Console.Write("Время года - зима\n2 семестр");break;
                case 3:
                case 4:
                case 5:Console.Write("Время года - весна\n2 семестр");break;
                case 6:
                case 7:
                case 8:Console.Write("Время года - лето\n Каникулы");break;
                case 9:
                case 10:
                case 11:Console.Write("Время года - осень\n1 семестр");break;
                default: Console.WriteLine("Нужно ввести число от 1 до 12");break;
            }
            */






            Console.ReadLine();
        }
    }
}
