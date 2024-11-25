using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main()
    {
        //x = y^2 + 2y + 1
        for (int i = -5; i <= 5; i++)
        {
            Console.WriteLine($"y = {i}, x = {i * i + 2 * i + 1}");
        }

        //input distance, hours, minute, seconds => km/h & miles/h
        Console.Write("Please input distance (km): ");
        float dis = float.Parse(Console.ReadLine());
        Console.Write("Please input hours: ");
        int hour = int.Parse(Console.ReadLine());
        Console.Write("Please input minutes: ");
        float min = float.Parse(Console.ReadLine());
        Console.Write("Please input seconds: ");
        float sec = float.Parse(Console.ReadLine());

        Console.WriteLine($"Speed is {dis / (hour + min * 1 / 60 + sec / 3600)} km/h");

        //check if input char is vowel, digit, or any other symbol
        Console.Write("Input a character: ");
        char inputChar = Console.ReadLine()[0];
        if ("aeiouAEIOU".Contains(inputChar))
        {
            Console.WriteLine("The character is a vowel.");
        }
        else if ((int)inputChar >= 48 && (int)inputChar <= 57)
        {
            Console.WriteLine("The character is a digit.");
        }
        else
        {
            Console.WriteLine("The character is another symbol.");
        }

        //Celcius to Farenheit
        Console.Write("Please input Celcius degree: ");
        float Cel = float.Parse(Console.ReadLine());
        Console.WriteLine($"Kelvin = {Cel + 273}");
        Console.WriteLine($"Farenheit = {Cel * 18 / 10 + 32}");

        //Area and volume of Sphere
        Console.Write("Please input sphere radius: ");
        float Rad = float.Parse(Console.ReadLine());
        Console.WriteLine($"Surface = {4 * 3.14 * Rad * Rad}");
        Console.WriteLine($"Volume = {4 / 3 * 3.14 * Rad * Rad * Rad}");

        //Adding, subtracting, multiplying, and dividing two numbers 
        Console.Write("Please input first number: ");
        float Num1 = float.Parse(Console.ReadLine());
        Console.Write("Please input second number: ");
        float Num2 = float.Parse(Console.ReadLine());
        Console.WriteLine($$"""
            {{Num1}} + {{Num2}} = {{Num1 + Num2}}
            {{Num1}} - {{Num2}} = {{Num1 - Num2}}
            {{Num1}} x {{Num2}} = {{Num1 * Num2}}
            {{Num1}} / {{Num2}} = {{Num1 / Num2}}
            {{Num1}} mod {{Num2}} = {{Num1 % Num2}}
            """);

    }
}