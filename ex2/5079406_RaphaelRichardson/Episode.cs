public class Episode
{
    // TODO: Declare "something" for the series this episode belongs to
    //       - Public read/write access
    //       - Accept objects of type Series

    public Series Series { get; set; }

    // TODO: Declare "something" for the season number of this episode
    //       - Public read access
    //       - Public write access
    //       - Must be less than or equal to the total number of seasons in the series
    //       - If invalid, display: "EPISODE: Season Number is invalid! Value not set."

    private int seasonNumber;
    public int SeasonNumber
    {
        get { return seasonNumber; }
        set
        {
            if (Series != null && value <= Series.NumberOfSeaons && value > 0)
            {
                seasonNumber = value;
            }
            else
            {
                Console.WriteLine("EPISODE: Season Number is invalid! Value not set.");
            }
        }
    }

    // TODO: Declare "something" for the episode number within the season
    //       - Public read access
    //       - Public write access
    //       - Must be less than or equal to the number of episodes per season in the series
    //       - If invalid, display: "EPISODE: Episode Number is invalid! Value not set."

    private int episodeNumber;
    public int EpisodeNumber
    {
               get { return episodeNumber; }
        set
        {
            if (Series != null && value <= Series.EpisodesPerSeason && value > 0)
            {
                episodeNumber = value;
            }
            else
            {
                Console.WriteLine("EPISODE: Episode Number is invalid! Value not set.");
            }
        }
    }

    // TODO: Declare "something" to construct a new episode object
    //       - Public access
    //       - Accept arguments: series object, season number (int), episode number (int)
    //       - Set the series, season number, and episode number using the appropriate setters

    public Episode(Series series, int seasonNumber, int episodeNumber)
    {
        Series = series;
        SeasonNumber = seasonNumber;
        EpisodeNumber = episodeNumber;
    }

    // TODO: Declare "something" to return a string representation of the episode when printed (hint override something from Object)
    //       - Public access
    //       - No arguments
    //       - Format should be: "S[SeasonNumber]E[EpisodeNumber]"
   
    public override string ToString()
    {
        return $"S{SeasonNumber}E{EpisodeNumber}";
    }
}
