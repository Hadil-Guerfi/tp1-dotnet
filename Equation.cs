using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Equation
    {
        private double a;
        private double b;
        private double c;
        private double delta;
        private double r1;
        private double r2;
        public Equation() { }
        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void calculRacines()
        {
            if (a != 0)
            {
                this.delta = b * b - 4 * a * c;
                if (delta >= 0)
                {
                    this.r1 = (-b - Math.Pow(delta, 0.5)) / (2 * a);
                    this.r2 = (-b + Math.Pow(delta, 0.5)) / (2 * a);
                }
                else
                {
                    this.r1 = Double.NaN;
                    this.r2 = Double.NaN;
                }
            }
            else
            {
                if (b != 0)
                {
                    r1 = -c / b; r2 = -c / b;
                }
                else
                {
                    if (c != 0)
                    {
                        this.r1 = Double.NaN; this.r2 = Double.NaN;
                    }
                    else
                    {
                        r1 = Double.PositiveInfinity; r2 = Double.PositiveInfinity;
                    }
                }
            }
        }
        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getC()
        {
            return c;
        }
        public double getDelta()
        {
            return delta;
        }
        public double getR1()
        {
            return r1;
        }
        public double getR2()
        {
            return r2;
        }
        public void setA(double a)
        {
            this.a=a;
        }
        public void setB(double b)
        {
            this.b = b;
        }
        public void setC(double c)
        {
            this.c = c;
        }
        public override string ToString()
        {
            string ch = "Equation " + a + "*x^2+" + b + "*x+" + c+"=0.Racines ";
            if (r1.Equals(Double.PositiveInfinity))
            {
                return ch + "toujours vrai";
            }
            if (r1.Equals(Double.NaN))
            {
                return ch + "aucun";
            }
            if (r1.Equals(r2))
            {
                return ch + r1;
            }
            return ch + r1 + " et " + r2;
        }
    }
}
