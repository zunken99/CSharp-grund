namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        string name = "Michael Gustavsson";
        // String template
        // String interpolation för att addera dynamiska värden
        // Console.WriteLine("Stränger innehåller {0} tecken", name.Length);
        Console.WriteLine($"Stränger innehåller {name.Length} tecken");

        // BAD PRACTICE!!!
        // char character = name[1];
        // Console.WriteLine($"2:a tecknet är {character}");

        string partOfName = name[..];
        // string partOfName = name.Substring(0);
        Console.WriteLine($"partOfName is {partOfName}");
        string partOfName2 = name[..1];
        // string partOfName2 = name.Substring(0, 1);
        Console.WriteLine($"partOfName2 is {partOfName2}");
        string partOfName3 = name[7..];
        // string partOfName3 = name.Substring(7);
        Console.WriteLine($"partOfName3 is {partOfName3}");

        var parts = name.Split(" ");
        Console.WriteLine(parts);
        Console.WriteLine(parts[0]);
        Console.WriteLine(parts[1]);

        Console.WriteLine(name + " " + "Adress: Gatan 1");
        string address = "Gatan 1";
        Console.WriteLine(string.Concat(name, " ", address, " ", "Telefon: 123456"));

        var exists = name.Contains("ael");
        Console.WriteLine(exists);

        // EndsWith()
        // StartsWith()
    }
}
