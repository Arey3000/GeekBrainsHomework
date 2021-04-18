namespace Complex
{
    //Класс для представления комплексного числа
    internal class ClassComplex
    {
        private double im;
        double re;
        public ClassComplex()
        {
            im = 0;
            re = 0;
        }
        public ClassComplex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }
        public ClassComplex Plus(ClassComplex x2)
        {
            ClassComplex x3 = new ClassComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public ClassComplex Minus(ClassComplex x2)
        {
            ClassComplex x3 = new ClassComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public ClassComplex Multi(ClassComplex x2)
        {
            ClassComplex x3 = new ClassComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
           }
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}