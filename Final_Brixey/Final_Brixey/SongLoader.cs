﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final_Brixey
{
    public static class SongLoader
    {
        private static int NumInRow = 8;

        public static List<Song> Load(string inputFilePath)
        {
            List<Song> songList = new List<Song>();

            try
            {
                using (var reader = new StreamReader(inputFilePath))
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        lineNumber++;
                        if (lineNumber == 1) continue;

                        var values = line.Split('\t');

                        if (values.Length != NumInRow)
                        {
                            throw new Exception($"Row {lineNumber} contains {values.Length} values. It should contain {NumInRow}.");
                        }
                        try
                        {
                            string name = (values[0]);
                            string artist = values[1];
                            string album = values[2];
                            string genre = values[3];
                            int size = Int32.Parse(values[4]);
                            int time = Int32.Parse(values[5]);
                            int year = Int32.Parse(values[6]);
                            int plays = Int32.Parse(values[7]);

                            Song playlist = new Song(name, artist, album, genre, size, time, year, plays);
                            songList.Add(playlist);
                        }
                        catch (FormatException e)
                        {
                            throw new Exception($"Row {lineNumber} contains invalid data. ({e.Message})");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to open {inputFilePath} ({e.Message}).");
            }
            return songList;
        }
    }
}
