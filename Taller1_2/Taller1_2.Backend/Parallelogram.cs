namespace Taller1_2.Backend;

public class Parallelogram : Rectangle
{
    private float _h;
    public Parallelogram(string v, double v1, double v2, float h) : base(v, v1, h)
    {
        H = h;
    }
    public float H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    private float ValidateH(float h)
    {
        if (h < 0)
        {
            throw new ArgumentException("Height must be greater than zero.");
        }
        return h;
    }
    public override float GetArea() => B * H;
    public override float GetPerimeter() => 2 * (A + B);
}
