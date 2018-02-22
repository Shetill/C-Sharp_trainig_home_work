//Home work. Question 3
//3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
//Написать программу, демонстрирующую все разработанные элементы класса.

namespace Level1_Lesson3_HW
{
    class Fractions
    {
        public double x
        {
            get { return x; }
            set { if (x > 0) z = value; }
        }

        public double y
        {
            get { return y; }
            set { if (z > 0) z = value; }
        }

        public double z
        {
            get { return z; }
            set { if (z > 0) z = value; }
        }

        public Fractions(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public double Plus()
        {
            return x + y;
        }

        public double Minus()
        {
            return x - y;
        }

        public double Multi()
        {
            return x * y;
        }

        public double Div()
        {
            return y == 0 ? 0 : x / y;
        }
    }
}