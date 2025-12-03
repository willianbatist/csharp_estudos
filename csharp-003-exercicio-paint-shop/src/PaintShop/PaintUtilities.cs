using System.ComponentModel;

namespace PaintShop;

// 3 - Crie uma classe estática PaintUtilities
public static class PaintUtilities
{
    private static int _squareMetersPerBucket;
    public static int SquareMetersPerBucket
    {
        get { return _squareMetersPerBucket = SquareMetersPerLiter * BucketSizeLiters; }
    }

    public static int BucketSizeLiters = 20;

    public static int SquareMetersPerLiter = 10;

    public static int GetNeededPaintBuckets(double area) {
        double neededBuckets = area * SquareMetersPerBucket;
        double remainder = neededBuckets / BucketSizeLiters;

        return (int)Math.Ceiling(remainder);
    }

    public static int GetNeededPaintBuckets(Wall wall) {
        throw new NotImplementedException();
    }

    public static int GetNeededPaintBuckets(Room room) {
        throw new NotImplementedException();
    }

    public static decimal CalculateCost(decimal price, double area) {
        throw new NotImplementedException();
    }

    public static decimal CalculateCost(decimal price, Wall wall) {
        throw new NotImplementedException();
    }

    public static decimal CalculateCost(decimal price, Room room) {
        throw new NotImplementedException();
    }
}