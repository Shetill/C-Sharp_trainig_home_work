﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1_lesson4_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Home work. Question 1
            ////1.Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            ////Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
            ////В данной задаче под парой подразумевается два подряд идущих элемента массива. 
            ////Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
            //int[] arr;
            //Console.WriteLine("Количество пар чисел деляшихся на 3 = {0}", GetCountPair(arr = GetArr(20, -10000, 10000)));

            ////Home work. Question 2
            ////а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
            ////Cоздать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива,
            ////Метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
            ////В Main продемонстрировать работу класса.
            ////б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            //MyArr _arr = new MyArr(20, 1, 7);
            //Console.WriteLine("сумма элемнтов в массиве = {0}", _arr.Sum);
            //_arr.Inverse();
            //_arr.Multi(2);
            //_arr.Inverse();
            //_arr[19] = _arr[18];
            //Console.WriteLine("сумма элемнтов в массиве = {0}", _arr.MaxCount);

            //MyArr arr3 = new MyArr(@"D:\Array.txt");
            //arr3.SaveArrInFile(@"D:\saveArray.txt");

            ////Home work. Question 3
            ////Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.                           
            //if (LogIn(GetArrLogPass(@"d:\LogPass.txt")))
            //{
            //    Console.WriteLine("Вход успешен");
            //}
            //else
            //{
            //    Console.WriteLine("Не верный логин или пароль");
            //}

            ////Home work. Question 4
            ////*а) Реализовать класс для работы с двумерным массивом.Реализовать конструктор, заполняющиймассив случайными числами.
            ////Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
            ////возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод,
            ////возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
            ////**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

            //TwoLevelArray arr_l2 = new TwoLevelArray(3,3); //создание массива и заполнение его рандомными числами
            //Console.WriteLine("Сумма всех элементов массива = {0}",arr_l2.GetSumAllElements());
            //int max = 5;
            //Console.WriteLine("Сумма всех элементов массива, больше {0} = {1}", max, arr_l2.GetSumAllElementsMoreMax(max));
            //Console.WriteLine("Минимальное число в массиве = {0}", arr_l2.MinEl);
            //Console.WriteLine("Максимальное число в массиве = {0}", arr_l2.MaxEl);
            ////string index = "";
            //arr_l2.GetIndexMaxElemenet(out  string index);
            //Console.WriteLine("Индекс максимального значения  = {0}", index);

            //Home work. Question 5
            //5.Существует алгоритмическая игра “Удвоитель”. В этой игре человеку предлагается какое-то число, а человек должен,управляя роботом “Удвоитель”, достичь этого числа за минимальное число шагов.
            //Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и сбросить число до 1.Начальное значение удвоителя равно 1.
            //Реализовать класс “Удвоитель”. Класс хранит в себе поле current -текущее значение, finish - число, которого нужно достичь, конструктор, в котором задается конечное число.
            //Методы: увеличить число на 1, увеличить число в два раза, сброс текущего до 1, свойство Current, которое возвращает текущее значение, свойство Finish, которое возвращает конечное значение.
            //Создать с помощью этого класса игру, в которой компьютер загадывает число, а человек.выбирая из меню на экране, отдает команды удвоителю и старается получить это число за наименьшее число ходов.
            //Если человек получает число больше положенного, игра прекращается.

            Console.ReadKey();

        }

        static int GetCountPair(int[] _arr)
        {
            int a = 0; //первое число из пары
            int b = 0; //второе число из пары 
            int count = 0; //для подсчета пар
            for (int i = 0; i < _arr.Length; i++)
            {
                //если это начало цикла, то положим первое число из массива в переменную "а"
                if (i == 0) { a = _arr[i]; continue; }
                //на втором проходе цикла, положим вторе число в переменную "b"
                else if (i == 1)
                {
                    b = _arr[i];
                    //проверим делится что-нибудь на 3
                    if (a % 3 == 0 || b / 3 == 0) { count++; }
                }
                else
                {
                    a = b;
                    b = _arr[i];
                    //проверим делится что-нибудь на 3
                    if (a % 3 == 0 || b % 3 == 0) { count++; }
                }
            }

            return count;
        }
        static int[] GetArr(int _lenght, int _min, int _max)
        {
            int[] arr = new int[_lenght];
            int min = _min;
            int max = _max;
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
                //Console.WriteLine(arr[a]);
            }

            return arr;
        }
        static string[] GetArrLogPass(string filename)
        {
            StreamReader str = new StreamReader(filename);

            string logPassStr = str.ReadToEnd();
            return logPassStr.Split(' ', '\r', '\n');

        }
        static bool LogIn(string[] logpass)
        {
            string log = "ich", _log = "";
            string pass = "123", _pass = "";
            int i = 0;
            while (i < logpass.Length)
            {
                if (logpass[i] == "log")
                {
                    _log = logpass[i + 1];
                }
                if (logpass[i] == "pass")
                {
                    _pass = logpass[i + 1];
                }

                i++;
            }

            return log == _log && pass == _pass;

        }

        static void GameDoubler()
        {
            Random rnd = new Random();
            MyClassDoubler doub = new MyClassDoubler(rnd.Next());



        }


    }
}
