namespace WestcoastBank;

public class User(string userId, int pin, int balance)
{
    

    public string UserId { get; set; } = userId;
    public int Pin { get; set; } = pin;
    public int Balance { get; set; } = balance;
}

public record Transaction
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