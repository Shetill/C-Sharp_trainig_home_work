using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1_Lesson1
{
    class Program
    {

        //Level(1)Lesson(1)
        static void Main(string[] args)
        {

            string text = "Выберите, что необходимо запустить: \n\r 1.Анкета \n\r 2.Расчёт ИМТ \n\r 3.Расчёт расстояния межуд точками \n\r 4.Поменять местами значение переменных \n\r 5.Вывести ФИО и город";

            Console.WriteLine(text);

            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1: RigistrationProfile(); //Задача № 1
                    break;
                case 2: CalcBMI(); //Задача № 2
                    break;
                case 3: CalcDistance(); //Задача № 3
                    break;
                case 4: ReverseVar(); // Задача № 4
                    break;
                case 5: PrintProfile(); //Задача № 5
                    break;
                default: Console.WriteLine("Воу - бро, что это было???");
                    break;
            }           
       

            PrintPause.Pause(); //Задача № 6

        }

        //Задача № 1 
        static void RigistrationProfile()
        {
            /* Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
               В результате вся информация выводится в одну строчку.
               а) используя склеивание;
               б) используя форматированный вывод.*/

            string fName;//Имя
            string name;//Фамилия
            int age;//Возраст  
            int height;//Рост
            int weight;//Вес

            //Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.Write("Введите ваше имя -");
            fName = Console.ReadLine();
            Console.Write("Введите вашу фамилию -");
            name = Console.ReadLine();
            Console.Write("Укажите ваш возраст -");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("рост -");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("вес -");
            weight = Convert.ToInt32(Console.ReadLine());
            string profile = "Имя -" + fName + "; фамилия - " + name + "; полных лет - " + age + "; рост - " + weight + "; вес - " + height;
            Console.WriteLine(profile); //через склеивание строк
            Console.WriteLine("Имя-{0} Фамилия-{1}; полных лет-{2}; рост-{3}; вес-{4}", fName, name, age, weight, height); //через форматированный вывод

        }

        //Задача № 2
        static void CalcBMI()
        {
            /* Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле:
               I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах */

            Console.Write("Укажите ваш вес - ");
            var wt = float.Parse(Console.ReadLine());
            Console.Write("Укажите ваш рост (в метрах) - ");
            var ht = float.Parse(Console.ReadLine());

            Console.WriteLine("Ваш ИМТ = {0}", wt / (ht * ht));

        }

        //Задача № 3
        static void CalcDistance()
        {
            /* а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
               Вывести результат используя спецификатор формата f2 (с двумя знаками после запятой);
               б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода; */

            double x1 = 23.12;
            double y1 = 25.25;
            double x2 = 12.12;
            double y2 = 15.15;

            double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:f2}", res);


        }

        //Задача № 4
        static void ReverseVar()
        {
            /* Написать программу обмена значениями двух переменных*/

            //а) с использованием третьей переменной;
            int a = 5;
            int b = 7;
            var c = a;
            a = b;
            b = c;

            //б) *без использования третьей переменной.
            a = a + b;
            b = a - b;
            a = a - b;

        }

        //Задача № 5
        static void PrintProfile()
        {
            /* а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания. */

            string fName = "Иванов";
            string name = "Иван";
            string city = "Санкт-Петербург";

            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Фамилия: {0} Имя: {1} город проживания: {2}", fName, name, city);

            // б) *Сделайте задание, только вывод организуйте в центре экрана
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Фамилия: {0} Имя: {1} \n\r город проживания: {2}", fName, name, city);

            // в) **Сделайте задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            string msg = "FirstName: " + fName + " Name: " + name + " City: " + city;

            PrintProfile(msg, 20, 20);

        }

        // Задача № 5 
        // в) **Сделайте задание б с использованием собственных методов(например, Print(string ms, int x, int y)
        static void PrintProfile(string msg, int x, int y)
        {

            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);

        }

        //Задача № 6 Создайте класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).


    }
}
