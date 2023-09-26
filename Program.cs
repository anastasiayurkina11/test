using System;
/// <summary>
/// Программа для вычисления объема пирамиды
/// </summary>
public class Pyramid 
{
    /// <summary>
    /// Константа из формулы объема пирамиды
    /// </summary>
    int formula_const = 3;

    #region private
    /// <summary>
    /// Длина для вычисления площади основания
    /// </summary>
    private double baseLength;
    /// <summary>
    /// Ширина для вычисления площади основания
    /// </summary>
    private double baseWidth;
    /// <summary>
    /// Высота пирамиды для вычисления объема
    /// </summary>
    private double height;
    #endregion

    public Pyramid(double baseLength, double baseWidth, double height)
    {
        
        this.baseLength = baseLength;
        
        this.baseWidth = baseWidth;
        
        this.height = height;
    }

    public double CalculateVolume()
    {
        if (baseLength <= 0 | baseWidth <= 0 | height <= 0) // нужно ли выносить эти нули?
        {
            throw new ArgumentException("Значения должны быть положительными числами.");
        }

        double baseArea = baseLength * baseWidth;
        double volume = (baseArea * height) / formula_const;

        return volume;
    }
}

public class Pyramid_calculation
{
    static void Calculate(int a, int b, int c)
    {
        try
        {
            Pyramid pyramid = new Pyramid(a, b, c);
            double volume = pyramid.CalculateVolume();
            Console.WriteLine($"Объем пирамиды: {volume}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
    static void Main(string[] args)
    {
        Calculate(3, 4, 5);
    }
}