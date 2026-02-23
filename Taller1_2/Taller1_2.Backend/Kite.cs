namespace Taller1_2.Backend;

public class Kite : Rhombous
{
    private double _b;
    public Kite(string name, double b, double d1, double d2, double a) : base(name, d1, d2, a)
    {
        B = b;
    }
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    private double ValidateB(double b)
    {
        if (b < 0)
        {
            throw new ArgumentException("Side B must be greater than zero.");
        }
        return b;
    }
    public override double GetArea() => ((D1 * D2) / 2);
    public override double GetPerimeter() => (2 * (A + B));
}
