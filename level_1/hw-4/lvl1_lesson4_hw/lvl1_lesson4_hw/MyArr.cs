using System;
using System.IO;
using System.Linq;

namespace Level1_lesson4_HW
{
    //Home work. Question 2
    //Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив заданной размерности
    //и заполняющий массив числами от начального значения с заданным шагом.
    class MyArr
    {
        int[] arr;

        public MyArr()
        {

        }
        public MyArr(int size)
        {
            arr = new int[size];
        }
        //Создадим индексируемое свойство
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        //Создадим свойство MaxCount, возвращающее количество максимальных элементов.
        public int MaxCount
        {
            get
            {
                int max = 0, count = 0;

                foreach (int a in arr)
                {
                    if(max < a)//if (max < a && max != a)
                    {
                        max = a;
                    }
                    else
                    {
                        count++;
                    }
                }
                return count;
            }
            set { MaxCount = value; }
        }
        //Создадим свойство Sum, которые возвращают сумму элементов массива
        public int Sum
        {
            get
            {

                return arr.Sum();
            }
            set
            {
                this.Sum = value;
            }
        }
        
        //Создадим метод Inverse меняющий знаки у всех элементов массива
        public void Inverse()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -arr[i];
            }
        }
        
        //Создадим метод Multi, умножающий каждый элемент массива на определенное число
        public void Multi(int m)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * m;
            }
        }

        //Создадим метод записи массива в файл
        public void SaveArrInFile(string filename)
        {
            string arrstr = "";
            foreach (var item in this.arr)
            {
                arrstr = arrstr + " " + item;
            }

            File.WriteAllText(filename, arrstr);
        }

        //Создадим конструктор загрузки  массива из файла
        public MyArr(string filename)
        {
            //StreamReader str = new StreamReader(filename);
            try
            {

            }
            catch
            {

            }

            StreamReader str = new StreamReader(filename);
            string line = str.ReadLine();
            //            string[] arrstr = line.Split(' ');
            //arr = Array.ConvertAll(Regex.Split(line, @"\s+"), int.Parse);
            arr = Array.ConvertAll(line.Split(' '), int.Parse);
            int i = 0;
            foreach (var item in arr)
            {
                Console.WriteLine("Элемент с индексом {0} = {1}", i, item);
                i++;
            }
            str.Close();

        }

        //конструктор массива с созданием массива заданной размерности (_lenght), и заполняемого числами от начального значения (_start) с опр. шагом(_step)
        public MyArr(int _lenght, int _start, int _step)
        {
            arr = new int[_lenght];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0) { arr[i] = _start; }
                else { arr[i] = arr[i - 1] + _step; };
            }

        }
    }
}
