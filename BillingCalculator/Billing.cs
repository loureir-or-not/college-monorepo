// See https://aka.ms/new-console-template for more information
namespace BillingCalculator;

public static class Calculator {
    public static double CalculateTax(double subtotal, double rate = 0.20)
    {
        return subtotal * rate;
    }

    public static double CalculateTotal(double subtotal, double tax)
    {
        return subtotal + tax;
    }
}
