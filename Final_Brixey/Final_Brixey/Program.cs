using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final_Brixey
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("PlaylistAnalyzer <inputfile_path> <reportfile_path>");
                Environment.Exit(1);
            }

            string inputFilePath = args[0];
            string reportFilePath = args[1];

            List<Song> songList  = null;
            try
            {
                songList = SongLoader.Load(inputFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(2);
            }

            var report = SongReport.GenerateText(songList);

            try
            {
                System.IO.File.WriteAllText(reportFilePath, report);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            }
        }
    }
}
