using System.Net;
using Calculations;
class Program
{
    static void Main(string[] args)
    {
        void GetShape() {
            Console.WriteLine("Enter 'c' for circle, 'r' for rectangle, or 't' for triangle.");
            string? input = Console.ReadLine();
            string shape = "";
            string? value1 = "";
            string? value2 = "";
        
            switch (input) {
                case "c": 
                    shape = "circle";
                    Console.WriteLine("enter radius:");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double area = AreaLibrary.CircleArea(radius);
                    Console.WriteLine($"Area of the circle is {area}");
                    break;

                case "r":
                    shape = "rectangle";
                    Console.WriteLine("enter width");
                    //value1 = Console.ReadLine();
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter height");
                    //value2 = Console.ReadLine();
                    double height = Convert.ToDouble(Console.ReadLine());
                    double rarea = AreaLibrary.RectangleArea(width, height);
                    Console.WriteLine($"The area of the rectangle is {rarea}");
                    break;

                case "t":
                    shape = "triangle";
                    Console.WriteLine("enter width");
                    //value1 = Console.ReadLine();
                    double twidth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter height");
                    //value2 = Console.ReadLine();
                    double theight = Convert.ToDouble(Console.ReadLine());
                    double tarea = AreaLibrary.TriangleArea(twidth, theight);
                    Console.WriteLine($"The area of the triangle is {tarea}");
                    break;
                default:
                    Console.WriteLine("Enter 'c', 't', or 'r'");
                    break;
            }
           


        }

        /* void CheckInput(string v1, string? v2) {
            double converted = Convert.ToDouble(v1);
            double converted2 = Convert.ToDouble(v2);

            if (converted < 0 || converted2 < 0) {
                throw new ArgumentException("Radius must be a positive number");
            } else {
                //;
            }
            }

        } */

        GetShape();



          

        

      
    

      
    }


      
}

