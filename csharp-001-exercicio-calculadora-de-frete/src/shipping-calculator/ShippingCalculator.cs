using System;
using System.Dynamic;

namespace ShippingCalculator;

public class ShippingCalculator
{
    /// <summary>
    /// This function evaluates the order price passed as an input parameter and returns the shipping price following the exercise's logic
    /// </summary>
    /// <param name="orderPrice"> A value of type double, the order price </param>
    /// <returns>The shipping price value (integer type), following the exercise logic </returns>
    /// <exception cref="ArgumentException">If the order price be equal to or less than zero</exception>

    // 1 - Calcular o Frete por preço do pedido na função `CalculateShippingPrice`
    public double calculateShippingPrice(double orderPrice)
    {
        double shippingPrice;

        switch (orderPrice)
        {
            case <= 50:
                shippingPrice = 25D;
                break;
            case > 50 and <= 100:
                shippingPrice = 20D;
                break;
            case > 100 and <= 200:
                shippingPrice = 15D;
                break;
            default:
                shippingPrice = 0D;
                break;
        }

        return shippingPrice;
    }

    // 2 - Calcular o Frete por peso na função `CalculateShippingWeight`
    public double calculateShippingWeight(double weight)
    {
        double shippingWeight;

        switch (weight)
        {
            case <= 1.5D:
                shippingWeight = 3.8D;
                break;
            case > 1.5D and <= 3.5D:
                shippingWeight = 5.7D;
                break;
            case > 3.5D and <= 7D:
                shippingWeight = 7.2D;
                break;
            case > 7D and <= 10D:
                shippingWeight = 9.4D;
                break;
            default:
                shippingWeight = weight * 1.9D;
                break;
        }

        return shippingWeight;
    }

    // 3 - Calcular o Frete final na função `CalculateShipping`
    public double calculateShipping(double orderPrice, double weight)
    {
        var valueShipping = calculateShippingPrice(orderPrice) + calculateShippingWeight(weight);

        if (valueShipping > 45)
        {
            var discount = valueShipping * 0.15;


            return valueShipping - discount;
        }

        return valueShipping;
    }

    // 4 - Calcular o Frete final para um array de preços e um array de pesos na função `CalculateShippingFromArray`
    public double calculateShippingFromArray(double[] itemPrices, double[] itemWeights)
    {
        double totalPrices = 0;
        double totalWeights = 0;

        foreach (double price in itemPrices)
        {
            totalPrices += price;
        }

        foreach (double weight in itemWeights)
        {
            totalWeights += weight;
        }

        return calculateShipping(totalPrices, totalWeights);
    }

}