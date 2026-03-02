using System;

class Program
{
    static void Main()
    {
        // Exercise 1
        Console.WriteLine("Exercise 1:");
        Console.Write("Enter first number: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        if (a1 == b1)
            Console.WriteLine("The numbers are equal");
        else if (a1 > b1)
            Console.WriteLine("First number is greater");
        else
            Console.WriteLine("First number is less");

        Console.WriteLine();


        // Exercise 2
        Console.WriteLine("Exercise 2:");
        Console.Write("Enter number: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        if (n2 > 5 && n2 < 10)
            Console.WriteLine("The number is greater than 5 and less than 10");
        else
            Console.WriteLine("Unknown number");

        Console.WriteLine();


        // Exercise 3
        Console.WriteLine("Exercise 3:");
        Console.Write("Enter number: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        if (n3 == 5 || n3 == 10)
            Console.WriteLine("The number is either 5 or 10");
        else
            Console.WriteLine("Unknown number");

        Console.WriteLine();


        // Exercise 4
        Console.WriteLine("Exercise 4:");
        Console.Write("Enter deposit: ");
        double money = Convert.ToDouble(Console.ReadLine());
        double percent = 0;

        if (money < 100)
            percent = 0.05;
        else if (money <= 200)
            percent = 0.07;
        else
            percent = 0.10;

        double result = money + money * percent;
        Console.WriteLine("Total: " + result);

        Console.WriteLine();


        // Exercise 5
        Console.WriteLine("Exercise 5:");
        Console.Write("Enter deposit: ");
        money = Convert.ToDouble(Console.ReadLine());

        if (money < 100)
            percent = 0.05;
        else if (money <= 200)
            percent = 0.07;
        else
            percent = 0.10;

        result = money + money * percent + 15;
        Console.WriteLine("Total with bonus: " + result);

        Console.WriteLine();


        // Exercise 6
        Console.WriteLine("Exercise 6:");
        Console.WriteLine("1.Add  2.Subtract  3.Multiply");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Undefined operation");
                break;
        }

        Console.WriteLine();


        // Exercise 7
        Console.WriteLine("Exercise 7:");
        Console.WriteLine("1.Add  2.Subtract  3.Multiply");
        op = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double y = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Result: " + (x + y));
                break;
            case 2:
                Console.WriteLine("Result: " + (x - y));
                break;
            case 3:
                Console.WriteLine("Result: " + (x * y));
                break;
            default:
                Console.WriteLine("Undefined operation");
                break;
        }
    }
}