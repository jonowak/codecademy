using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// (3) Create class Cylinder which derives from class Circle <filename: Cylinder.cs>
//     needs to keep state of height
//     use properties to access that height
//     Area is 2 * area of circle + circumference * height
//     Volume is height * area of circle
namespace Cylinder
{
    class Cylinder:Circle
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public Cylinder(int x, int y, double r, int h) 
            :base(x, y, r)
        {
            Height = h;
        }

        public override double Area() 
        {
            return 2 * this.Area() + this.Circumference() * Height;
        }
        public double Volume() 
        { 
            return this.Area() * Height;
        }
    }
}
