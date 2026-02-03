using System.Security.Cryptography.X509Certificates;

public class Movie : Media
{
    // TODO: Declare "something" to keep count of all movie objects created
    //       - Private read/write access
    //       - Increment whenever a new movie object is created

    private static int movieCount = 0;

    // TODO: Declare "something" for the release year of the movie
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - The first full-length movie is generally considered to be 
    //         “The Story of the Kelly Gang”, an Australian film released in 1906
    //       - Ensure the release year is at least 1906
    //       - If invalid, display: "MOVIE: The Movie's Release Year must be at least 1906! Value not set."

    private int releaseYear;
    public override int ReleaseYear
    {
        get { return releaseYear; }
        protected set
        {
            if (value >= 1906)
            {
                releaseYear = value;
            }
            else
            {
                System.Console.WriteLine("MOVIE: The Movie's Release Year must be at least 1906! Value not set.");
            }
        }
    }


    // TODO: Declare "something" for the type of media
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - Only accept types defined in the IWatchable interface
    //       - If the type is not recognized, store it as "Unknown Movie Media Type"

    private string mediaType;
    public override string MediaType
    {
        get { return mediaType; }
        protected set
        {
            bool isValidType = false;
            foreach (string validType in IWatchable.validMediaType)
            {
                if (value.ToUpper() == validType)
                {
                    isValidType = true;
                    break;
                }
            }
            mediaType = isValidType ? value.ToUpper() : "Unknown Movie Media Type";
        }
    }

    /*
        public override string MediaType
    {
        get {return mediaType; }
        protect
        (   
            value == IWatchable.DVD ||
            value == IWatchable.VHS ||
            value == IWatchable.STREAMING ||
        )
            {
                mediaType = value
            }
            else
            {
                mediaType = "Unknown Movie Media Type";
            }
        }
     } 
    */


    // TODO: Declare "something" to store the movie director's name
    //       - Public read access
    //       - Private write access
    //       - Must contain both first and last name
    //       - Cannot be null or empty
    //       - If invalid, display: "MOVIE: Must specify a director's first and last name! Value not set"

    private string director;

    public string Director
    {
        get { return director; }
        private set
        {
            if (!string.IsNullOrEmpty(value) && value.Trim().Contains(" "))
            {
                director = value;
            }
            else
            {
                // System. at the beginning of Console
                Console.WriteLine("MOVIE: Must specify a director's first and last name! Value not set");
            }
        }
    }

    // TODO: Declare "something" to create a new movie object
    //       - Accept arguments: title (string), release year (int), media type (string), director (string), total duration in minutes (int)
    //       - Call parent constructor to set title and total duration in minutes
    //       - Set release year, media type, and director
    //       - Increment the movie counter

    public Movie(
        string title, int releaseYear,
        string mediaType, string director,
        int totalDurationMinutes) :
        base(title, totalDurationMinutes)
    {
        this.ReleaseYear = releaseYear;
        this.MediaType = mediaType;
        this.Director = director;
        movieCount++;
    }



    // TODO: Declare "something" to play the movie
    //       - Public access
    //       - No arguments
    //       - If the movie is not already playing:
    //             - Set as playing
    //             - Display: "MOVIE: Playing Movie [Title]!"
    //       - Otherwise, display: "MOVIE: Movie [Title] is already playing!"
    //       - Must be overridden from parent

    public override void Play()
    {
        if (!IsPlaying)
        {
            IsPlaying = true;
            Console.WriteLine($"MOVIE: Playing Movie {Title}!");
        }
        else
        {
            Console.WriteLine($"MOVIE: Movie {Title} is already playing!");
        }
    }



    // TODO: Declare "something" to pause the movie, overridden from parent
    //       - Public access
    //       - Accept argument: pause time in minutes (int)
    //       - If the movie is playing:
    //             - Pause at given time using parent functionality
    //             - Display: "MOVIE: Pausing the Movie [Title] at [current watch time] minutes!"
    //       - Otherwise, display: "MOVIE: The Movie [Title] is not playing, cannot pause it!"
    //       - Prevent further overriding in child classes

    public sealed override void Pause(int pauseTimeMinutes)
    {
        if (IsPlaying)
        {
            base.Pause(pauseTimeMinutes);
            Console.WriteLine($"MOVIE: Pausing the Movie {Title} at {CurrentWatchTimeMinutes} Minutes!");
        }
        else
        {
            Console.WriteLine($"MOVIE: The Movie {Title} is not playing, cannot pause it!");
        }
    }


    // TODO: Declare "something" to stop the movie, overridden from parent
    //       - Public access
    //       - No arguments
    //       - Can be overridden in child classes
    //       - If the movie is playing:
    //             - Stop playing using parent functionality
    //             - Display: "MOVIE: Stopping the Movie [Title]!"
    //       - Otherwise, display: "MOVIE: The Movie [Title] is not playing, cannot stop it!"

    public override void Stop()
    {
        if (IsPlaying)
        {
            base.Stop();
            Console.WriteLine($"MOVIE: Stopping the movie {Title}");
        }
        else
        {
            Console.WriteLine($"MOVIE: The movie {Title} is not playing, cannot stop it.");
        }
    }

    // TODO: Declare "something" to show the movie description
    //       - Public access
    //       - No arguments
    //       - Must be overridden from parent
    //       - Display in this order:
    //             - "MOVIE DESCRIPTION: "
    //             - "Title: [Title]"
    //             - "Released: [Release Year]"
    //             - "Director: [Director]"
    //             - "Duration: [total duration in minutes] minutes"
    //             - "Current Watch Time: [current watch time in minutes] minutes"
    //             - "Media Type: [media type]"
    //             - If playing: "Movie is playing ..."
    //             - Otherwise: "Movie is not playing ..."

    public override void ShowDescription()
    {
        Console.WriteLine("MOVIE DESCRIPTION:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Released: {ReleaseYear}");
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine($"Duration: {TotalDurationMinutes} minutes");
        Console.WriteLine($"Current Watch Time: {CurrentWatchTimeMinutes} minutes");
        Console.WriteLine($"Media Type: {MediaType}");

        Console.WriteLine(IsPlaying
            ? "Movie is playing ..."
            : "Movie is not playing ...");
    }


    // TODO: Declare "something" to print the total movies created and total media objects created
    //       - Public static access
    //       - Display in this order:
    //             - "Total Movies Created: [movie counter]"
    //             - "Total Media Created: [all media counter]"

    public static void PrintCounts()
    {
        Console.WriteLine($"Total Movies Created: {movieCount}");
        Console.WriteLine($"Total Media Created: {Media.GetMediaCount()}");
    }

}
