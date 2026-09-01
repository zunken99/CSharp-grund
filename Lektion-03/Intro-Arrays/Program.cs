namespace Intro_Arrays;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Antal lådor i numbers: " + numbers.Length);

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        Console.WriteLine("Byrålåda 3 har värdet: " + numbers[2]);
        numbers[2] = 60;
        Console.WriteLine("Byrålåda 3 har värdet: " + numbers[2]);

        Array.Resize(ref numbers, 600);
        numbers[5] = 70;

        Console.WriteLine("Byrålåda 6 har värdet: " + numbers[5]);
    }
}
