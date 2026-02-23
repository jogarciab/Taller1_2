namespace Taller1_2.Backend;

public class Triangle : Rectangle
{
    private float _c;
    private float _h;

    public Triangle(string v, double v1, double v2, float c, float h) : base(v, c, h)
    {
        C = c;
        H = h;
    }

    public float C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public float H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    private float ValidateC(float c)
    {
        if (c < 0)
        {
            throw new ArgumentException("Side C must be greater than zero.");
        }
        return c;
    }

    private float ValidateH(float h)
    {
        if (h < 0)
        {
            throw new ArgumentException("Height must be greater than zero.");
        }
        return h;
    }
    public override float GetArea() => (B * H) / 2;
    public override float GetPerimeter() => A + B + C;
}

