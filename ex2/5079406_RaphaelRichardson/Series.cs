using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

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
                releaseYear = value;
            else
                Console.WriteLine("SERIES: The Series Release Year must be at least 1928! Value not set.");
        }
    }

    // TODO: Declare "something" for the type of media
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - Only accept types defined in the IWatchable interface
    //       - If the type is not recognized, store it as "Unknown Series Media Type"

    private string mediaType = "Unknown Series Media Type";
    public override string MediaType
    {
        get { return mediaType; }
        protected set { mediaType = value; }
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
                latestReleaseYear = value;
            else
                Console.WriteLine("SERIES: Latest Release Year has to be equal to or greater than Release Year! Value not set.");
        }
    }

    // TODO: Declare "something" for total duration in minutes of the entire series
    //       - Public read access
    //       - Set value only when read using episode length and number of episodes
    public int SeriesLength
    {
        get { return EpisodesPerSeason * NumberOfSeasons * TotalDurationMinutes; }
    }

    // TODO: Declare "something" for the number of seasons
    //       - Public read access
    //       - Private write access
    //       - Must be greater than 0
    //       - If invalid, display: "SERIES: The Number of Seasons must be greater than 0! Value not set."
    private int numberOfSeasons;
    public int NumberOfSeasons
    {
        get { return numberOfSeasons; }
        private set
        {
            if (value > 0)
                numberOfSeasons = value;
            else
                Console.WriteLine("SERIES: The Number of Seasons must be greater than 0! Value not set.");
        }
    }

    // TODO: Declare "something" for the number of episodes per season
    //       - Public read access
    //       - Set only once via constructor

    private int episodesPerSeason;
    public int EpisodesPerSeason
    {
        get { return episodesPerSeason; }
        set
        {
            if (value >= 1)
                episodesPerSeason = value;
            else
                Console.WriteLine("Series: Episodes per season must be >= 1. Value not set.");
        }
    }

    // TODO: Declare "something" to store the list of episodes
    //       - Public read access
    //       - Private write access (can add episodes via method)
    //       - Initialize as empty list in constructor
    private List<Episode> episodes;

    // TODO: Declare "something" for the currently chosen episode
    //       - Public read access
    //       - Private write access
    public Episode? CurrentEpisode { get; private set; }

    public Series(string title, int releaseYear, int latestReleaseYear, string mediaType,
                  int numberOfSeasons, int episodesPerSeason, int totalDurationMinutes)
        : base(title, totalDurationMinutes)
    {
        this.ReleaseYear = releaseYear;
        this.LatestReleaseYear = latestReleaseYear;
        this.MediaType = mediaType;
        this.NumberOfSeasons = numberOfSeasons;
        this.EpisodesPerSeason = episodesPerSeason;

        episodes = new List<Episode>();
        CurrentEpisode = null;

        seriesCount++;
    }

    // TODO: Declare "something" to add a new episode to the list
    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    // TODO: Declare "something" to choose an episode to watch
    public void ChooseEpisode(int seasonNumber, int episodeNumber)
    {
        foreach (var ep in episodes)
        {
            if (ep.SeasonNumber == seasonNumber && ep.EpisodeNumber == episodeNumber)
            {
                CurrentEpisode = ep;
                return;
            }
        }
        CurrentEpisode = null;
    }

    // TODO: Declare "something" to play the series
    public override void Play()
    {
        if (!IsPlaying)
        {
            if (CurrentEpisode != null)
            {
                IsPlaying = true;
                Console.WriteLine($"SERIES: Playing Series {Title}: {CurrentEpisode}!");
            }
            else
            {
                Console.WriteLine("SERIES: Chosen Episode DOES NOT EXIST!");
            }
        }
        else
        {
            Console.WriteLine($"SERIES: Series {Title}: {CurrentEpisode} is already playing!");
        }
    }

    // TODO: Declare "something" to pause the series
    public override void Pause(int PauseTimeMinutes)
    {
        if (IsPlaying)
        {
            base.Pause(PauseTimeMinutes);
            Console.WriteLine($"SERIES: Pausing the Series {Title}: {CurrentEpisode} at {CurrentWatchTimeMinutes} minutes!");
        }
        else
        {
            Console.WriteLine($"SERIES: Series {Title}: {CurrentEpisode} is not playing, cannot pause it!");
        }
    }

    // TODO: Declare "something" to stop the series
    public override void Stop()
    {
        if (IsPlaying)
        {
            base.Stop();
            Console.WriteLine($"SERIES: Stopping the Series {Title}: {CurrentEpisode}!");
        }
        else
        {
            Console.WriteLine($"SERIES: Series {Title}: {CurrentEpisode} is not playing, cannot stop it!");
        }
    }

    // TODO: Declare "something" to show the series description
    public override void ShowDescription()
    {
        Console.WriteLine("SERIES DESCRIPTION:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Current Episode: {CurrentEpisode}");
        Console.WriteLine($"Current Watch Time: {CurrentWatchTimeMinutes} minutes");
        Console.WriteLine($"Released: {ReleaseYear} - {LatestReleaseYear}");
        Console.WriteLine($"Number of Seasons: {NumberOfSeasons}");
        Console.WriteLine($"Number of Episodes Per Season: {EpisodesPerSeason}");
        Console.WriteLine($"Total Number of Episodes: {episodes.Count}");
        Console.WriteLine($"Each Episode: {TotalDurationMinutes} minutes");
        Console.WriteLine($"Series Total Runtime: {SeriesLength} minutes");
        Console.WriteLine($"Media Type: {MediaType}");
        Console.WriteLine(IsPlaying ? "Series is playing ..." : "Series is not playing ...");
    }

    // TODO: Declare "something" to print the total series created and total media objects created
    public static void GetSeriesCount()
    {
        Console.WriteLine($"Total Series Created: {seriesCount}");
        Console.WriteLine($"Total Media Created: {Media.GetMediaCount()}");
    }
}
