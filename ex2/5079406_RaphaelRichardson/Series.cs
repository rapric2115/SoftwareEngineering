public class Series : Media
{
    // TODO: Declare "something" to keep count of all series objects created
    //       - Private read/write access
    //       - Increment whenever a new series object is created

    private static int seriesCount = 0;

    // TODO: Declare "something" for the release year of the series
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - The first ever TV series is usually credited as “The Queen’s Messenger” (1928)
    //       - Ensure the release year is at least 1928
    //       - If invalid, display: "SERIES: The Series Release Year must be at least 1928! Value not set."

    private int releaseYear;
    public override int ReleaseYear
    {
        get { return releaseYear; }
        protected set
        {
            if (value >= 1928)
            {
                releaseYear = value;
            }
            else
            {
                System.Console.WriteLine("SERIES: The Series Release Year must be at least 1928! Value not set.");
            }
        }
    }

    // TODO: Declare "something" for the type of media
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - Only accept types defined in the IWatchable interface
    //       - If the type is not recognized, store it as "Unknown Series Media Type"

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
            mediaType = isValidType ? value.ToUpper() : "Unknown Series Media Type";
        }
    }

    // TODO: Declare "something" for the latest release year
    //       - Public read access
    //       - Private write access
    //       - Must be greater than or equal to the release year
    //       - If invalid, display: "SERIES: Latest Release Year has to be equal to or greater than Release Year! Value not set."

    private int latestReleaseYear;
    public int LatestReleaseYear
    {
        get { return latestReleaseYear; }
        private set
        {
            if (value >= ReleaseYear)
            {
                latestReleaseYear = value;
            }
            else
            {
                System.Console.WriteLine("SERIES: Latest Release Year has to be equal to or greater than Release Year! Value not set.");
            }
        }
    }

    // TODO: Declare "something" for total duration in minutes of a the entire series
    //       - Public read access
    //       - Set value only when read using episode length and number of episodes

    public int SeriesLength
    {
        get
        {
            return NumberOfEpisodesPerSeason * NumberOfSeasons * TotalDurationMinutes;
        }
    }


    // TODO: Declare "something" for the number of seasons
    //       - Public read access
    //       - Private write access
    //       - Must be greater than 0
    //       - If invalid, display: "SERIES: The Number of Seasons must be greater than 0! Value not set."

    private int numberOfSeasons { get; private set; }

    // TODO: Declare "something" for the number of episodes per season
    //       - Public read access
    //       - Set only once via constructor

    public int EpisodePerSeason { get; }

    // TODO: Declare "something" to store the list of episodes
    //       - Public read access
    //       - Private write access (can add episodes via method)
    //       - Initialize as empty list in constructor
    
    private List<Episode> episodes;

    public Series()
    {
        episodes = new List<Episode>();
    }

    // TODO: Declare "something" to add a new episode to the list
    //       - Public access
    //       - Accept argument: episode object
    //       - Adds episode to the list

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    // TODO: Declare "something" for the currently chosen episode
    //       - Public read access
    //       - Private write access

    public Episode CurrentEpisode { get; private set; }

    // TODO: Declare "something" to choose an episode to watch
    //       - Public access
    //       - Accept arguments: season number (int), episode number (int)
    //       - Search episodes list for matching season and episode
    //       - If found, set as current episode
    //       - If not found, set current episode to null

    public void ChooseEpisode(int seasonNumber, int episodeNumber)
    {
        foreach (var episode in episodes)
        {
            if (episode.SeasonNumber == seasonNumber && episode.EpisodeNumber == episodeNumber)
            {
                CurrentEpisode = episode;
                return;
            }
        }
        CurrentEpisode = null;
    }

    // TODO: Declare "something" to create a new series object
    //       - Accept arguments: title (string), release year (int), latest release year (int), media type (string),
    //         number of seasons (int), number of episodes per season (int), total duration in minutes of a single episode (int)
    //       - Call parent constructor to set title and total duration
    //       - Set all other arguments to what you defined above
    //       - Increment the series counter

    public Series(
        string title, int releaseYear,
        int latestReleaseYear, string mediaType,
        int numberOfSeasons, int numberOfEpisodesPerSeason,
        int totalDurationMinutes) :
        base(title, totalDurationMinutes)
    {
        this.ReleaseYear = releaseYear;
        this.LatestReleaseYear = latestReleaseYear;
        this.MediaType = mediaType;
        this.numberOfSeasons = numberOfSeasons;
        this.EpisodePerSeason = numberOfEpisodesPerSeason;
        episodes = new List<Episode>();
        seriesCount++;
    }


    // TODO: Declare "something" to play the series
    //       - Public access
    //       - No arguments
    //       - If not already playing:
    //             - If current episode is not null:
    //                   - Set as playing
    //                   - Display: "SERIES: Playing Series [Title]: [Current Episode]!"
    //             - Else:
    //                   - Set as not playing
    //                   - Display: "SERIES: Chosen Episode DOES NOT EXIST!"
    //       - Otherwise, display: "SERIES: Series [Title]: [Current Episode] is already playing!"
    //       - Must be overridden from parent

    public override void Play()
    {
        if (!IsPlaying)
        {
            if (CurrentEpisode != null)
            {
                IsPlaying = true;
                System.Console.WriteLine($"SERIES: Playing Series {Title}: {CurrentEpisode}!");
            }
            else
            {
                IsPlaying = false;
                System.Console.WriteLine("SERIES: Chosen Episode DOES NOT EXIST!");
            }
        }
        else
        {
            System.Console.WriteLine($"SERIES: Series {Title}: {CurrentEpisode} is already playing!");
        }
    }

    // TODO: Declare "something" to pause the series, overridden from parent
    //       - Public access
    //       - Accept argument: pause time in minutes (int)
    //       - If playing:
    //             - Pause at given time using parent functionality
    //             - Display: "SERIES: Pausing the Series [Title]: [Current Episode] at [current watch time] minutes!"
    //       - Otherwise, display: "SERIES: Series [Title]: [Current Episode] is not playing, cannot pause it!"
    //       - Prevent further overriding in child classes

    public override void Pause(int PauseTimeMinutes)
    {
        if (IsPlaying)
        {
            base.Pause(PauseTimeMinutes);
            System.Console.WriteLine($"SERIES: Pausing the Series {Title}: {CurrentEpisode} at {CurrentWatchTimeMinutes} minutes!");
        }
        else
        {
            System.Console.WriteLine($"SERIES: Series {Title}: {CurrentEpisode} is not playing, cannot pause it!");
        }
    }

    // TODO: Declare "something" to stop the series, overridden from parent
    //       - Public access
    //       - No arguments
    //       - Can be overridden in child classes
    //       - If playing:
    //             - Stop playing using parent functionality
    //             - Display: "SERIES: Stopping the Series [Title]: [Current Episode]!"
    //       - Otherwise, display: "SERIES: Series [Title]: [Current Episode] is not playing, cannot stop it!"

    public override void Stop()
    {
        if (IsPlaying)
        {
            base.Stop();
            System.Console.WriteLine($"SERIES: Stopping the Series {Title}: {CurrentEpisode}!");
        }
        else
        {
            System.Console.WriteLine($"SERIES: Series {Title}: {CurrentEpisode} is not playing, cannot stop it!");
        }
    }

    // TODO: Declare "something" to show the series description
    //       - Public access
    //       - No arguments
    //       - Must be overridden from parent
    //       - Display in this order:
    //             - "SERIES DESCRIPTION: "
    //             - "Title: [Title]"
    //             - "Current Episode: [Current Episode]"
    //             - "Current Watch Time: [current watch time] minutes"
    //             - "Released: [ReleaseYear] - [Latest ReleaseYear]"
    //             - "Number of Seasons: [Number Of Seasons]"
    //             - "Number of Episodes Per Season: [NumberOf Episodes Per Season]"
    //             - "Total Number of Episodes: [Episodes Count]"
    //             - "Each Episode: [total duration in minutes] minutes"
    //             - "Series Total Runtime: [Series Length]"
    //             - "Media Type: [Media Type]"
    //             - If playing: "Series is playing ..."
    //             - Otherwise: "Series is not playing ..."

    public override void ShowDescription()
    {
        System.Console.WriteLine("SERIES DESCRIPTION:");
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Current Episode: {CurrentEpisode}");
        System.Console.WriteLine($"Current Watch Time: {CurrentWatchTimeMinutes} minutes");
        System.Console.WriteLine($"Released: {ReleaseYear} - {LatestReleaseYear}");
        System.Console.WriteLine($"Number of Seasons: {numberOfSeasons}");
        System.Console.WriteLine($"Number of Episodes Per Season: {EpisodePerSeason}");
        System.Console.WriteLine($"Total Number of Episodes: {episodes.Count}");
        System.Console.WriteLine($"Each Episode: {TotalDurationMinutes} minutes");
        System.Console.WriteLine($"Series Total Runtime: {SeriesLength} minutes");
        System.Console.WriteLine($"Media Type: {MediaType}");
        if (IsPlaying)
        {
            System.Console.WriteLine("Series is playing ...");
        }
        else
        {
            System.Console.WriteLine("Series is not playing ...");
        }
    }

    // TODO: Declare "something" to print the total series created and total media objects created
    //       - Public static access
    //       - Display in this order:
    //             - "Total Series Created: [series counter]"
    //             - "Total Media Created: [all media counter]"

    public static void GetSeriesCount()
    {
        System.Console.WriteLine($"Total Series Created: {seriesCount}");
        System.Console.WriteLine($"Total Media Created: {Media.GetMediaCount()}");
    }
}

