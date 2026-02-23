namespace Taller1_2.Backend;

public abstract class GeometricFigure
{
    public string Name { get; set; }
    public GeometricFigure(string name)
    {
        Name = name;
    }

    public abstract double GetArea();

    public abstract double GetPerimeter();

    override public string ToString()
    {
        return $"{Name, -15} => Area.....: {GetArea(), 15:N5}\tPerimeter: {GetPerimeter(), 15:N5}";
    }
}
