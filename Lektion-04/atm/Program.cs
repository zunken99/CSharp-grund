namespace atm;

class Program
{

    // Deklarera en variabel för aktuellt saldo...
    static int balance = 0;
    // Deklarera en variabel för transaktioner...
    static List<string> transactions = new List<string>();
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
        Console.WriteLine("För att visa transaktioner tryck på tangenten 't'");
        Console.WriteLine("------------------------------------------------------------------");

        try
        {
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
                        throw new Exception("Du måste ange ett heltals belopp som du vill sätta in!");
                    }

                    Deposit(amount);
                }
                else if (key == "w")
                {
                    Console.WriteLine("Hur mycket vill du ta ut?");
                    var amount = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(amount))
                    {
                        throw new Exception("Du måste ange ett heltals belopp som du vill ta ut!");
                    }

                    WithDraw(amount);
                }
                else if (key == "b")
                {
                    DisplayBalance();
                }
                else if (key == "t")
                {
                    DisplayTransactions();
                }
                else
                {
                    Console.WriteLine("Jag förstår inte ditt val");
                    Environment.Exit(0);
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
            Environment.Exit(0);
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

        // if (int.TryParse(amount, out int result))
        // {
        //     balance += result;
        //     transactions.Add($"Transaktionsdatum: {DateTime.Now} - Transaktionstyp: insättning - Transaktionvärde: {result}");
        //     return;
        // }

        // throw new Exception("Kan inte tolka din inmatning som heltal");
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
