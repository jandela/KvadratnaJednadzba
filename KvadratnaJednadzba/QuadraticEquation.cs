using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednadzba
{
    public class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation()
        {

        }
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Y(double x)
        {
            return a * x * x + b * x + c;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double Discriminant
        {
            get { return (b * b - 4 * a * c); }
        }

        public double[] Roots
        {
            get
            {
                if (a == 0)
                {
                    return new double[] { -c / b, -c / b };
                }
                if (Discriminant < 0)
                {
                    throw new NotRealRootsException("The value of the determinant is less than zero.");
                }
                double sqrtD = Math.Sqrt(Discriminant);

                double[] result = new double[] { (-b + sqrtD) / 2 / a, (-b - sqrtD) / 2 / a };
                return result;
            }
        }

    }
}
