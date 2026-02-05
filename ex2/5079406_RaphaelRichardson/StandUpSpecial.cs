using System;

public class StandUpSpecial : Media
{
    // TODO: Declare "something" to keep count of all StandUpSpecial objects created
    //       - Private read/write access
    //       - Increment whenever a new StandUpSpecial object is created

    private static int standUpCount = 0;

    public static void GetStandUpCount()
    {
        Console.WriteLine($"Total StandUp Specials Created: {standUpCount}");
    }

    // TODO: Declare "something" for the release year of the special
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent

    private int releaseYear;
    public override int ReleaseYear
    {
        get { return releaseYear; }
        protected set
        {
            if (value >= 1888)
                releaseYear = value;
            else
                Console.WriteLine("STANDUP: The Release Year must be at least 1888! Value not set.");
        }
    }

    // TODO: Declare "something" for the type of media
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
            mediaType = isValid ? value : "Unknown StandUp Media Type";
        }
    }

    // TODO: Declare "something" to store the comedian's name
    //       - Public read access
    //       - Private write access

    private string comicName = string.Empty;
    public string ComicName
    {
        get { return comicName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Comic Name cannot be null or empty.");
            comicName = value;
        }
    }

    // TODO: Constructor to create a new StandUpSpecial object
    //       - Accept arguments: title, releaseYear, mediaType, totalDurationMinutes, comicName

    public StandUpSpecial(string title, int releaseYear, string mediaType, int totalDurationMinutes, string comicName)
        : base(title, totalDurationMinutes)
    {
        ReleaseYear = releaseYear;
        MediaType = mediaType;
        ComicName = comicName;

        standUpCount++;
    }

    // TODO: Declare "something" to play the special

    public override void Play()
    {
        if (!IsPlaying)
        {
            IsPlaying = true;
            Console.WriteLine($"STANDUP: Playing StandUp Special {Title} by {ComicName}!");
        }
        else
        {
            Console.WriteLine($"STANDUP: StandUp Special {Title} is already playing!");
        }
    }

    // TODO: Declare "something" to pause the special

    public override void Pause(int PauseTimeMinutes)
    {
        if (IsPlaying)
        {
            base.Pause(PauseTimeMinutes);
            Console.WriteLine($"STANDUP: Pausing StandUp Special {Title} at {CurrentWatchTimeMinutes} minutes!");
        }
        else
        {
            Console.WriteLine($"STANDUP: StandUp Special {Title} is not playing, cannot pause it!");
        }
    }

    // TODO: Declare "something" to stop the special

    public override void Stop()
    {
        if (IsPlaying)
        {
            base.Stop();
            Console.WriteLine($"STANDUP: Stopping StandUp Special {Title}!");
        }
        else
        {
            Console.WriteLine($"STANDUP: StandUp Special {Title} is not playing, cannot stop it!");
        }
    }

    // TODO: Declare "something" to show the description of the special

    public override void ShowDescription()
    {
        Console.WriteLine("STANDUP DESCRIPTION:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Comic: {ComicName}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Media Type: {MediaType}");
        Console.WriteLine($"Total Duration: {TotalDurationMinutes} minutes");
        Console.WriteLine($"Current Watch Time: {CurrentWatchTimeMinutes} minutes");
        Console.WriteLine(IsPlaying ? "Special is playing ..." : "Special is not playing ...");
    }
}
