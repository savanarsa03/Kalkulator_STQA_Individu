using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return (double)a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Contoh penggunaan fungsi-fungsi perhitungan
        int num1 = 10;
        int num2 = 5;

        Console.WriteLine($"Addition: {num1} + {num2} = {calculator.Add(num1, num2)}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {calculator.Subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {calculator.Multiply(num1, num2)}");
        Console.WriteLine($"Division: {num1} / {num2} = {calculator.Divide(num1, num2)}");

        Console.ReadLine();
    }
}
