using System;

namespace Task2;

public class Circle
{
    private double _radius;

    private double _pi = 3.14;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public Circle()
    {
        _radius = 0.0;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return _pi * _radius * _radius;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public double GetCircumference()
    {
        return 2 * _pi * _radius;
    }
}
