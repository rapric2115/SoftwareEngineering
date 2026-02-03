public class Device
{
    // TODO: Declare "something" to generate random numbers
    //       - Public static access
    //       - Use Random class

    public static Random randomGenerator = new Random();

    // TODO: Declare "something" to play a Media object
    //       - Public static access
    //       - Accept a Media object as an argument
    //       - If the Media object is a Series:
    //           - Choose a random season between 1 and total number of seasons
    //           - Choose a random episode between 1 and number of episodes per season
    //           - Call the Series method to choose the episode to watch
    //       - Call the Media object's Play method
    //       - Call the Media object's Pause method with a sample pause time
    //       - Call the Media object's ShowDescription method

    public static void Play ( Media media )
    {
        if (media is Series series)
        {
            int season = randomGenerator.Next(1, series.NumberOfSeasons + 1);
            int episode = randomGenerator.Next(1, series.EpisodesPerSeason + 1);
            series.ChooseEpisode(season, episode);
        }
                
        media.Play();
        media.Pause(10);
        media.ShowDescription();
    }

    // TODO: Declare "something" to play an IWatchable object
    //       - Public static access
    //       - Accept an IWatchable object as an argument
    //       - If the IWatchable object is a Series:
    //           - Choose a random season and episode as above
    //           - Call the Series method to choose the episode to watch
    //       - Call the IWatchable object's Play method
    //       - Call the IWatchable object's Stop method
    //       - If the IWatchable object is also a Media object, call ShowDescription

    public static void Play(IWatchable watchable)
    {
        if (watchable is Series series)
        {
            int season = randomGenerator.Next(1, series.NumberOfSeasons + 1);
            int episode = randomGenerator.Next(1, series.EpisodesPerSeason + 1);
            series.ChooseEpisode(season, episode);
        }

        watchable.Play();
        watchable.Stop();

        if (watchable is Media media)
        {
            media.ShowDescription();
        }
    }

    // TODO: Declare "something" to play an Object
    //       - Public static access
    //       - Accept an Object as an argument
    //       - If the Object is a Series:
    //           - Choose a random season and episode as above
    //           - Call the Series method to choose the episode to watch
    //       - If the Object is a Media object:
    //           - Call the Play method
    //           - Call the ShowDescription method

    public static void Play(object obj)
    {
        if (obj is Series series)
        {
            int season = randomGenerator.Next(1, series.NumberOfSeasons + 1);
            int episode = randomGenerator.Next(1, series.EpisodesPerSeason + 1);
            series.ChooseEpisode(season, episode);
        }
        else if (obj is Media media)
        {
            media.Play();
            media.Pause(10);
            media.ShowDescription();
        }
    }
}