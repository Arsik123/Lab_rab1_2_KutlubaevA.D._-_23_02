using System;
using System.Windows;
using System.Windows.Input;

namespace Lab_rab1_2_KutlubaevA.D._БПИ_23_02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnSquareArea_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtSquareSide.Text, out double side) && side > 0)
            {
                Square square = new Square(side);
                double area = square.CalculateArea();
                ResultSquare.Text = $"{square.GetInfo()}\nПлощадь: {area:F2}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение для стороны квадрата.");
            }
        }

        private void BtnSquarePerimeter_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtSquareSide.Text, out double side) && side > 0)
            {
                Square square = new Square(side);
                double perimeter = square.CalculatePerimeter();
                ResultSquare.Text = $"{square.GetInfo()}\nПериметр: {perimeter:F2}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение для стороны квадрата.");
            }
        }
        private void BtnEllipseArea_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtEllipseA.Text, out double rA) && rA > 0 &&
                double.TryParse(TxtEllipseB.Text, out double rB) && rB > 0)
            {
                Ellipse ellipse = new Ellipse(rA, rB);
                double area = ellipse.CalculateArea();
                ResultEllipse.Text = $"{ellipse.GetInfo(true)}\nПлощадь: {area:F2}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для полуосей эллипса.");
            }
        }

        private void BtnEllipsePerimeter_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtEllipseA.Text, out double rA) && rA > 0 &&
                double.TryParse(TxtEllipseB.Text, out double rB) && rB > 0)
            {
                Ellipse ellipse = new Ellipse(rA, rB);
                double perimeter = ellipse.CalculatePerimeter();
                ResultEllipse.Text = $"{ellipse.GetInfo(true)}\nПериметр (приближенно): {perimeter:F2}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для полуосей эллипса.");
            }
        }

        private void BtnTrapArea_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtTrapBaseA.Text, out double bA) && bA > 0 &&
                double.TryParse(TxtTrapBaseB.Text, out double bB) && bB > 0 &&
                double.TryParse(TxtTrapHeight.Text, out double h) && h > 0)
            {
                Trapezoid trapezoid = new Trapezoid(bA, bB, h);
                double area = trapezoid.CalculateArea();
                ResultTrap.Text = $"{trapezoid.GetInfo()}\nПлощадь: {area:F2}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для оснований и высоты трапеции.");
            }
        }

        private void BtnTrapPerimeter_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtTrapBaseA.Text, out double bA) && bA > 0 &&
                double.TryParse(TxtTrapBaseB.Text, out double bB) && bB > 0 &&
                double.TryParse(TxtTrapHeight.Text, out double h) && h > 0)
            {
                Trapezoid trapezoid = new Trapezoid(bA, bB, h);
                double perimeter = trapezoid.CalculatePerimeter();
                ResultTrap.Text = $"{trapezoid.GetInfo()}\nВычисленная боковая сторона: {trapezoid.Side:F2}\nПериметр: {perimeter:F2}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для оснований и высоты трапеции.");
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;

            if (textBox.Text.Length == 0 && e.Text == ",")
            {
                e.Handled = true;
                return;
            }

            if (e.Text == "," && textBox.Text.Contains(","))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.Text, 0) && e.Text != ",")
            {
                e.Handled = true;
            }
        }
    }
}