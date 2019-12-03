using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Brixey
{
    public class Song
    {
        public string name { get; set; }
        public string artist{ get; set; }
        public string album { get; set; }
        public string genre { get; set; }
        public int size { get; set; }
        public int time { get; set; }
        public int year { get; set; }
        public int plays { get; set; }

        public Song(string n, string ar, string al, string g, int s, int t,
            int y, int p)
        {
            name = n;
            artist = ar;
            album = al;
            genre = g;
            size = s;
            time = t;
            year = y;
            plays = p;
        }
        override public string ToString()
        {
            return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3}, Size: {4}, Time: {5}, Year: {6}, Plays: {7}", name, artist, album, genre, size, time, year, plays);
        }
    }
}
