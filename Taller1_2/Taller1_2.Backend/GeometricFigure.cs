namespace Taller1_2.Backend;

public abstract class GeometricFigure
{
    public string Name
    {
        get;
        set;
    }

    public abstract float GetArea();

    public abstract float GetPerimeter();

    override public string ToString()
    {
        return $"{Name} => Area.....: {GetArea()}\t Perimeter: {GetPerimeter()}";
    }
}
