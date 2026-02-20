namespace Taller1_2.Backend;

public class Rhombous : Square
{
    private float _d1;
    private float _d2;

    public Rhombous(float a, float d1, float d2) : base(a)
    {
        D1 = d1;
        D2 = d2;
    }

    public float D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }

    public float D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }

    private float ValidateD1(float d1)
    {
        if (d1 < 0)
        {
               throw new ArgumentException("Side 1 must be greater than zero.");
        }
        return d1;
    }

    private float ValidateD2(float d2)
    {
        if (d2 < 0)
        {
            throw new ArgumentException("Side 2 must be greater than zero.");
        }

        return d2;
    }

    public override float GetArea() => (D1 * D2) / 2;
    public override float GetPerimeter() => 4 * A; 
}
