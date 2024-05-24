using System;

public class HelloWorld 
{
    public static void Main(string[] args)
    {
        float vat = 7.7f;
        float productA = 3.92f;
        float productB = 6.92f;
        float productC = 12.92f;

        float summed = productA + productB + productC;
        float totalTax = (summed / 100) * vat;

        summed += totalTax;

        Console.WriteLine(summed);
    }
}