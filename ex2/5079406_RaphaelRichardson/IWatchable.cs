using System.Xml.Serialization;

public interface IWatchable
{
    // TODO: Declare "something" to store all valid watchable types
    //       - Public static access
    //       - Read-only after initialization
    //       - Initialize it LATER (not when declared) to contain: "DVD", "VHS", "STREAMING", "BETA"
    public static readonly string[] validMediaType;

    static IWatchable()
    {
        validMediaType = new string[] { "DVD", "VHS", "STREAMING", "BETA" };
    }


    // TODO: Declare "something" to store the total duration in minutes for the media
    //       - Public read and write access
    //       - Must be implemented in classes implementing the interface

    int TotalDurationMinutes { get; set; }

    // TODO: Declare "something" to store the current watch time in minutes
    //       - Public read and write access
    //       - Must be implemented in classes implementing the interface

    int CurrentWatchTimeMinutes { get; set; }

    // TODO: Declare "something" to play the media
    //       - Must be implemented in classes implementing the interface

    void Play();

    // TODO: Declare "something" to pause the media
    //       - Accept an integer argument for pause time in minutes
    //       - Must be implemented in classes implementing the interface

    void Pause(int pauseTimeMinutes);


    // TODO: Declare "something" to stop the media
    //       - Must be implemented in classes implementing the interface

    void Stop();

    // TODO: Declare "something" to reset the current watch time
    //       - Implementation sets current watch time to 0

    void ResetWatchTime()
    {
        CurrentWatchTimeMinutes = 0;
    }
}
