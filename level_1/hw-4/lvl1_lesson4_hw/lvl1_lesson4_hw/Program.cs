using System;
using System.IO;

namespace Level1_lesson4_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите действие. Номер пункта, число для выполнения действия: \n\r 1.Задача №1; \n\r 2.Задача №2 \n\r 3.Задача №3 \n\r 4.Задача №4 \n\r 5.Задача №5");
            bool result = Int32.TryParse(Console.ReadLine(), out int a);
            if (result)
            {
                switch (a)
                {
                    case 1:

                        Task_1();
                        break;

                    case 2:
                        Task_2();
                        break;

                    case 3:
                        Task_3();
                        break;

                    case 4:
                        Task_4();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Число команды, выходит за пределы доступных пунктов или введено не целое число");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            Console.ReadKey();
        }

        static void Task_1()
        {
            //Home work. Question 1
            //1.Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива. 
            //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

            int[] arr;
            Console.WriteLine("Количество пар чисел деляшихся на 3 = {0}", GetCountPair(arr = GetArr(20, -10000, 10000)));

        }
        static void Task_2()
        {
            //Home work. Question 2
            //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
            //Cоздать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива,
            //Метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
            //В Main продемонстрировать работу класса.
            //б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

            MyArr _arr = new MyArr(20, 1, 7);
            Console.WriteLine("сумма элемнтов в массиве = {0}", _arr.Sum);
            _arr.Inverse();
            _arr.Multi(2);
            _arr.Inverse();
            _arr[19] = _arr[18];
            Console.WriteLine("Количество максимальных элементов в массиве = {0}", _arr.MaxCount);

            MyArr arr3 = new MyArr(@"D:\Array.txt");
            arr3.SaveArrInFile(@"D:\saveArray.txt");

        }
        static void Task_3()
        {
            //Home work. Question 3
            //Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
            string[] LogPass = GetArrLogPass(@"d:\LogPass.txt");
            string log, pass;
            int att = 0;// Для расчета количества попыток ввода
            do
            {
                att++;
                Console.WriteLine("Введите логин:");
                log = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                pass = Console.ReadLine();
                if (LogIn(LogPass, log, pass))
                {
                    Console.WriteLine("Тадам - Заходи, друг!");
                    break;
                }
                else
                {
                    if (att == 3)
                    {
                        Console.WriteLine("Вы 3 раза ввели не верно пароль или логин, бай-бай!");
                        break;
                    }
                    Console.WriteLine("\n\rНеверный логин или пароль, попробуйте ещё разок. Осталось попыток({0})\n\r", 3 - att);
                }

            } while (att < 3);


        }
        static void Task_4()
        {
            //Home work. Question 4
            //*а) Реализовать класс для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
            //Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
            //возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод,
            //возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
            //**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

            TwoLevelArray arr_l2 = new TwoLevelArray(3, 3); //создание массива и заполнение его рандомными числами
            Console.WriteLine("Сумма всех элементов массива = {0}", arr_l2.GetSumAllElements());
            int max = 5;
            Console.WriteLine("Сумма всех элементов массива, больше {0} = {1}", max, arr_l2.GetSumAllElementsMoreMax(max));
            Console.WriteLine("Минимальное число в массиве = {0}", arr_l2.MinEl);
            Console.WriteLine("Максимальное число в массиве = {0}", arr_l2.MaxEl);
            //string index = "";
            arr_l2.GetIndexMaxElemenet(out string index);
            Console.WriteLine("Индекс максимального значения  = {0}", index);

        }
        static void Task_5()
        {
            //Home work. Question 5
            //5.Существует алгоритмическая игра “Удвоитель”. В этой игре человеку предлагается какое-то число, а человек должен,управляя роботом “Удвоитель”, достичь этого числа за минимальное число шагов.
            //Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и сбросить число до 1.Начальное значение удвоителя равно 1.
            //Реализовать класс “Удвоитель”. Класс хранит в себе поле current -текущее значение, finish - число, которого нужно достичь, конструктор, в котором задается конечное число.
            //Методы: увеличить число на 1, увеличить число в два раза, сброс текущего до 1, свойство Current, которое возвращает текущее значение, свойство Finish, которое возвращает конечное значение.
            //Создать с помощью этого класса игру, в которой компьютер загадывает число, а человек.выбирая из меню на экране, отдает команды удвоителю и старается получить это число за наименьшее число ходов.
            //Если человек получает число больше положенного, игра прекращается.

            Console.WriteLine("Добро пожаловать, в игру удвоитель. Цель игры достигнуть конечного числа (результат), за наименьшее количество ходов.");

            int i = 0; //сюда будем писать количество ходов
            Random rnd = new Random();
            int c = rnd.Next(1, 20);

            Console.WriteLine("Используя доступные команды получите результат  = {0}", c);

            //Создадим объект класса, с конечным числом (реузльтатом, которого необходимо достичь)
            MyClassDoubler mdoubx = new MyClassDoubler(c)
            {
                Current = 1 //начальное число;
            };


            do
            {
                Console.WriteLine("\n\rУправление: \n\rУвеличить число на один - 1 \n\rУмножить число на 2 - 2 \n\rСбросить число до 1 - 3");
                bool resinput = Int32.TryParse(Console.ReadLine(), out int b);  //b - число выбранного действия;
                if (resinput)
                {
                    switch (b)
                    {
                        case 1:
                            //Выбрано увеличить число на единицу. Увеличиваем!
                            mdoubx.GetUpOne();
                            Console.WriteLine(" Текущее число = {0}", mdoubx.Current);
                            break;

                        case 2:
                            //выбрано умножить на 2. Умножаем!                                      
                            mdoubx.GetMultiTwo();
                            Console.WriteLine(" Текущее число = {0}", mdoubx.Current);
                            break;

                        case 3:
                            //выбрано сброс до 1 (default). Сбрасываем!
                            mdoubx.GetBreakToOne();
                            Console.WriteLine(" Текущее число = {0}", mdoubx.Current);
                            break;

                        default:
                            //Введено число (команды) больше ожидаемого.
                            Console.WriteLine("Не верный выбор. Игра завершена, вы проиграли!!!");
                            break;
                    }
                }
                i++;
            } while (mdoubx.Current != mdoubx.finish);

            Console.WriteLine("Поздравляем, вы достигли нужного результата за {0} хода(ходов)", i);

        }

        static int GetCountPair(int[] _arr)
        {
            int a = 0; //первое число из пары
            int b = 0; //второе число из пары 
            int count = 0; //для подсчета пар
            for (int i = 0; i < _arr.Length; i++)
            {
                if (i == 0) { a = _arr[i]; continue; } //если это начало цикла, то положим первое число из массива в переменную "а"

                else if (i == 1)  //на втором проходе цикла, положим вторе число в переменную "b"
                {
                    b = _arr[i];
                    //проверим делится что-нибудь на 3
                    if (a % 3 == 0 || b / 3 == 0) { count++; }
                }
                else //В остальных циклах, переммну "b" кладем в переменную "а", а "b" присваиваем текущее число из массива
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
            return logPassStr.Split(' ', '\r', '\n', '=');

        }
        static bool LogIn(string[] logpass, string log, string pass)
        {
            //string log = "ich", _log = "";
            //string pass = "123", _pass = "";
            string _log = "", _pass = "";
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
    }
}
