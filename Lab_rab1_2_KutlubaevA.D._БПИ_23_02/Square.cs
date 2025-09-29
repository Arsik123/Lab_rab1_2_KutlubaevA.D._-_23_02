using System;

namespace Lab_rab1_2_KutlubaevA.D._БПИ_23_02
{
    public class Square : GeometricFigure
    {
        public double Side { get; set; }

        public Square(double side) : base("Квадрат")
        {
            Side = side;
        }

        public override double CalculateArea() => Side * Side;

        public override double CalculatePerimeter() => 4 * Side;
    }
}