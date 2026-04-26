using System;

class Temperature
{
    private double _celsius;

    public double Celsius
    {
        get => _celsius;
        set
        {
            if (value < -273.15)
                throw new ArgumentException("Temperature cannot be below absolute zero.");

            _celsius = value;
        }
    }

    public double Fahrenheit
    {
        get => _celsius * 9 / 5 + 32;
        set
        {
            Celsius = (value - 32) * 5 / 9;
        }
    }

    public Temperature(double celsius)
    {
        Celsius = celsius;
    }

    public void Print()
    {
        Console.WriteLine($"{Celsius}°C / {Fahrenheit}°F");
    }
}

class Program
{
    static void Main()
    {
        var temp = new Temperature(25);
        temp.Print();

        temp.Fahrenheit = 100;
        temp.Print();

        try
        {
            temp.Celsius = -300;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
