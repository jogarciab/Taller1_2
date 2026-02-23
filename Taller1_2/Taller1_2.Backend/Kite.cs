namespace Taller1_2.Backend;

public class Kite : Rhombous
{
    private float _b;
    public Kite(string v, float b, float d1, float d2, float a) : base(v, d1, d2, a)
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
    public override float GetArea() => (D1 * D2) / 2;
    public override float GetPerimeter() => 2 * (A + B);
}
