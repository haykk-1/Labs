using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Ֆիլմերի քանակը՝ ");
        string? countLine = Console.ReadLine();
        int count = Convert.ToInt32(countLine);

        Movie[] movies = new Movie[count];

        Console.WriteLine("Ժանրեր՝ 1=Action, 2=Comedy, 3=Drama, 4=SciFi, 5=Documentary");
        Console.WriteLine("Գրեք՝ համար;անուն;տարեթիվ;ժանր;դիտումներ;լայքեր");

        for (int i = 0; i < count; i++)
        {
            Console.Write("Ֆիլմ " + (i + 1) + "՝ ");
            string? line = Console.ReadLine();

            if (line == null)
            {
                return;
            }

            string[] parts = line.Split(';');

            if (parts.Length != 6)
            {
                Console.WriteLine("Պետք է մուտքագրել 6 արժեք՝ բաժանված ; նշանով։");
                return;
            }

            int number = int.Parse(parts[0].Trim());
            string name = parts[1].Trim();
            int year = int.Parse(parts[2].Trim());
            int genreNumber = int.Parse(parts[3].Trim());
            int views = int.Parse(parts[4].Trim());
            int likes = int.Parse(parts[5].Trim());

            MovieGenre genre;

            switch (genreNumber)
            {
                case 1:
                    genre = MovieGenre.Action;
                    break;
                case 2:
                    genre = MovieGenre.Comedy;
                    break;
                case 3:
                    genre = MovieGenre.Drama;
                    break;
                case 4:
                    genre = MovieGenre.SciFi;
                    break;
                case 5:
                    genre = MovieGenre.Documentary;
                    break;
                default:
                    Console.WriteLine("Ժանրը պետք է լինի 1-ից 5 թիվ։");
                    return;
            }

            Movie movie = new Movie(number, name, year, genre, views, likes);
            movies[i] = movie;
        }

        Console.WriteLine();
        Console.WriteLine("Ֆիլմերի ցուցակը՝");
        Console.WriteLine("No.".PadLeft(4) + " " + "Name".PadRight(15) + " "
                        + "Year".PadRight(8) + " " + "Genre".PadRight(12)
                        + " " + "Rating".PadLeft(8));

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(movies[i].ToString());
        }
    }
}
