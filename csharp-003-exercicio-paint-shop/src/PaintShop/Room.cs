namespace PaintShop;

// 2 - Crie uma classe Room
public class Room
{
    private double _totalPaintableArea;
    public double TotalPaintableArea
    {
        get
        {
            for (int i = 0; i < walls.Length; i++)
            {
                _totalPaintableArea += walls[i].PaintableArea;
            }

            return _totalPaintableArea;
        }
    }
    private Wall[] _walls;
    public Wall[] walls
    {
        get { return _walls; }
    }

    public Room(params Wall[] walls)
    {
        _walls = walls;
    }
}