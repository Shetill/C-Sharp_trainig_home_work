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
            //Question 1
            Task_1();

            Console.ReadKey();
        }

        private static void Task_1()
        {
            
            // 1.Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 - х до 10 - ти символов, содержащая только буквы и цифры, и при этом цифра не может быть первой. 
            Console.Write("Введите логин: ");     
            var login = Console.ReadLine();

            //// а) без использования регулярных выражений;
            //var res = GetCorrectLogin(login) ? "корректен" : "не корректен";
            //Console.WriteLine("Логин {0}", res);
            // б) **с использованием регулярных выражений.
            var res2 = GetCorrectLoginToRegular(login) ? "корректен" : "не корректен";
            Console.WriteLine("Логин {0}", res2);


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
            Regex rgx = new Regex(@"^\D");
            return rgx.IsMatch(log);

        }
    }
}
