// Static Class Members & Instance Class Members
namespace selfStudy;

class Program20
{
    static void Main1()
    {
        System.Console.WriteLine("Main started\n");

        Circle c1 = new Circle(10);
        float area1 = c1.CalculateArea();
        System.Console.WriteLine("Area1 for circle is {0}\n", area1);

        Circle c2 = new Circle(6);
        float area2 = c2.CalculateArea();
        System.Console.WriteLine("Area2 for circle is {0}\n", area2);

        System.Console.WriteLine("Main ended");
    }
}

class Circle
{
    static float _PI;
    int _Radius;

    // Static constructor: runs only once per class, before any instance is created
    static Circle()
    {
        System.Console.WriteLine("Static constructor called - _PI initialized\n");
        _PI = 3.141F;
    }

    // Instance constructor: runs each time a new object is created
    public Circle(int radius)
    {
        System.Console.WriteLine("Instance constructor called - Radius set to " + radius);
        this._Radius = radius;
    }

    public float CalculateArea()
    {
        return this._Radius * _PI * this._Radius;
    }
}
