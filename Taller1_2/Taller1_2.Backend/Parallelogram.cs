namespace Taller1_2.Backend;

public class Parallelogram : Rectangle
{
    private double _h;
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new ArgumentException("Height must be greater than zero.");
        }
        return h;
    }
    public override double GetArea() => (B * H);
    public override double GetPerimeter() => (2 * (A + B));
}
