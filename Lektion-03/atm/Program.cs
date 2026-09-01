namespace atm;

class Program
{
    static void Main()
    {
        // Påbörjar vår meny...
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Välkommen Westcoast Bank");
        Console.WriteLine("Meny alternativ");
        Console.WriteLine("För att avsluta programmet tryck på tangenten 'x'");
        Console.WriteLine("För att sätta in pengar tryck på tangenent 'd'");
        Console.WriteLine("För att ta ut pengar tryck på tangenten 'w'");
        Console.WriteLine("För att visa saldot tryck på tangenten 'b'");
        Console.WriteLine("------------------------------------------------------------------");

        // Deklarera en variabel för aktuellt saldo...
        int balance = 0;

        while (true)
        {
            var key = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(key) || key == "x")
            {
                Environment.Exit(0);
            }
            else if (key == "d")
            {
                Console.WriteLine("Hur mycket vill du sätta in?");
                var amount = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(amount))
                {
                    Console.WriteLine("Du måste ange ett heltals belopp som du vill sätta in!");
                    Environment.Exit(0);
                }

                if (int.TryParse(amount, out int result))
                {
                    balance += result;
                    DisplayBalance(balance);
                }
                else
                {
                    Console.WriteLine("Tyvärr förstår inte jag vad du menar");
                    Environment.Exit(0);
                }
            }
            else if (key == "w")
            {
                Console.WriteLine("Hur mycket vill du ta ut?");
                var amount = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(amount))
                {
                    Console.WriteLine("Du måste ange ett heltals belopp som du vill ta ut!");
                    Environment.Exit(0);
                }

                if (int.TryParse(amount, out int result))
                {
                    balance -= result;
                    DisplayBalance(balance);
                }
                else
                {
                    Console.WriteLine("Tyvärr förstår inte jag vad du menar");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Jag förstår inte ditt val");
                Environment.Exit(0);
            }
        }
    }

    // Enkel metod för att skriva ut saldot...
    static void DisplayBalance(int balance)
    {
        Console.WriteLine($"Du har {balance} på ditt konto");
    }

    static void Deposit() { }
    static void WithDraw() { }
}
