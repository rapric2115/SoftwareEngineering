public class Movie : Media
{
    // TODO: Declare "something" to keep count of all movie objects created
    //       - Private read/write access
    //       - Increment whenever a new movie object is created

    // TODO: Declare "something" for the release year of the movie
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - The first full-length movie is generally considered to be 
    //         “The Story of the Kelly Gang”, an Australian film released in 1906
    //       - Ensure the release year is at least 1906
    //       - If invalid, display: "MOVIE: The Movie's Release Year must be at least 1906! Value not set."

    // TODO: Declare "something" for the type of media
    //       - Public read access
    //       - Protected write access
    //       - Must be overridden from parent
    //       - Only accept types defined in the IWatchable interface
    //       - If the type is not recognized, store it as "Unknown Movie Media Type"

    // TODO: Declare "something" to store the movie director's name
    //       - Public read access
    //       - Private write access
    //       - Must contain both first and last name
    //       - Cannot be null or empty
    //       - If invalid, display: "MOVIE: Must specify a director's first and last name! Value not set"

    // TODO: Declare "something" to create a new movie object
    //       - Accept arguments: title (string), release year (int), media type (string), director (string), total duration in minutes (int)
    //       - Call parent constructor to set title and total duration in minutes
    //       - Set release year, media type, and director
    //       - Increment the movie counter

    // TODO: Declare "something" to play the movie
    //       - Public access
    //       - No arguments
    //       - If the movie is not already playing:
    //             - Set as playing
    //             - Display: "MOVIE: Playing Movie [Title]!"
    //       - Otherwise, display: "MOVIE: Movie [Title] is already playing!"
    //       - Must be overridden from parent

    // TODO: Declare "something" to pause the movie, overridden from parent
    //       - Public access
    //       - Accept argument: pause time in minutes (int)
    //       - If the movie is playing:
    //             - Pause at given time using parent functionality
    //             - Display: "MOVIE: Pausing the Movie [Title] at [current watch time] minutes!"
    //       - Otherwise, display: "MOVIE: The Movie [Title] is not playing, cannot pause it!"
    //       - Prevent further overriding in child classes

    // TODO: Declare "something" to stop the movie, overridden from parent
    //       - Public access
    //       - No arguments
    //       - Can be overridden in child classes
    //       - If the movie is playing:
    //             - Stop playing using parent functionality
    //             - Display: "MOVIE: Stopping the Movie [Title]!"
    //       - Otherwise, display: "MOVIE: The Movie [Title] is not playing, cannot stop it!"

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

    // TODO: Declare "something" to print the total movies created and total media objects created
    //       - Public static access
    //       - Display in this order:
    //             - "Total Movies Created: [movie counter]"
    //             - "Total Media Created: [all media counter]"
}
