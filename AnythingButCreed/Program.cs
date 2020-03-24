using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Define a List, named goodSongs, that will hold instances of Song.
            List<Song> goodSongs = new List<Song>();
            // 3. Define a List, named allSongs, that contains 12 instances of Song.
            // Make sure that some of the songs are from the band Creed.
            List<Song> allSongs = new List<Song>();
            allSongs.Add(new Song("Creed","song1"));
            allSongs.Add(new Song("Creed", "song2"));
            allSongs.Add(new Song("Creed", "song3"));
            allSongs.Add(new Song("Creed", "song4"));
            allSongs.Add(new Song("Creed", "song5"));
            allSongs.Add(new Song("Creed", "song6"));
            allSongs.Add(new Song("Creed", "song7"));
            allSongs.Add(new Song("Creed", "song8"));
            allSongs.Add(new Song("Creed", "song9"));
            allSongs.Add(new Song("Lucy Dacus", "Addicions"));
            allSongs.Add(new Song("Watsky", "Welcome to the Family"));
            allSongs.Add(new Song("Dumbfoundead", "Safe"));

            // 4. Once the set is populated with 12 instances of song, use Linq to filter the allSongs list for songs where the artist is not Creed.
            // Set goodSongs equal to the filtered result.

            var removeCreed = allSongs.Where(song => song.Artist != "Creed");
            goodSongs.AddRange(removeCreed);

            // 5. Loop to print out all the good songs
            foreach (var good in goodSongs)
            {
                Console.WriteLine($"{good.Name} by {good.Artist}");
                Console.ReadLine();
            }
        }
    }
}
