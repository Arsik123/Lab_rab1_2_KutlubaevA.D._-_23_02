namespace Lab_rab1_2_KutlubaevA.D._БПИ_23_02
{
    public class Trapezoid : GeometricFigure
    {
        public double BaseA { get; set; }
        public double BaseB { get; set; }
        public double Height { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public Trapezoid(double baseA, double baseB, double height, double sideC, double sideD) : base("Трапеция")
        {
            BaseA = baseA;
            BaseB = baseB;
            Height = height;
            SideC = sideC;
            SideD = sideD;
        }

        public override double CalculateArea() => ((BaseA + BaseB) / 2) * Height;

        public override double CalculatePerimeter() => BaseA + BaseB + SideC + SideD;

        public override string GetInfo()
        {
            return base.GetInfo() + $", Основания: {BaseA} и {BaseB}, Высота: {Height}";
        }
    }
}