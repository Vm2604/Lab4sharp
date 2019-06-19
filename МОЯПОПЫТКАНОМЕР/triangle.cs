using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Rectangle
{
    public double width;



    public double Width { get => width; set => width = value >= 0 ? value : 0; }

    public Rectangle()
    {
    }

    public Rectangle(double width)
    {
        Width = width;
    }
    public Rectangle(double width, double height)
    {

        Width = width;
    }

    public virtual double Get_Square()
    {
        double square = (width * width * Math.Sqrt(3)) / 4;
        return square;
    }

    public double Get_Perimeter()
    {
        double perimeter = 3 * width;
        return perimeter;
    }



    public override string ToString()
    {
        return $"Your width {Width}, your perimeter {Get_Perimeter()}, your square {Get_Square()}";
    }

}

