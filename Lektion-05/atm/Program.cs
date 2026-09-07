namespace atm;

public class User
{
    public string UserId { get; set; } = "";
    public int Pin { get; set; }
    public int Balance { get; set; }
}

public class Transaction
{
    public string Type { get; }
    public DateTime Date { get; }
    public int Value { get; }

    public Transaction(string type, int value)
    {
        Type = type;
        Date = DateTime.Now;
        Value = value;
    }
}

class Program
{
    static User user = new User
    {
        UserId = "user1",
        Balance = 0
    };

    static List<Transaction> transactions = new();

    static void Main()
    {
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Välkommen Westcoast Bank");
        Console.WriteLine("Meny alternativ");
        Console.WriteLine("För att avsluta programmet tryck på tangenten 'x'");
        Console.WriteLine("För att sätta in pengar tryck på tangenten 'd'");
        Console.WriteLine("För att ta ut pengar tryck på tangenten 'w'");
        Console.WriteLine("För att visa saldot tryck på tangenten 'b'");
        Console.WriteLine("För att visa transaktioner tryck på tangenten 't'");
        Console.WriteLine("------------------------------------------------------------------");

        App();
    }

    static void App()
    {
        while (true)
        {
            Console.Write("\nVälj ett alternativ: ");
            string? key = Console.ReadLine()?.Trim().ToLower();

            try
            {
                switch (key)
                {
                    case "b":
                        DisplayBalance();
                        break;
                    case "d":
                        Deposit(ReadAmount("Hur mycket vill du sätta in? "));
                        break;
                    case "w":
                        WithDraw(ReadAmount("Hur mycket vill du ta ut? "));
                        break;
                    case "t":
                        DisplayTransactions();
                        break;
                    case "x":
                        Environment.Exit(0);
                        return;
                    case "":
                        return;
                    default:
                        Console.WriteLine("Okänt alternativ.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }

    static void DisplayBalance()
    {
        Console.WriteLine($"Du har {user.Balance} kr på ditt konto.");
    }

    static void DisplayTransactions()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("Det finns inga transaktioner.");
            return;
        }

        foreach (Transaction transaction in transactions)
        {
            Console.WriteLine(
                $"Datum: {transaction.Date:G} | " +
                $"Typ: {transaction.Type} | " +
                $"Belopp: {transaction.Value} kr");
        }
    }

    static int ReadAmount(string message)
    {
        Console.Write(message);
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int amount) || amount <= 0)
        {
            throw new Exception("Ange ett positivt heltalsbelopp.");
        }

        return amount;
    }

    static void Deposit(int amount)
    {
        user.Balance += amount;
        transactions.Add(new Transaction("insättning", amount));
    }

    static void WithDraw(int amount)
    {
        if (amount > user.Balance)
        {
            throw new Exception("Du har inte tillräckligt med pengar.");
        }

        user.Balance -= amount;
        transactions.Add(new Transaction("uttag", amount));
    }
}
