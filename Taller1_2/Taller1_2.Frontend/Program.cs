using Taller1_2.Backend;

var circle = new Circle(nameof(Circle), 5);
var figures = new List<GeometricFigure>() { circle };
foreach (var figure in figures)
{
       Console.WriteLine(figure);
}