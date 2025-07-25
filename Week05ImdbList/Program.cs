using System;
using Week05ImdbList;

public class  Program
{
    static void Main ()
    {
        List<Movie> movies = new List<Movie>();

        while (true) // Start of the loop to allow multiple entries
        {
            // Get input from the user for movie title and IMDB rating
            Console.WriteLine("Enter a movie name: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the IMDB rating: ");
            double imdbRating = Convert.ToDouble(Console.ReadLine());

            // Create a new Movie object and adds it to the list
            movies.Add(new Movie(title, imdbRating));

            // New movie can be added until the user decides to stop
            Console.WriteLine("Do you want to add another movie? (yes/no)");
            string answer = Console.ReadLine().ToLower();

            // If the user answers "no", exit the loop
            if (answer == "no")
            {
                Console.WriteLine("\n--- All Movies List ---");
                foreach (var movie in movies) // Display all movies
                {
                    Console.WriteLine($"Movie: {movie.Title}, IMDB rating: {movie.ImdbRating.ToString("F1")}");
                }

                Console.WriteLine("\n--- IMDB Rating Betweem 4-9 ---");
                foreach (var movie in movies) // Display movies with IMDB rating between 4 and 9
                {
                    if (movie.ImdbRating >= 4 && movie.ImdbRating <= 9)
                    {
                        Console.WriteLine($"Movie: {movie.Title}, IMDB rating: {movie.ImdbRating.ToString("F1")}");
                    }
                }

                Console.WriteLine("\n--- Starting wirh 'A' Movies ---");
                foreach (var movie in movies) // Display movies starting with 'A'
                {
                    if (movie.Title.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Movie: {movie.Title}, IMDB rating: {movie.ImdbRating.ToString("F1")}");
                    }
                }

                break;
            }

        }



    }
}