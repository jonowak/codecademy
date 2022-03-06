//
// Lab 1 Inheritance 07 March 2013
//
// Create one source for each of the three classes
// compile: csc Point.cs Circle.cs Cylinder.cs CylinderTester.cs
//
// (1) Create base class Point: <filename: Point.cs>
//     has 2 co-ordinates
//     create properties to access those co-ordinates
//
// (2) Create class Circle which derives from class Point <filename: Circle.cs>
//     needs to keep state of radius
//     use properties to access that radius
//     Diameter is 2 * radius
//     Circumference is PI * diameter
//     Area of a circle is PI R squared
//
// (3) Create class Cylinder which derives from class Circle <filename: Cylinder.cs>
//     needs to keep state of height
//     use properties to access that height
//     Area is 2 * area of circle + circumference * height
//     Volume is height * area of circle
//
// NOTE: Override the appropriate methods, hint:
//     ToString():
//        Point:    return "[x,y]" where x and y are co-ordinates
//        Circle:   return "Center = [x,y]; Radius = r" where r is radius
//        Cylinder: return "Center = [x,y]; Radius = r; Height = h" where h is height
//
// Inheritance 
// tester for Cylinder class

#region (No changes needed in this file)
// no changes needed here 
// *unless*, you choose to implement Area, Circumference, Diameter and Volume
// as properties instead of methods
// then you would invoke it as c.Area instead of c.Area() etc...
using System;
using System.Windows.Forms;
using System.Text;
namespace Cylinder
{
    // CylinderTest class definition
    class CylinderTester
    {
        static void GetInfo(Cylinder c, StringBuilder s)
        {
            s.Append(String.Format("X co-ordinate is {0}\n", c.X));
            s.Append(String.Format("Y co-ordinate is {0}\n", c.Y));
            s.Append(String.Format("Radius is {0}\n", c.Radius));
            s.Append(String.Format("Height is {0}\n", c.Height));
            s.Append(String.Format("\nCo-ordinates are {0}\n", c));
            s.Append(String.Format("Area is {0:f2}\n", c.Area()));
            s.Append(String.Format("Circumference is {0:f2}\n", c.Circumference()));
            s.Append(String.Format("Diameter is {0}\n", c.Diameter()));
            s.Append(String.Format("Volume is {0:f2}\n", c.Volume()));
            s.Append("\n\t------------------------------\n\n");
        }

        static void Main()
        {
            Cylinder cylinder = new Cylinder(2, 2, 4.5, 10);
            StringBuilder output = new StringBuilder("Original Cylinder: \n");

            GetInfo(cylinder, output);

            // reset variables
            output.Append("Changed cylinder: \n");
            cylinder.X = 4;
            cylinder.Y = 4;
            cylinder.Radius = 9;
            cylinder.Height = 20;

            GetInfo(cylinder, output);
           // MessageBox.Show(output.ToString(), "Testing Class Cylinder");
        } // end Main
    } // end class CylinderTester
#endregion
}