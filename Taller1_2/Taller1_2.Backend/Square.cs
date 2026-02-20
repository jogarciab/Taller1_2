using System.Diagnostics.Contracts;

namespace Taller1_2.Backend;

public class Square : GeometricFigure
{
    private float _a;

    public Square(float a)
    {
        A = a;
    }

    public float A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
private float ValidateA(float a)
    {
        if (a <= 0)
        {
               throw new ArgumentException("Side length must be greater than zero.");
        }
        return a;
    }

    public override float GetArea() => (float) Math.Pow(A, 2);
    public override float GetPerimeter() => 4 * A;
}
