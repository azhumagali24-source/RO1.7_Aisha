//task2

using System;

class BankAccount
{
    public string Owner { get; }

    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialDeposit)
    {
        if (initialDeposit < 0)
            throw new ArgumentException("Initial deposit cannot be negative.");

        Owner = owner;
        Balance = initialDeposit;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds");

        Balance -= amount;
    }

    public void PrintStatement()
    {
        Console.WriteLine($"Owner: {Owner}, Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        var acc = new BankAccount("Alice", 100m);

        acc.Deposit(50m);
        acc.Withdraw(30m);

        acc.PrintStatement();

        try
        {
            acc.Withdraw(1000m);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


//task3
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