namespace refoutParams;

class Program
{
    static void Main()
    {
        int age = 25;
        int refResult = DemoRef(ref age);

        Console.WriteLine($"Local age = {age}");
        Console.WriteLine($"refAge = {refResult}");

        int outAge;
        int outResult = DemoOut(age, out outAge);

        Console.WriteLine($"Out local age = {age}");
        Console.WriteLine($"Out variable = {outAge}");
        Console.WriteLine($"OutResult = {outResult}");
    }

    static int DemoRef(ref int age)
    {
        age++;
        return age;
    }

    static int DemoOut(int age, out int newAge)
    {
        newAge = age;
        newAge++;
        return age;
    }
}
