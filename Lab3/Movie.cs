using System;
using System.Globalization;

public enum MovieGenre
{
    Action = 1,
    Comedy = 2,
    Drama = 3,
    SciFi = 4,
    Documentary = 5
}

public class Movie
{
    public int Number;
    public string Name;
    public int Year;
    public MovieGenre Genre;
    public int Views;
    public int Likes;

    public Movie(int number, string name, int year, MovieGenre genre, int views, int likes)
    {
        Number = number;
        Name = name;
        Year = year;
        Genre = genre;
        Views = views;
        Likes = likes;
    }

    public double CalculateRating()
    {
        if (Views == 0)
        {
            return 0;
        }

        double likesSquared = (double)Likes * Likes;
        double division = likesSquared / Views;
        double rating = Math.Sqrt(division);

        return rating;
    }

    public override string ToString()
    {
        string numberText = Number.ToString().PadLeft(4);
        string nameText = Name.PadRight(15);
        string yearText = ("(" + Year + ")").PadRight(8);
        string genreText = Genre.ToString().PadRight(12);

        double rating = CalculateRating();
        string ratingText = rating.ToString("F3", CultureInfo.InvariantCulture).PadLeft(8);

        string result = numberText + " " + nameText + " " + yearText + " "
                      + genreText + " " + ratingText;

        return result;
    }
}
