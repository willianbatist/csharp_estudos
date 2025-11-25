namespace PaintShop;

// 1 - Crie uma classe Wall
public class Wall
{
    private double _width;
    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
            {
                _width = 1;
            }
            else
            {
                _width = value;
            }
        }
    }

    public double _height;
    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            {
                _height = 1;
            }
            else
            {
                _height = value;
            }
        }
    }
    private double _excludedArea;
    public double ExcludedArea
    {
        get { return _excludedArea; }
        set { _excludedArea = value; }
    }
    public double _paintableArea;
    public double PaintableArea
    {
        get
        {
            double totalArea = _width * _height;
            return totalArea - ExcludedArea;
        }
    }
    public Wall(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }
}