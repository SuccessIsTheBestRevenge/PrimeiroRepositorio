
using System;

    public class Calculadora
{
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }

    public Calculadora(double numero1, double numero2)
    {
        Numero1 = numero1;
        Numero2 = numero2;
    }
    public double Somar()
    {
        return Numero1 + Numero2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o Primeiro Número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Calculadora calc = new Calculadora(num1, num2);

        Console.WriteLine($"\nResultado da soma: {calc.Somar()}");

    }
}