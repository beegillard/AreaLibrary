namespace Calculations;

public static class AreaLibrary
{
    public static double CircleArea(double rad) {
            double area = Math.PI * Math.Pow(rad, 2);
            return area;   
    }

    public static double TriangleArea (double length, double height) {
        double area = 0.5 * length * height;
        return area;
    }

     public static double RectangleArea (double length, double width) {
        double area = length * width;
        return area;
    }

    
}