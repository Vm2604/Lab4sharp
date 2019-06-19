using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sharp
{
    class Prisma : Rectangle
    {
        public double height_of_Prism;

       
        private double widthBase;

        public double Height_of_Prism
        {
            get => height_of_Prism; set => height_of_Prism = value;
        }
      
        public double WidthBase { get => widthBase; set => widthBase = value; }

        public Prisma()
        {
        }
        public Prisma(double height_of_parallelepiped, double width)
        {
            base.Width = width;
            Height_of_Prism = height_of_parallelepiped;
        }
        public Prisma(double height_of_parallelepiped, double width, double height)
        {
           
            base.Width = width;
            Height_of_Prism = height_of_parallelepiped;
        }

     

        public override double Get_Square()
        {
            return height_of_Prism * WidthBase;
        }

        new public string ToString()
        {
            return "\nHeight of prism - " + Height_of_Prism +
                "\nVolume of prism - " + Get_Square();
        }
    }
}
