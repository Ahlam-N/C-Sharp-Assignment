// See https://aka.ms/new-console-template for more information
public interface  shape
{
    public double getArea();
  public double getPerimeter();
   
}
class circle: shape
{
    static double PI = 3.14;
    int _radius;
    public int radius
    {
        get => _radius;
        set => _radius = value;
    }
    //public int MyProperty { get; set; }
    public double getArea()
    {
        return PI * (radius * radius);

    }
    public double getPerimeter()
    {
        return 2 * PI * radius
            ;
    }
   
}
class square:shape
{
    int _length;
    int _width;
    public int length

    {
        get { return _length; }
        set { _length = value; }
    } 

public int width
    {
        get { return _width; }
        set { _width = value; }
    }
    public double getArea()
    {
        return width*length;

    }
   

}
    class triangle
    {
        int _base;
        int _height;
    public int base1{
        get => _base;
        set => _base = value;
        }
    public int height
    {
        get => _height; 
            set => _height = value;
    }


    }

