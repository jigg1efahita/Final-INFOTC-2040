using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Brixey
{
    public static class SongReport
    {
        public static string GenerateText(List<Song> songs)
        {
            string report = "Music Playlist Analyzer\n\n";

            if (songs.Count() < 1)
            {
                report += "No data is available.\n";

                return report;
            }

            report += "Songs that recieved 200 or more plays:\n";
            var q1 = from Song in songs where Song.plays >= 200 select Song.ToString();
            if (q1.Count() > 0)
            {
                foreach (var value in q1) { report += value + "\n"; }; 
                report.TrimEnd(',');
                report += "\n";
            }
            else
            {
                report += "not available\n";
            }

            report += "Number of Alternative songs in playlist: ";
            var q2 = from Song in songs where Song.genre == "Alternative" select Song.ToString();
            if (q2.Count() > 0)
            {
                report += q2.Count() + "\n";
                report.TrimEnd(',');
                report += "\n";
            }

            report += "Number of Hip-Hop/Rap songs in playlist: ";
            var q3 = from Song in songs where Song.genre == "Hip-Hop/Rap" select Song.ToString();
            if (q3.Count() > 0)
            {
                report += q3.Count() + "\n";
                report.TrimEnd(',');
                report += "\n";
            }
            report += "Sons from the Album 'Welcome to the Fishbowl': \n";
            var q4 = from Song in songs where Song.album == "Welcome to the Fishbowl" select Song.ToString();
            if (q4.Count() > 0)
            {
                foreach (var value in q4) { report += value + "\n"; };
                report.TrimEnd(',');
                report += "\n";
            }
            report += "Songs from before 1970: \n";
            var q5 = from Song in songs where Song.year <= 1970 select Song.ToString();
            if (q5.Count() > 0)
            {
                foreach (var value in q5) { report += value + "\n"; };
                report.TrimEnd(',');
                report += "\n";
            }
            report += "Song names longer than 85 chracters: \n";
            var q6 = from Song in songs where Song.name.Count() > 85 select Song.name.ToString();
            if (q6.Count() > 0)
            {
                foreach (var value in q6) { report += value + "\n"; };
                report.TrimEnd(',');
                report += "\n";
            }
            report += "Longest song: \n";
            var q7 = from Song in songs orderby Song.time descending select Song.ToString();
            if (q7.Count() > 0)
            {
                report += q7.First() + "\n";
                report.TrimEnd(',');
                report += "\n";
            }
            return report;

        }
    }
    
}
