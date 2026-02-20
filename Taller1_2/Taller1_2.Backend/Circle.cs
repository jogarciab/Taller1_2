namespace Taller1_2.Backend;

public class Circle : GeometricFigure
{
    private float _r;

    public Circle(string v, float r)
    {
        R = r;
    }

    public float R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }

    public override float GetArea() => (float) Math.PI * (float) Math.Pow(R, 2);

    public override float GetPerimeter() => 2 * (float) Math.PI * R;

    private float ValidateR(float r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("Radius must be greater than zero.");
        }
        return r;
    }
}
