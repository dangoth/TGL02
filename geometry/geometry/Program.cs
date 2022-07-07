using System;
interface Shape
{
    public double CalculateArea();
}

class Square : Shape
{
    private double x { get; set; }

    public double CalculateArea() => x* x;
}

class Rectangle : Shape
{
    private double width { get; set; }
    private double height { get; set; }

    public double CalculateArea() => width * height;
}

class Triangle : Shape
{
    private double width { get; set; }
    private double height { get; set; }

    public double CalculateArea() => 0.5 * width * height;

}

class Circle : Shape
{
    private double radius { get; set; }

    public double CalculateArea() => Math.PI * (radius * radius);
}