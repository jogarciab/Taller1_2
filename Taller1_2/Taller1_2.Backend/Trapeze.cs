namespace Taller1_2.Backend;

public class Trapeze : Triangle
{
    private float _d;
    public Trapeze(string v, double v1, double v2, float c, float h, float d) : base(v, v1, v2, c, h)
    {
        D = d;
    }

    public float D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    private float ValidateD(float d)
    {
        if (d < 0)
        {
            throw new ArgumentException("Side D must be greater than zero.");
        }
        return d;
    }
    public override float GetArea() => (B * D) * H / 2;
    public override float GetPerimeter() => A + B + C + D;
}

