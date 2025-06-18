using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;



class Movie
{
    public string Name { get; set; }
    public double ImdbPoint { get; set; }
}

class Program
{
    static void Main()
    {
        List<Movie> movieList = new List<Movie>();
        string continue1 = "evet";


        while (continue1 == "evet")
        {
            Console.Write("Film Adı: ");
            string name = Console.ReadLine();

            Console.Write("IMDB Puanı: ");
            double imdbPoint = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            movieList.Add(new Movie { Name = name, ImdbPoint = imdbPoint });

            Console.Write("Başka film eklemek istiyor musunuz? (evet/hayır): ");
            continue1 = Console.ReadLine().Trim().ToLower();

            while (continue1 != "evet" && continue1 != "hayır")
            {
                Console.Write("Lütfen sadece 'evet' veya 'hayır' yazın: ");
                continue1 = Console.ReadLine().Trim().ToLower();
            }
        }
        Console.WriteLine("--------- TÜM FİLMLER ---------");
        foreach (var movie in movieList)
        {
            Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.ImdbPoint}");
        }
        Console.WriteLine("--------- IMDB PUANI 4-9 ARASI OLANLAR ---------");
        foreach (var movie in movieList)
        {
            if (movie.ImdbPoint >= 4 && movie.ImdbPoint <= 9)
            {
                Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.ImdbPoint}");
            }
        }
        Console.WriteLine("--------- " + "A" + " HARFİ İLE BAŞLAYANLAR ---------");
        foreach (var movie in movieList)
        {
            if (movie.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film Adı: {movie.Name}, IMDB Puanı: {movie.ImdbPoint}");
            }
        }

    }
}