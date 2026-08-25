namespace intro;

class Program
{
    static void Main()
    {
        // explicit...
        string name = "Nisse";
        Console.WriteLine(name);

        // implicit...
        var lastName = "Nilsson";
        Console.WriteLine(name + " " + lastName);

        var age = 25;
        // Inte snyggt...
        Console.WriteLine(name + " " + lastName + " " + age);
        // String interpolation via string templates...
        Console.WriteLine($"Ditt namn är {name} {lastName} du är {age} gammal");

        var result = Calc(10);
        Console.WriteLine($"Svaret är {result}");

        var result2 = Calc(3.75M);
        Console.WriteLine($"Svaret är {result2}");

        var result3 = Calc(1,2,3,4,5,6,7,8,9,10);
        Console.WriteLine(result3);
    }

    static void Test()
    {
        // name ="Kalle";
    }

    static int Calc(int value)
    {
        return value + 10;
    }

    static decimal Calc(decimal value)
    {
        return value;
    }

    static int Calc(int val1,int val2)
    {
        return val1 + val2;
    }

    static int Calc(params int[] numbers)
    {
        return numbers.Sum();
    }

    
}
