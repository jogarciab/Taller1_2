using System.Diagnostics.Contracts;

namespace Taller1_2.Backend;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a) 
    {
        A = a;
        Name = name;
   }
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
private double ValidateA(double a)
    {
        if (a <= 0)
        {
               throw new ArgumentException("Side length must be greater than zero.");
        }
        return a;
    }

    public override double GetArea() => Math.Pow(A, 2);
    public override double GetPerimeter() => 4 * A;
}
