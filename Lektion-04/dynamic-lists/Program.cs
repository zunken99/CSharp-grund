using System.Collections;

namespace dynamic_lists;

class Program
{
    static void Main()
    {
        // =====================================================
        // Basic lists - ArrayList - Inte rekommenderade längre
        // =====================================================
        /*
        ArrayList demo = new ArrayList();
        // ArrayList demo = [];
        demo.Add("Michael");
        demo.Add(35);
        demo.Add(false);
        demo.Add(new { make = "Volvo", model = "XC60", mileage = 1200000, modelYear = 2017 });

        foreach (var item in demo)
        {
            Console.WriteLine(item);
        }
        */

        // =====================================================
        // Basic lists - List<T>
        // =====================================================
        List<string> movies = new List<string>();
        // List<string> movies = [];
        movies.Add("Bucket List");
        movies.Add("Batman");
        movies.Add("Die Hard");

        Console.WriteLine($"Antal filmer: {movies.Count}");
        Console.WriteLine($"Kapacitet: {movies.Capacity}");

        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

        movies.Reverse();

        Console.WriteLine("");
        Console.WriteLine("Reversed order ---------------------------------------------");
        Console.WriteLine("");

        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

        movies.Sort();

        Console.WriteLine("");
        Console.WriteLine("Sorted order ---------------------------------------------");
        Console.WriteLine("");

        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

        // =====================================================
        // Basic lists - Queue<T>
        // =====================================================

        /*
        Console.WriteLine("");
        Console.WriteLine("Queue ---------------------------------------------");
        Console.WriteLine("");

        Queue<string> comics = new Queue<string>();
        // Queue<string> comics = [];
        comics.Enqueue("Buster");
        comics.Enqueue("Läderlappen");
        comics.Enqueue("X9");

        foreach (var comic in comics)
        {
            Console.WriteLine(comic);
        }

        var newComics = comics.Shuffle();
        comics.Dequeue();
        Console.WriteLine("");

        foreach (var comic in comics)
        {
            Console.WriteLine(comic);
        }

        Console.WriteLine("");
        Console.WriteLine("Shuffled Queue ---------------------------------------------");
        Console.WriteLine("");

        foreach (var comic in newComics)
        {
            Console.WriteLine(comic);
        }
        */

        Console.WriteLine("");
        Console.WriteLine("Stack ---------------------------------------------");
        Console.WriteLine("");

        Stack<int> test = new Stack<int>();
        // Stack<int> test = [];
        test.Push(1);
        test.Push(2);
        test.Push(3);
        test.Push(4);
        test.Push(5);

        foreach (var item in test)
        {
            Console.WriteLine(item);
        }

        test.Pop();

        Console.WriteLine("");
        Console.WriteLine("Stack efter pop() ---------------------------------------------");
        Console.WriteLine("");

        foreach (var item in test)
        {
            Console.WriteLine(item);
        }
    }
}
