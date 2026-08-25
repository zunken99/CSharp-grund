namespace atm;

class Program
{
    static void Main()
    {
        // Deklarera en variabel för aktuellt saldo...
        int balance;
        // Insättning...
        Console.WriteLine("Hur mycket vill du sätta in?");
        // Deklarera en variabel för insättningen...
        var amount = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(amount))
        {
            Console.WriteLine("DU MÅSTE ANGE HUR MYCKET DU VILL SÄTTA IN!!!");
            Environment.Exit(0);
        }

        balance = int.Parse(amount);

        Console.WriteLine($"Du har {balance} på ditt konto");

        Console.WriteLine("Hur mycket vill du ta ut?");
        amount = Console.ReadLine();
        Console.WriteLine($"Du vill ta ut {amount} Kr");

        balance -= int.Parse(amount);
        // balance = balance - int.Parse(amount);

        Console.WriteLine($"Du har {balance} på ditt konto");
    }
}
