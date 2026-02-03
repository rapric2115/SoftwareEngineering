public class StandUpSpecial : Media
{
    // TODO: Declare "something" to keep count of all stand up special objects created
    //       - Private read/write access
    //       - Increment whenever a new stand up special object is created

    private static int standUpSpecialCount = 0;

    // TODO: Declare "something" for the release year of the stand up special
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - Richard Pryor’s Live & Smokin’ (1971) is widely considered the first full-length stand-up special
    //       - Ensure the release year is at least 1971
    //       - If invalid, display: "The Stand Up Special's Release Year must be at least 1971! Value not set."

    private int releaseYear;
    public override int ReleaseYear
    {
        get { return releaseYear; }
        protected set
        {
            if (value >= 1971)
            {
                releaseYear = value;
            }
            else
            {
                System.Console.WriteLine("STAND UP SPECIAL: The Stand Up Special's Release Year must be at least 1971! Value not set.");
            }
        }
    }


    // TODO: Declare "something" for the type of media
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - Only accept types defined in the IWatchable interface
    //       - If the type is not recognized, store it as "Unknown Stand Up Special Media Type"

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
            mediaType = isValidType ? value.ToUpper() : "Unknown Stand Up Special Media Type";
        }
    }

    // TODO: Declare "something" to store the comic's name
    //       - Public read access
    //       - Private write access
    //       - Cannot be null or empty
    //       - If invalid, display: "STAND UP SPECIAL: Comic Name cannot be null or an empty string! Value not set."

    private string comicName;
    public string ComicName
    {
        get { return comicName; }
        private set
        {
            if (!string.IsNullOrEmpty(value))
            {
                comicName = value;
            }
            else
            {
                System.Console.WriteLine("STAND UP SPECIAL: Comic Name cannot be null or an empty string! Value not set.");
            }
        }
    }

    // TODO: Declare "something" to create a new stand up special object
    //       - Accept arguments: title (string), release year (int), media type (string), comic name (string), total duration in minutes (int)
    //       - Call parent constructor to set title and total duration in minutes
    //       - Set release year, media type, and comic name
    //       - Increment the stand up special counter

    public StandUpSpecial(string title, int releaseYear, string mediaType, string comicName, int totalDurationMinutes)
        : base()
    {
        this.Title = title;
        this.TotalDurationMinutes = totalDurationMinutes;
        this.ReleaseYear = releaseYear;
        this.MediaType = mediaType;
        this.ComicName = comicName;
        standUpSpecialCount++;
        // Increment the media count from the parent class
        MediaIncrementCount();
    }

    // TODO: Declare "something" to play the stand up special
    //       - Public access
    //       - No arguments
    //       - If not already playing:
    //             - Set as playing
    //             - Display: "STAND UP SPECIAL: Playing Stand Up Special [Title] featuring [Comic Name]!"
    //       - Otherwise, display: "STAND UP SPECIAL: Stand Up Special [Title] featuring [Comic Name] is already playing!"
    //       - Must be overridden from parent

    public override void Play()
    {
        if (!IsPlaying)
        {
            IsPlaying = true;
            System.Console.WriteLine($"STAND UP SPECIAL: Playing Stand Up Special {Title} featuring {ComicName}!");
        }
        else
        {
            System.Console.WriteLine($"STAND UP SPECIAL: Stand Up Special {Title} featuring {ComicName} is already playing!");
        }
    }

    // TODO: Declare "something" to pause the stand up special, overridden from parent
    //       - Public access
    //       - Accept argument: pause time in minutes (int)
    //       - If playing:
    //             - Pause at given time using parent functionality
    //             - Display: "STAND UP SPECIAL: Pausing the Stand Up Special at [current watch time] minutes!"
    //       - Otherwise, display: "STAND UP SPECIAL: Stand Up Special [Title] featuring [Comic Name] is not playing, cannot pause it!"
    //       - Prevent further overriding in child classes

    public sealed override void Pause(int pauseTimeMinutes)
    {
        if (IsPlaying)
        {
            base.Pause(pauseTimeMinutes);
            System.Console.WriteLine($"STAND UP SPECIAL: Pausing the Stand Up Special at {CurrentWatchTimeMinutes} minutes!");
        }
        else
        {
            System.Console.WriteLine($"STAND UP SPECIAL: Stand Up Special {Title} featuring {ComicName} is not playing, cannot pause it!");
        }
    }

    // TODO: Declare "something" to stop the stand up special, overridden from parent
    //       - Public access
    //       - No arguments
    //       - Can be overridden in child classes
    //       - If playing:
    //             - Stop playing using parent functionality
    //             - Display: "STAND UP SPECIAL: Stopping the Stand Up Special [Title] featuring [Comic Name]!"
    //       - Otherwise, display: "STAND UP SPECIAL: Stand Up Special [Title] featuring [Comic Name] is not playing, cannot stop it!"

    public override void Stop()
    {
        if (IsPlaying)
        {
            base.Stop();
            System.Console.WriteLine($"STAND UP SPECIAL: Stopping the Stand Up Special {Title} featuring {ComicName}!");
        }
        else
        {
            System.Console.WriteLine($"STAND UP SPECIAL: Stand Up Special {Title} featuring {ComicName} is not playing, cannot stop it!");
        }
    }

    // TODO: Declare "something" to show the stand up special description
    //       - Public access
    //       - No arguments
    //       - Must be overridden from parent
    //       - Display in this order:
    //             - "STAND UP SPECIAL DESCRIPTION: "
    //             - "Title: [Title]"
    //             - "Released: [Release Year]"
    //             - "Featuring: [Comic Name]"
    //             - "Duration: [total duration in minutes] minutes"
    //             - "Current Watch Time: [current watch time in minutes] minutes"
    //             - "Media Type: [media type]"
    //             - If playing: "Stand Up Special is playing ..."
    //             - Otherwise: "Stand Up Special is not playing ..."

    public override void ShowDescription()
    {
        System.Console.WriteLine("STAND UP SPECIAL DESCRIPTION:");
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Released: {ReleaseYear}");
        System.Console.WriteLine($"Featuring: {ComicName}");
        System.Console.WriteLine($"Duration: {TotalDurationMinutes} minutes");
        System.Console.WriteLine($"Current Watch Time: {CurrentWatchTimeMinutes} minutes");
        System.Console.WriteLine($"Media Type: {MediaType}");
        if (IsPlaying)
        {
            System.Console.WriteLine("Stand Up Special is playing ...");
        }
        else
        {
            System.Console.WriteLine("Stand Up Special is not playing ...");
        }
    }

    // TODO: Declare "something" to print the total stand up specials created and total media objects created
    //       - Public static access
    //       - Display in this order:
    //             - "Total Stand Up Specials Created: [stand up special counter]"
    //             - "Total Media Created: [all media counter]"

    public static void GetStandUpSpecialCount()
    {
        System.Console.WriteLine($">>> Total Stand Up Specials Created: {standUpSpecialCount}");
        System.Console.WriteLine($">>> Total Media Created: {Media.GetMediaCount()}\n");
    }

}
