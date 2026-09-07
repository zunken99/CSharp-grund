namespace atm;

class Program
{

    // Deklarera en variabel för aktuellt saldo...
    static int balance = 0;
    // Deklarera en variabel för transaktioner...
    static List<string> transactions = new List<string>();
    static string? amount = null;
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

        App();

    }

    static void App()
    {
        try
        {
            while (true)
            {
                var key = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(key) || key == "x")
                {
                    Environment.Exit(0);
                }

                switch (key)
                {
                    // Balance...
                    case "b":
                        DisplayBalance();
                        break;
                    case "d":
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        amount = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            throw new Exception("Du måste ange ett heltals belopp som du vill sätta in!");
                            // Console.WriteLine("Du måste ange ett heltals belopp som du vill sätta in!, försök igen");
                            // continue;
                        }

                        Deposit(amount);

                        break;
                    case "t":
                        DisplayTransactions();
                        break;
                    case "w":
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        amount = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(amount))
                        {
                            throw new Exception("Du måste ange ett heltals belopp som du vill ta ut!");
                            // Console.WriteLine("Du måste ange ett heltals belopp som du vill ta ut!, försök igen");
                            // continue;
                        }

                        WithDraw(amount);
                        break;
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
            App();
            // Environment.Exit(0);
        }
        finally
        {
            Console.WriteLine("Klar!");
        }
    }

    // Enkel metod för att skriva ut saldot...
    static void DisplayBalance()
    {
        Console.WriteLine($"Du har {balance} på ditt konto");
    }

    static void DisplayTransactions()
    {
        foreach (var tran in transactions)
        {
            Console.WriteLine(tran);
        }
    }

    static void Deposit(string amount)
    {
        if (!int.TryParse(amount, out int result))
        {
            throw new Exception("Kan inte tolka din inmatning som heltal");
        }

        balance += result;
        transactions.Add($"Transaktionsdatum: {DateTime.Now} - Transaktionstyp: insättning - Transaktionvärde: {result}");
    }
    static void WithDraw(string amount)
    {
        if (int.TryParse(amount, out int result))
        {
            // Kontrollera att saldot är tillräckligt...
            balance -= result;
            transactions.Add($"Transaktionsdatum: {DateTime.Now} - Transaktionstyp: uttag - Transaktionvärde: {result}");
        }
        else
        {
            throw new Exception("Tyvärr förstår inte jag vad du menar");
        }
    }
}
