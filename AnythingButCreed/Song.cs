using System;
using System.Collections.Generic;
using System.Text;

namespace AnythingButCreed
{
    class Song
    {
        // 1. Define a class called Song that has a string property Artist and a string property Name.
        // Both properties should be required in order to construct an instance of Song
        public string Artist { get; set; }
        public string Name { get; set; }

        public Song(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }
    }
}
