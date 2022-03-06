using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// (2) Create class Circle which derives from class Point <filename: Circle.cs>
//     needs to keep state of radius
//     use properties to access that radius
//     Diameter is 2 * radius
//     Circumference is PI * diameter
//     Area of a circle is PI R squared

namespace Cylinder
{

    class Circle : Point 
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

            
       
        public Circle(int x, int y, double r) 
            :base(x, y)
        {
            Radius = r;
        }

        public double Diameter() 
        {
            return this.Radius * 2;
        }
        
        public double Circumference()
        {
            return this.Diameter() * Math.PI;
        }
        public virtual double Area() 
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
