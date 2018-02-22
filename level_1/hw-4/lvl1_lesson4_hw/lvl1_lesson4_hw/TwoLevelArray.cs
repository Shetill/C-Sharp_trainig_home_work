using System;

namespace Level1_lesson4_HW
{
    internal class TwoLevelArray
    {
        int[,] arr;

        public int MaxEl
        {
            get
            {
                int max = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public int MinEl
        {
            get
            {
                int min = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                        }
                    }
                }
                return min;
            }
        }

        public TwoLevelArray()
        {

        }

        public TwoLevelArray(int n, int j) //конструктор заполняющий массив случайными числами
        {
            arr = new int[n, j];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii < j; ii++)
                {
                    this.arr[i, ii] = rnd.Next(10);
                }
            }
        }

        public int GetSumAllElements() //метод возвращает сумму всех элементов массива
        {
            int sum = 0;
            for (int i = 0; i < this.arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.arr.GetLength(0); j++)
                {
                    sum = sum + this.arr[i, j];
                }
            }
            return sum;
        }

        public int GetSumAllElementsMoreMax(int max) //метод возвращает сумму всех элементов массива больше заданного
        {
            int sum = 0;
            for (int i = 0; i < this.arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.arr.GetLength(0); j++)
                {
                    if (this.arr[i, j] > max)
                    {
                        sum = sum + this.arr[i, j];
                    }
                }
            }
            return sum;
        }

        public void GetIndexMaxElemenet(out string index) //метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
        {
            int max = 0, l = 0, m = 0;
            for (int i = 0; i < this.arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.arr.GetLength(0); j++)
                {
                    if (this.arr[i, j] > max)
                    {
                        max = this.arr[i, j];
                        l = i;
                        m = j;
                    }
                }
            }
            index = l + ", " + m;
        }

    }
}