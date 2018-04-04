using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lvl1_lesson5_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Question 1
            //Task_1();

            //Question 2
            //Task_2();

            //Question 3
            Task_3();

            Console.ReadKey();
        }

        private static void Task_1()
        {
            
            // 1.Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 - х до 10 - ти символов, содержащая только буквы и цифры, и при этом цифра не может быть первой. 
            Console.Write("Введите логин: ");     
            var login = Console.ReadLine();

            // а) без использования регулярных выражений;
            var res = GetCorrectLogin(login) ? "корректен" : "не корректен";
            Console.WriteLine("Логин {0} (обычная проверка)", res);
            // б) **с использованием регулярных выражений.
            var res2 = GetCorrectLoginToRegular(login) ? "корректен" : "не корректен";
            Console.WriteLine("Логин {0} ()проверка через шалобн регулярных выражения", res2);

        }
        private static void Task_2()
        {
            // 2.Разработать методы для решения следующих задач.Дано сообщение: 
            MyString mystr = new MyString();
            mystr.Msg = "Welcome to Hell";
           

            // а) Вывести только те слова сообщения,  которые содержат не более чем n букв;
            int n = 4;
            var  message = mystr.GetMsg(n);
            Console.WriteLine("Слова которые содержат не более 4-х букв: {0}", message);

            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
            char sym = 'o';
            mystr.DeleteToEndSymbol(sym);
            // в) Найти самое длинное слово сообщения;
            // г) Найти все самые длинные слова сообщения. 
            ////Постарайтесь разработать класс MyString 

        }
        private static void Task_3()
        {
            //Question 3
            //3.*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.Регистр можно не учитывать. 
            
            // а) с использованием методов C# 
            //ну не шмогла я, не шмогла)))
            
            // б) *разработав собственный алгоритм Например:  badc являются перестановкой abcd
           
            //для получения истинного результата
            string a = "123";
            string b = "312";
            string msg;
            bool result = CollateStrings(a, b);            
            msg = result ? "является измененой строкой" : "не является измененой строкой";
            Console.WriteLine("Строка \"{0}\" {1} \"{2}\"", a,msg,b);

            //для получения ложного результата
            a = "rty";
            b = "typ";
            result = CollateStrings(a, b);
            msg = result ? "является измененой строкой" : "не является строкой";
            Console.WriteLine("Строка \"{0}\" {1} \"{2}\"", a, msg, b);

        }

        private static bool GetCorrectLogin(string log)
        {
            //Проверим длину логина
            if(log.Length < 2 || log.Length > 10)
            {
                Console.WriteLine("Введеный пароль или слишком короткий или слишком длинный. Длина логина должна быть не менее 2-х и не более 10-ти символов");
                return false;
            }

            int i = 0;
            foreach (var item in log)
            {
               if (i==0 && char.IsNumber(item))
                {
                    Console.WriteLine("Логин не может начинаться с цифры!");
                    return false;
                }
                else if (!char.IsLetter(item) || !char.IsNumber(item))
                {
                    Console.WriteLine("Логин может состоять только из букв или цифр!");
                    return false;
                }
            }

            return true;
        }
        private static bool GetCorrectLoginToRegular(string log)
        {
            return Regex.IsMatch(log, "^[a-zA-Z][a-zA-Z0-9]{1,9}$");
        }
        private static bool CollateStrings(string a, string b)
        {
            //сначала сверим длину строк, если длина разная, то уже это не может быть перевернутая строка;
            if (a.Length != b.Length) return false;


            char[] arr = new char[a.Length];
            char[] arr2 = new char[b.Length];

            int i = 0;
            foreach (var item in a)
            {
                arr[i] = item;
                //Console.WriteLine(item);
                i++;
            }

            i = 0;
            foreach (var item in b)
            {
                arr2[i] = item;
                //Console.WriteLine(item);
                i++;
            }

            Array.Sort(arr);
            Array.Sort(arr2);

            for (i = 0; i < a.Length; i++)
            {
                if (arr[i] != arr2[i]) return false;
            }

            return true;
        }
    }
}
