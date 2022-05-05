using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_V2
{
    internal class Circle
    {

        public const double PI_NEW = 97.4090910340024372;

        public double R { get; }
        public double D { get; }
        public double Circumference { get; }
        public double NewCircumference { get; }
        public Circle(double d)
        {
            D = d;
            R = d / 2;
            Circumference = 2 * Math.PI * R;
            NewCircumference = CalculateCircumference(PI_NEW * CalculateDiameter());     
        }

        public double CalculateDiameter()
        {
            double d = D;
            for (int i = 0; i < 2; i++)
            {
                d = Math.Pow(d,2);
                
            }
            return d;
        }

       
        public double CalculateCircumference(double num)
        {
            for (int i = 0; i < 2; i++)
            {
                num = Math.Sqrt(num);
            }
            return num;
        }
    }
}
