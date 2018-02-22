namespace Level1_Lesson3_HW
{
    class Complex
    {
        double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.im + re;
            return x3;
        }

        public double lm
        {
            get { return im; }
            set { if (value > 0) im = value; }
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }

        //Домашнее задание. Задача №1
        //Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - im;
            x3.re = x2.im - re;
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex y3 = new Complex();
            y3.im = im * x2.im + re * x2.im;
            y3.re = re * x2.im - im * x2.re;
            return y3;
        }
    }
}
