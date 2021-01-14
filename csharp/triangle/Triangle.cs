using System;
using Xunit;
using System.Linq;

public static class Triangle
{
    public static bool IsScalene(double a, double b, double c)
    {
        return isTriangle(a, b, c) && !IsIsosceles(a, b, c) && isTriangle(a, b, c);
    }

    public static bool IsIsosceles(double a, double b, double c)
    {
        double[] arr = { a, b, c };

        var iso = arr.GroupBy(n => n).Max(s => s.Count()) > 1;

        return isTriangle(a, b, c) && iso;
    }

    public static bool IsEquilateral(double a, double b, double c)
    {
        return isTriangle(a, b, c) && (a == b && b == c);
    }

    public static bool isTriangle(double a, double b, double c)
    {
        return (a + b + c) != 0 && (double)(a + b) >= c && (double)(a + c) >= b && (double)(b + c) >= a;
    }
}