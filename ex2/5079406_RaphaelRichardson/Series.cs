public class Series : Media
{
    // TODO: Declare "something" to keep count of all series objects created
    //       - Private read/write access
    //       - Increment whenever a new series object is created

    // TODO: Declare "something" for the release year of the series
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - The first ever TV series is usually credited as “The Queen’s Messenger” (1928)
    //       - Ensure the release year is at least 1928
    //       - If invalid, display: "SERIES: The Series Release Year must be at least 1928! Value not set."

    // TODO: Declare "something" for the type of media
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - Only accept types defined in the IWatchable interface
    //       - If the type is not recognized, store it as "Unknown Series Media Type"

    // TODO: Declare "something" for the latest release year
    //       - Public read access
    //       - Private write access
    //       - Must be greater than or equal to the release year
    //       - If invalid, display: "SERIES: Latest Release Year has to be equal to or greater than Release Year! Value not set."

    // TODO: Declare "something" for total duration in minutes of a the entire series
    //       - Public read access
    //       - Set value only when read using episode length and number of episodes

    // TODO: Declare "something" for the number of seasons
    //       - Public read access
    //       - Private write access
    //       - Must be greater than 0
    //       - If invalid, display: "SERIES: The Number of Seasons must be greater than 0! Value not set."

    // TODO: Declare "something" for the number of episodes per season
    //       - Public read access
    //       - Set only once via constructor

    // TODO: Declare "something" to store the list of episodes
    //       - Public read access
    //       - Private write access (can add episodes via method)
    //       - Initialize as empty list in constructor

    // TODO: Declare "something" to add a new episode to the list
    //       - Public access
    //       - Accept argument: episode object
    //       - Adds episode to the list

    // TODO: Declare "something" for the currently chosen episode
    //       - Public read access
    //       - Private write access

    // TODO: Declare "something" to choose an episode to watch
    //       - Public access
    //       - Accept arguments: season number (int), episode number (int)
    //       - Search episodes list for matching season and episode
    //       - If found, set as current episode
    //       - If not found, set current episode to null

    // TODO: Declare "something" to create a new series object
    //       - Accept arguments: title (string), release year (int), latest release year (int), media type (string),
    //         number of seasons (int), number of episodes per season (int), total duration in minutes of a single episode (int)
    //       - Call parent constructor to set title and total duration
    //       - Set all other arguments to what you defined above
    //       - Increment the series counter

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

    // TODO: Declare "something" to pause the series, overridden from parent
    //       - Public access
    //       - Accept argument: pause time in minutes (int)
    //       - If playing:
    //             - Pause at given time using parent functionality
    //             - Display: "SERIES: Pausing the Series [Title]: [Current Episode] at [current watch time] minutes!"
    //       - Otherwise, display: "SERIES: Series [Title]: [Current Episode] is not playing, cannot pause it!"
    //       - Prevent further overriding in child classes

    // TODO: Declare "something" to stop the series, overridden from parent
    //       - Public access
    //       - No arguments
    //       - Can be overridden in child classes
    //       - If playing:
    //             - Stop playing using parent functionality
    //             - Display: "SERIES: Stopping the Series [Title]: [Current Episode]!"
    //       - Otherwise, display: "SERIES: Series [Title]: [Current Episode] is not playing, cannot stop it!"

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

    // TODO: Declare "something" to print the total series created and total media objects created
    //       - Public static access
    //       - Display in this order:
    //             - "Total Series Created: [series counter]"
    //             - "Total Media Created: [all media counter]"
}

