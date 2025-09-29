using System;

namespace Lab_rab1_2_KutlubaevA.D._БПИ_23_02
{
    public class Ellipse : GeometricFigure
    {
        public double RadiusA { get; set; }
        public double RadiusB { get; set; }

        public Ellipse(double radiusA, double radiusB) : base("Эллипс")
        {
            RadiusA = radiusA;
            RadiusB = radiusB;
        }

        public override double CalculateArea() => Math.PI * RadiusA * RadiusB;

        public override double CalculatePerimeter()
        {
            double a = RadiusA;
            double b = RadiusB;
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
        public string GetInfo(bool includeRadii)
        {
            if (includeRadii)
                return base.GetInfo() + $", Полуоси: {RadiusA}, {RadiusB}";
            else
                return base.GetInfo();
        }
    }
}