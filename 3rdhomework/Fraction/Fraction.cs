using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
   
    class Fraction
    {
        int nom;
        int denom;

       
        public int Denominator
        {
            get { return denom; }
            set
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                else
                    denom = value;
            }
        }

        public Fraction()
        {
            nom = 1;
            denom = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.nom = numerator;
            this.Denominator = denominator;
        }

        public Fraction Plus(Fraction x)
        {
            Fraction y = new Fraction();
            y.denom = Fraction.noz(x.denom, this.denom);
            y.nom = (x.nom * (y.denom / x.denom)) + (this.nom * (y.denom / this.denom));
            return y;
        }

        public Fraction Minus(Fraction x)
        {
            Fraction y = new Fraction();
            y.denom = Fraction.noz(x.denom, this.denom);
            y.nom = (this.nom * (y.denom / this.denom)) - (x.nom * (y.denom / x.denom));
            return y;
        }

        public Fraction Multi(Fraction x)
        {
            Fraction y = new Fraction();
            y.nom = x.nom * nom;
            y.denom = x.denom * denom;
            return y;
        }

        public Fraction Division(Fraction x)
        {
            Fraction y = new Fraction();
            y.nom = x.denom * nom;
            y.denom = x.nom * denom;
            return y;
        }
        public string ToString()
        {
            return "(" + nom + "/" + denom + ")";
        }     
        static int nod(int a, int b)
        {
            while (a != b) { 
            if (a == 0)
                break;
            if (a > b) a = a - b; else b = b - a;
        }
            return a;
        }

        static int noz(int a, int b)
        {
            int noz;
            int newnoz;
            int multiplier = 2;
            if (a > b)
            {
                noz = a;
                if (noz % b == 0)
                    return noz;
            }
            else
            {
                noz = b;
                if (noz % a == 0)
                    return noz;
            }
            while (true)
            {
                newnoz = noz * multiplier;
                if (newnoz % a == 0 && newnoz % b == 0)
                    return newnoz;
                multiplier++;
            }
        }

        //упрощения дроби
        public void Simplification()
        {
            int num = this.nom;
            int denom = this.denom;
            int nod = Fraction.nod(Math.Abs(num), Math.Abs(denom));
            while (nod != 1 && nod != 0)
            {
                this.nom = num / nod;
                this.denom = denom / nod;
                num = this.nom;
                denom = this.denom;
                nod = Fraction.nod(Math.Abs(num), Math.Abs(denom));
            }
        }
    }
}
