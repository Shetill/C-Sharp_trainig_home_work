using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1_Lesson3_HW
{
    struct ComplexStruct
    {
        public double im;
        public double re;

        // в C# в структурах могут храниться так же действия над данными
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        // Пример произведения двух комплексных чисел
        ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im * x.im + re * x.im;
            y.re = re * x.im - im * x.re;
            return y;
        }

        //Домашние задание. Задача №1
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;

        public ComplexStruct Minus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }

}
