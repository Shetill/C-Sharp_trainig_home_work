using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1_Lesson2_HW
{
    class Program
    {

        static void Main(string[] args)
        {

            int setProg = GetUserSetProgram();

            switch (setProg)
            {
                case 1://Задача № 1 - Написать метод возвращающий минимальное из трех чисел;
                    Console.WriteLine(GetMinDig(5, 12, 3));
                    break;

                case 2://Задача № 2 - Написать метод подсчета количества цифр числа;
                    Console.WriteLine(GetCountChar(1234567));
                    break;

                case 3://Задача № 3 - С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел;
                    Console.WriteLine(GetSumOddDig());
                    break;

                case 4://Задача № 4 - Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел. 
                       //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками;
                    Authorization();
                    break;

                case 5://задача № 5 - а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
                       //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
                    Console.WriteLine(RecomendDiet());
                    break;
                case 6://задача № 6 - *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000.
                       //Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
                    Console.WriteLine("Количество хороших чисел, в заданном диапозоне = {0}", GetCountGoodDig());
                    break;
                case 7://Задача № 7 - a) Разработать рекурсивный метод, который выводит на экран числа от a до b; 
                       //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
                    int a = 1, b = 8;
                    PrintDigRecurs(a, b);
                    GetSumDigRecurs(a, b, 0);
                    break;

                default:
                    Console.WriteLine("Нет такой команды - бро!");
                    Environment.Exit(0);
                    break;

            }

            Console.ReadKey();
        }


        //Question 1
        static int GetMinDig(int a, int b, int c)

        {
            int min;

            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else min = c;

            return min;

        }

        //Question 2
        static int GetCountChar(int a)
        {
            string b = a.ToString();
            return b.Length;
        }

        //Question 3
        static int GetSumOddDig()
        {
            int a, count = 0;
            do
            {
                Console.WriteLine("Введите любое число, для завершения ввода введите - 0");
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0) count++;
            }
            while (a != 0);
            return count;
        }

        //Question 4
        static bool LoginPass(string _l, string _p)
        {
            string log = "ich", pass = "123";
            return _l == log && _p == pass;
        }

        //Question 4
        static void Authorization()
        {
            string in_log, in_pass;
            var count = 3;

            do
            {
                Console.WriteLine("Введите логин и пароль у вас осталось {0} попытки(ка)", count);
                Console.WriteLine("Логин");
                in_log = Console.ReadLine();
                Console.WriteLine("Пароль");
                in_pass = Console.ReadLine();
                if (LoginPass(in_log, in_pass))
                {
                    Console.WriteLine("Авторизация прошла успешно");
                    count = 0;
                }
                else
                {
                    Console.WriteLine("Авторизация не удалась");
                    count--;
                }
            }
            while (count != 0);

        }

        //Question 5
        static double GetCalcBMI()
        {
            Console.WriteLine("Укажите свой рост (в метрах)");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Укажите свой вес (в кг)");
            double b = double.Parse(Console.ReadLine());
            return b / Math.Pow(a, 2);
        }

        //Question 5
        static string RecomendDiet()
        {
            double bmi = GetCalcBMI();
            string recom = "";
            if (bmi <= 16.5)
            {
                recom = "Крайний недостаток веса. Вы - ну очень мало кушаете.";
            }
            else if (bmi <= 18.4)
            {
                recom = "Недостаток в весе. нужно больше кушать";
            }
            else if (bmi <= 24.9)
            {
                recom = "Нормальный вес тела. Просто поддерживайте даннный показатель, чтобы чувствовать себя превосходно";
            }
            else if (bmi <= 30)
            {
                recom = "Избыточная масса тела. Вам необходимо немного ограничить себя в еде";
            }
            else if (bmi <= 34.9)
            {
                recom = "Ожирение (Класс I). Надо меньше кушать.";
            }
            else if (bmi <= 40)
            {
                recom = "Ожирение (Класс II - тяжелое). Хватит жрать!!!";
            }
            else if (bmi > 40)
            {
                recom = "Ожирение (Класс III - крайне тяжелое). Вам нужно срочно к доктору";
            }
            else
            {
                recom = "Или вы ввели неверные данные или же вы мутант или пришелец";
            }
            return recom;
        }

        //Question 6
        private static int GetCountGoodDig()
        {

            int start = 1;
            int end = 1000000;
            int count = 0;
            DateTime start_time = DateTime.Now;
            for (int i = start; i < end; i++)
            {
                if (i % GetSumDig(i) == 0)
                {
                    count++;
                }
            }
            DateTime end_time = DateTime.Now;
            Console.WriteLine("Время выполнения рассчета - {0} ", end_time - start_time);
            return count;

        }

        //Question 6
        private static int GetSumDig(int _a)
        {
            int sum = 0;

            foreach (char c in _a.ToString())
            {
                sum += int.Parse(c.ToString());
            }

            return sum;
        }

        //Question 7
        private static void PrintDigRecurs(int _start, int _end)
        {
            Console.WriteLine("{0,4}", _start);
            if (_start < _end) PrintDigRecurs(_start + 1, _end);
        }

        //Question 7
        private static void GetSumDigRecurs(int _a, int _b, int sum)
        {
            sum += _a;
            if (_a < _b) GetSumDigRecurs(_a + 1, _b, sum);
            else Console.WriteLine("Сумма чисел = {0}", sum);
        }


        //other
        static int GetUserSetProgram()
        {
            Console.WriteLine("Выберите программу: \n\r 1 - Вернуть минимальное из трех чисел; \n\r 2 - Подсчет количества цифр числа; \n\r 3 - Сумма нечетных положительных; \n\r" +
                " 4 - Авторизация; \n\r 5 - Расчет ИМТ и рекомендации; \n\r 6 - Количество хороших числел от 0 до 1 000 000 \n\r 7 - Вывод чисел от А до В и суммы этих чисел");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                return a;
            }
            else
            {
                return 0;
            }
        }

    }
}
