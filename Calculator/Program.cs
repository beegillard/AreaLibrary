using System.Runtime.InteropServices;
using Calculations;
class Program
{
    static void Main(string[] args)
    {
        void GetInput() {
            Console.WriteLine("Enter 'c' for circle, 'r' for rectangle, or 't' for triangle.");
            string? input = Console.ReadLine();
        
            switch (input) {
                case "c": 
                    Console.WriteLine("enter radius:");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    if (double.IsNaN(radius)) {
                        throw new ArgumentException("Radius must be in the form of a number.");
                    } else if (radius < 0) {
                        throw new ArgumentException("Radius must be a positive number");
                    } else {
                        double area = AreaLibrary.CircleArea(radius);
                        Console.WriteLine($"Area of the circle is {area}");
                        }
                    
                    break;

                case "r":
                    Console.WriteLine("enter width");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter height");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double rarea = AreaLibrary.RectangleArea(width, height);
                    Console.WriteLine($"The area of the rectangle is {rarea}");
                    break;

                case "t":
                    Console.WriteLine("enter width");
                    double twidth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter height");
                    double theight = Convert.ToDouble(Console.ReadLine());
                    double tarea = AreaLibrary.TriangleArea(twidth, theight);
                    Console.WriteLine($"The area of the triangle is {tarea}");
                    break;
                default:
                    Console.WriteLine("Enter 'c', 't', or 'r'");
                    break;
            }


        }

        GetInput();


          

        

      
    

      
    }


      
}

