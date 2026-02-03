public abstract class Media : IWatchable
{
    // TODO: Declare "something" to keep count of all media objects created
    //       - Public read access
    //       - Private write access
    //       - Increment whenever a new media object is created

    private static int mediaCount = 0;

    public static int GetMediaCount()
    {
        return mediaCount;
    }

    // TODO: Declare "something" for the release year of the media
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden in child classes

    public abstract int ReleaseYear { get; protected set; }

    // TODO: Declare "something" for the type of media (DVD, VHS, Streaming, etc.)
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden in child classes

    public abstract string MediaType { get; protected set; }

    // TODO: Declare "something" to store the title of the media
    //       - Public read access
    //       - Protected write access
    //       - Do not allow null or empty values

    private string Title { get; protected set; }

    // TODO: Declare "something" to track if the media is currently playing
    //       - Public read access
    //       - Protected write access

    public bool IsPlaying { get; protected set; }

    // TODO: Declare "something" to store the total duration in minutes of the media
    //       - Public read access
    //       - Public write access
    //       - Must be >= 0
    // HINT: check out the IWatchable interface

    private int totalDurationMinutes;
    public int TotalDurationMinutes
    {
        get { return totalDurationMinutes; }
        set
        {
            if (value >= 0)
            {
                totalDurationMinutes = value;
            }
        }
    }

    // TODO: Declare "something" to store the current watch time in minutes of the media
    //       - Public read access
    //       - Public write access
    //       - Must be between 0 and the total duration in minutes
    // HINT: check out the IWatchable interface

    private int currentWatchTimeMinutes;
    public int CurrentWatchTimeMinutes
    {
        get { return currentWatchTimeMinutes; }
        set
        {
            if (value >= 0 && value <= TotalDurationMinutes)
            {
                currentWatchTimeMinutes = value;
            }
        }
    }

    // TODO: Declare "something" to create a new media object
    //       - Accept arguments: title (string), total duration in minutes (int)
    //       - Initialize current watch time in minutes to 0
    //       - Increment the counter for all media objects created

    protected Media(string title, int totalDurationMinutes)
    {
        if(string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.");

        Title = title;
        TotalDurationMinutes = totalDurationMinutes;
        CurrentWatchTimeMinutes = 0;
        IsPlaying = false;

        mediaCount++;
    }

    // TODO: Declare "something" to play the media
    //       - Public access
    //       - No arguments
    //       - Must be overridden in child classes
    // HINT: check out the IWatchable interface

    public abstract void Play();


    // TODO: Declare "something" to pause the media
    //       - Public access
    //       - Accept argument: pause time in minutes (int)
    //       - Set the current media to be not playing
    //       - Set the current watch time to the pause time
    //       - Can be overridden in child classes
    // HINT: check out the IWatchable interface

    public virtual void Pause(int PauseTimeMinutes)
    {
        IsPlaying = false;
        CurrentWatchTimeMinutes = PauseTimeMinutes;
    }
    // TODO: Declare "something" to stop the media
    //       - Public access
    //       - No arguments
    //       - Set the current media to be not playing
    //       - Reset current watch time using IWatchable interface
    //       - Can be overridden in child classes
    // HINT: check out the IWatchable interface

    public virtual void Stop()
    {
        IsPlaying = false;
        ResetWatchTime();
    }

    public void ResetWatchTime()
    {
        CurrentWatchTimeMinutes = 0;
    }

    // TODO: Declare "something" to show the description of the media
    //       - Public access
    //       - No arguments
    //       - Must be overridden in child classes

    public abstract void ShowDescription();
}
