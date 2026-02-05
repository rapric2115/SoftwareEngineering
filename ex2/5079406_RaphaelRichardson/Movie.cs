using System;

public class Movie : Media
{
    // TODO: Declare "something" to keep count of all movie objects created
    //       - Private read/write access
    //       - Increment whenever a new movie object is created

    private static int movieCount = 0;

    public static void GetMovieCount()
    {
        Console.WriteLine($"Total Movies Created: {movieCount}");
    }

    // TODO: Declare "something" for the release year of the movie
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent

    private int releaseYear;
    public override int ReleaseYear
    {
        get { return releaseYear; }
        protected set
        {
            if (value >= 1888) // first film in history
            {
                releaseYear = value;
            }
            else
            {
                Console.WriteLine("MOVIE: The Movie Release Year must be at least 1888! Value not set.");
            }
        }
    }

    // TODO: Declare "something" for the type of media (DVD, VHS, Streaming, etc.)
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent

    private string mediaType = string.Empty;
    public override string MediaType
    {
        get { return mediaType; }
        protected set
        {
            bool isValid = false;
            foreach (string t in IWatchable.validMediaType)
            {
                if (t.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    isValid = true;
                    break;
                }
            }
            mediaType = isValid ? value : "Unknown Movie Media Type";
        }
    }

    // TODO: Declare "something" to store the director
    //       - Public read access
    //       - Private write access
    //       - Must not allow null or empty

    private string director = string.Empty;
    public string Director
    {
        get { return director; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Director cannot be null or empty.");
            director = value;
        }
    }

    // TODO: Constructor to create a new movie object
    //       - Accept arguments: title, releaseYear, mediaType, totalDurationMinutes, director

    public Movie(string title, int releaseYear, string mediaType, int totalDurationMinutes, string director)
        : base(title, totalDurationMinutes)
    {
        ReleaseYear = releaseYear;
        MediaType = mediaType;
        Director = director;

        movieCount++;
    }

    // TODO: Declare "something" to play the movie

    public override void Play()
    {
        if (!IsPlaying)
        {
            IsPlaying = true;
            Console.WriteLine($"MOVIE: Playing Movie {Title} directed by {Director}!");
        }
        else
        {
            Console.WriteLine($"MOVIE: Movie {Title} is already playing!");
        }
    }

    // TODO: Declare "something" to pause the movie

    public override void Pause(int PauseTimeMinutes)
    {
        if (IsPlaying)
        {
            base.Pause(PauseTimeMinutes);
            Console.WriteLine($"MOVIE: Pausing Movie {Title} at {CurrentWatchTimeMinutes} minutes!");
        }
        else
        {
            Console.WriteLine($"MOVIE: Movie {Title} is not playing, cannot pause it!");
        }
    }

    // TODO: Declare "something" to stop the movie

    public override void Stop()
    {
        if (IsPlaying)
        {
            base.Stop();
            Console.WriteLine($"MOVIE: Stopping Movie {Title}!");
        }
        else
        {
            Console.WriteLine($"MOVIE: Movie {Title} is not playing, cannot stop it!");
        }
    }

    // TODO: Declare "something" to show the description of the movie
    public override void ShowDescription()
    {
        Console.WriteLine("MOVIE DESCRIPTION:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Media Type: {MediaType}");
        Console.WriteLine($"Total Duration: {TotalDurationMinutes} minutes");
        Console.WriteLine($"Current Watch Time: {CurrentWatchTimeMinutes} minutes");
        Console.WriteLine(IsPlaying ? "Movie is playing ..." : "Movie is not playing ...");
    }
}
