namespace Taller1_2.Backend;

public class Rectangle : Square
{
    private float _b;
    public Rectangle(string v, double v1, float b) : base(v, b)
    {
        B = b;
    }

    public float B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    private float ValidateB(float b)
    {
        if (b < 0)
        {
            throw new ArgumentException("Side B must be greater than zero.");
        }
        return b;
    }
    public override float GetArea() => A * B;
    public override float GetPerimeter() => 2 * (A + B);
}
