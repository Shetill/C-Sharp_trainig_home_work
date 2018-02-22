using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1_Lesson3_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region metodichka
            //ComplexStruct a, b;
            //a.im = 1;
            //a.re = 2;
            //b = a;

            //// Описали ссылку на объект.
            //Complex x1;
            //// Создали объект и сохранили ссылку на него в x1.
            //x1 = new Complex(1,2);
            //// Описали объект и создали его.
            //Complex x2 = new Complex(2, 4);
            //// С помощью свойства Im изменили внутреннее (приватное) поле im.
            //x2.lm = 3;
            //Complex x3;
            //// Так как в методе Plus создается новый объект,
            //// то в x3 сохраняем ссылку на вновь созданный объект.
            //x3 = x1.Plus(x2);
            //Console.WriteLine(x3.ToString());
            #endregion
            //Home work. Question 1 
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
            TestingStructComplex();
            // б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
            TestingClassComplex();

            //Home work. Question 2
            //а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
            //Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран; Используя tryParse;
            //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.

            int a = 0;//сумма чисел
            string b = "";//Список суммируемых чисел;
            GetGoodNumberSum(ref a, ref b);
            Console.WriteLine("Сумма всех нечетных положительных чисел: {0} = {1}", b, a);


            //Home work. Question 3
            //3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
            //Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
            //Написать программу, демонстрирующую все разработанные элементы класса.
            MyClassDemo();
            Console.ReadKey();
        }
        private static void GetGoodNumberSum(ref int _a, ref string _b)
        {

            int c = 0;
            do
            {
                Console.WriteLine("Введите любое целое число (для завершения введите 0): ");

                ////Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран; Используя tryParse;
                // bool flag = int.TryParse(Console.ReadLine(), out c);



                //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.
                try
                {
                    c = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Не верно введены данные! Программа будет завершена");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    break;
                }

                if (c % 2 != 0 && c > 0)
                {
                    _a = +c;
                    _b = _b + " " + c + " +";
                }

                if (c == 0) _b = _b + " " + c;

            }
            while (c != 0);

        }
        static void TestingStructComplex()
        {
            ComplexStruct x, y;
            y.im = 2;
            y.re = 2;
            x.im = 3;
            x.re = 5;
            x.Minus(y);

        }
        static void TestingClassComplex()
        {
            Complex x2 = new Complex(2, 4);
            Complex x3;
            x3 = x2.Minus(x2);
            Complex x4;
            x4 = x3.Multi(x2);

        }
        static void MyClassDemo()
        {
            Fractions fr = new Fractions(0.265, 1.252);
            Console.WriteLine("Результать вычитания:  {0}", fr.Minus());
            Console.WriteLine("Результать сложения:  {0}", fr.Plus());
            Console.WriteLine("Результать умножения:  {0}", fr.Multi());
            Console.WriteLine("Результать деления:  {0}", fr.Div());

        }
    }
}
