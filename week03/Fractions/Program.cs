using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"No argument constructor returns: {fraction1.GetFractionString()} or {fraction1.GetFractionDecimal()}");
        Console.WriteLine($"The top number is {fraction1.GetTop()} and the bottom number is {fraction1.GetBottom()}");

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"One argument constructor returns: {fraction2.GetFractionString()} or {fraction2.GetFractionDecimal()}");
        Console.WriteLine($"The top number is {fraction2.GetTop()} and the bottom number is {fraction2.GetBottom()}");

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"Two argument constructor returns: {fraction3.GetFractionString()} or {fraction3.GetFractionDecimal()}");
        Console.WriteLine($"The top number is {fraction3.GetTop()} and the bottom number is {fraction3.GetBottom()}");
    }
}