using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Shape.Side_Shape;
namespace Shape.Shape
{
    public class Shape_M_M
    { 
        public class squer : Sides_Shape
        {
            public double Length;
            public override double Getperimater()
            {
                return Length * Length;
            }

            public override double GetArea()
            {

                return Length * 4;
            }
        }
        public class Rectangle : Sides_Shape
        {
            public double Length;
            public double Width;
      
            public override double Getperimater()
            {

                return Length * Width;
            }

            public override double GetArea()
            {
                return 2 * (Length + Width);
            }
        }
       public class triangle : Sides_Shape

        {
            public double Side;
            public double Base;
            public double Height;
            public override double Getperimater()
            {
                return (Base * Height) / 2;
            }

            public override double GetArea()
            {
                return Height + Base + Side;
            }
        }
        public class Circle :Sides_Shape
        {
            public  double Radius=3;
            public double P =3.14;
            public override double Getperimater()
            {
                return P*Radius*Radius ;
            }

            public override double GetArea()
            {
                return 2 * P * Radius;
            }
        }
    }
}
