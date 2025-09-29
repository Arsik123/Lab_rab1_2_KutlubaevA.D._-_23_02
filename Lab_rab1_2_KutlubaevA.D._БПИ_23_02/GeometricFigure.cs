using System;

namespace Lab_rab1_2_KutlubaevA.D._БПИ_23_02
{
    public abstract class GeometricFigure : IShape
    {
        public string ShapeName { get; protected set; }
        protected GeometricFigure(string name)
        {
            ShapeName = name;
            Console.WriteLine($"Конструктор базового класса GeometricFigure вызван для фигуры '{name}'.");
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public virtual string GetInfo()
        {
            return $"Фигура: {ShapeName}";
        }
    }
}