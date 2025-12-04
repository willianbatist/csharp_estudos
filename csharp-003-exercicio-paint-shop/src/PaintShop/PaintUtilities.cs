using System.ComponentModel;

namespace PaintShop;

// 3 - Crie uma classe estática PaintUtilities
public static class PaintUtilities
{
    public static int BucketSizeLiters { get; } = 20;

    public static int SquareMetersPerLiter { get; } = 10;

    public static int SquareMetersPerBucket
    {
        get { return SquareMetersPerLiter * BucketSizeLiters; }
    }

    public static int GetNeededPaintBuckets(double area) {
        double buckets = area / SquareMetersPerBucket;
        return (int)Math.Ceiling(buckets);
    }

    public static int GetNeededPaintBuckets(Wall wall) {
        return GetNeededPaintBuckets(wall.PaintableArea);
    }

    public static int GetNeededPaintBuckets(Room room) {
        return GetNeededPaintBuckets(room.TotalPaintableArea);
    }

    public static decimal CalculateCost(decimal price, double area) {
        int buckets = GetNeededPaintBuckets(area);
        return buckets * price;
    }

    public static decimal CalculateCost(decimal price, Wall wall) {
        int buckets = GetNeededPaintBuckets(wall.PaintableArea);
        return buckets * price;
    }

    public static decimal CalculateCost(decimal price, Room room) {
        int buckets = GetNeededPaintBuckets(room.TotalPaintableArea);
        return buckets * price;
    }
}