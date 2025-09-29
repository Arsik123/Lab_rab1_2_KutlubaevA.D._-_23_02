using System;

namespace Lab_rab1_2_KutlubaevA.D._БПИ_23_02
{
    public class Trapezoid : GeometricFigure
    {
        public double BaseA { get; set; }
        public double BaseB { get; set; }
        public double Height { get; set; }
        public double Side
        {
            get
            {
                double baseDifference = Math.Abs(BaseA - BaseB) / 2.0;
                return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(baseDifference, 2));
            }
        }

        public Trapezoid(double baseA, double baseB, double height) : base("Трапеция")
        {
            BaseA = baseA;
            BaseB = baseB;
            Height = height;
        }
        public override double CalculateArea() => ((BaseA + BaseB) / 2) * Height;
        public override double CalculatePerimeter() => BaseA + BaseB + (2 * Side);
        public override string GetInfo()
        {
            return base.GetInfo() + $", Основания: {BaseA} и {BaseB}, Высота: {Height}";
        }
    }
}