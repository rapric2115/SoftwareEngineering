public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== OOP 4 PILLARS DEMO: Media Library =====\n");

        // TODO: Declare a Random object to use for randomly choosing a Device method

        // -------------------------------
        // TODO: Create Movies
        // -------------------------------
        // TODO: Create "something" for a Movie with title "NeverEnding Story", release year 1984, type "DVD", director "Wolfgang Petersen", and total duration 102 minutes
        // TODO: Create "something" for a Movie with title "Dark Crystal", release year 1982, type "BETA", director "Jim Henson", and total duration 93 minutes
        // TODO: Create "something" for a Movie with title "Labyrinth", release year 1986, type "DVD", director "Jim Henson", and total duration 101 minutes

        // -------------------------------
        // TODO: Create Stand Up Specials
        // -------------------------------
        // TODO: Create "something" for a Stand Up Special with title "Killing Them Softly", release year 2000, type "STREAMING", comic "Dave Chappelle", total duration 62 minutes
        // TODO: Create "something" for a Stand Up Special with title "Elephant in the Room", release year 2011, type "DVD", comic "Patrice O'Neal", total duration 75 minutes
        // TODO: Create "something" for a Stand Up Special with title "I'm Telling You for the Last Time", release year 1998, type "VHS", comic "Jerry Seinfeld", total duration 67 minutes

        // -------------------------------
        // TODO: Create Series and Episodes
        // -------------------------------
        // TODO: Create "something" for a Series with title "Deadwood", release year 2004, latest release year 2006, type "STREAMING", 3 seasons, 12 episodes per season, each episode 55 minutes
        // TODO: Create "something" for a Series with title "The Sopranos", release year 1999, latest release year 2007, type "DVD", 6 seasons, 13 episodes per season, each episode 58 minutes

        // TODO: Add episodes to the "Deadwood" series using nested loops
        //       - Outer loop: seasons from 1 to number of seasons
        //       - Inner loop: episodes from 1 to number of episodes per season
        //       - Add a new Episode object for each combination of season and episode

        // TODO: Add episodes to the "The Sopranos" series using nested loops
        //       - Outer loop: seasons from 1 to number of seasons
        //       - Inner loop: episodes from 1 to number of episodes per season
        //       - Add a new Episode object for each combination of season and episode

        // -------------------------------
        // TODO: Display the total number of media objects created for each media type
        // -------------------------------
        Console.WriteLine("\n>>> Media Counts\n");
        // TODO: Display the total number of Movie objects created and the total number of all media objects
        // TODO: Display the total number of Stand Up Special objects created and the total number of all media objects
        // TODO: Display the total number of Series objects created and the total number of all media objects
        //       - Print a blank line

        // -------------------------------
        // TODO: Play all media using one random Device method per media
        // -------------------------------
        // TODO: Create a List<Media> and add all movies, stand up specials, and series to it
        Console.WriteLine("\n>>> Playing All Media Using Device\n");
        // TODO: Loop through each media in the list
        //       - Print a message indicating which media title is being played
        //       - Generate a random integer 0, 1, or 2
        //       - If 0, call a Device method to play the media using a Media object argument
        //       - If 1, call a Device method to play the media using an IWatchable object argument
        //       - If 2, call a Device method to play the media using an Object argument
        //       - Print a blank line after playing each media

        Console.WriteLine("\n===== DEMO COMPLETE =====");
    }
}
