using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("===== OOP 4 PILLARS DEMO: Media Library =====\n");

        // TODO: Declare a Random object to use for randomly choosing a Device method
        Random rnd = new Random();


        // -------------------------------
        // TODO: Create Movies
        // -------------------------------
        // TODO: Create "something" for a Movie with title "NeverEnding Story", release year 1984, type "DVD", director "Wolfgang Petersen", and total duration 102 minutes
        // TODO: Create "something" for a Movie with title "Dark Crystal", release year 1982, type "BETA", director "Jim Henson", and total duration 93 minutes
        // TODO: Create "something" for a Movie with title "Labyrinth", release year 1986, type "DVD", director "Jim Henson", and total duration 101 minutes

        Movie movie1 = new Movie("NeverEnding Story", 1984, "DVD", 102, "Wolfgang Petersen");
        Movie movie2 = new Movie("Dark Crystal", 1982, "BETA", 93, "Jim Henson");
        Movie movie3 = new Movie("Labyrinth", 1986, "DVD", 101,  "Jim Henson");

        // -------------------------------
        // TODO: Create Stand Up Specials
        // -------------------------------
        // TODO: Create "something" for a Stand Up Special with title "Killing Them Softly", release year 2000, type "STREAMING", comic "Dave Chappelle", total duration 62 minutes
        // TODO: Create "something" for a Stand Up Special with title "Elephant in the Room", release year 2011, type "DVD", comic "Patrice O'Neal", total duration 75 minutes
        // TODO: Create "something" for a Stand Up Special with title "I'm Telling You for the Last Time", release year 1998, type "VHS", comic "Jerry Seinfeld", total duration 67 minutes

        StandUpSpecial special1 = new StandUpSpecial("Killing Them Softly", 2000, "STREAMING", 62, "Dave Chappelle");
        StandUpSpecial special2 = new StandUpSpecial("Elephant in the Room", 2011, "DVD", 75, "Patrice O'Neal");
        StandUpSpecial special3 = new StandUpSpecial("I'm Telling You for the Last Time", 1998, "VHS", 67, "Jerry Seinfeld");

        // -------------------------------
        // TODO: Create Series and Episodes
        // -------------------------------
        // TODO: Create "something" for a Series with title "Deadwood", release year 2004, latest release year 2006, type "STREAMING", 3 seasons, 12 episodes per season, each episode 55 minutes
        // TODO: Create "something" for a Series with title "The Sopranos", release year 1999, latest release year 2007, type "DVD", 6 seasons, 13 episodes per season, each episode 58 minutes

        Series series1 = new Series("Deadwood", 2004, 2006, "STREAMING", 3, 12, 55);
        Series series2 = new Series("The Sopranos", 1999, 2007, "DVD", 6, 13, 58);

        // TODO: Add episodes to the "Deadwood" series using nested loops
        //       - Outer loop: seasons from 1 to number of seasons
        //       - Inner loop: episodes from 1 to number of episodes per season
        //       - Add a new Episode object for each combination of season and episode

            for (int season = 1; season <= series1.NumberOfSeasons; season++)
            {
                for (int episode = 1; episode <= series1.EpisodesPerSeason; episode++)
                {
                    Episode newEpisode = new Episode(series1, season, episode);
                    series1.AddEpisode(newEpisode);
                }
        }

        // TODO: Add episodes to the "The Sopranos" series using nested loops
        //       - Outer loop: seasons from 1 to number of seasons
        //       - Inner loop: episodes from 1 to number of episodes per season
        //       - Add a new Episode object for each combination of season and episode

            for (int season = 1; season <= series2.NumberOfSeasons; season++)
        {
            for (int episode = 1; episode <= series2.EpisodesPerSeason; episode++)
            {
                Episode newEpisode = new Episode(series2, season, episode);
                series2.AddEpisode(newEpisode);
            }
        }

        // -------------------------------
        // TODO: Display the total number of media objects created for each media type
        // -------------------------------
        Console.WriteLine("\n>>> Media Counts\n");
        // TODO: Display the total number of Movie objects created and the total number of all media objects
        // TODO: Display the total number of Stand Up Special objects created and the total number of all media objects
        // TODO: Display the total number of Series objects created and the total number of all media objects
        //       - Print a blank line

        //Console.WriteLine($">>> Total Movies Created: {Movie.GetMovieCount()}");
        Movie.GetMovieCount();
        Console.WriteLine($">>> Total Media Created: {Media.GetMediaCount()}\n");


        Console.WriteLine($">>> Total Media Created: {Media.GetMediaCount()}\n");
        //Console.WriteLine($">>> Total Series Created: {Series.GetSeriesCount()}");
        Series.GetSeriesCount();

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
         List<Media> mediaLibrary = new List<Media>
        {
            movie1,
            movie2,
            movie3,
            special1,
            special2,
            special3,
            series1,
            series2
        };
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.WriteLine("\n===== DEMO COMPLETE =====");
    }
}
