using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio_2
{
    class Espotifai
    {
        List<string> songs = new List<string>();

        public Espotifai()
        {

        }
        
        public bool AddSong(Song song)
        {
            if (songs.Contains(song.Information()))
            {
                return false;
            }
            else
            {
                songs.Add(song.Information());
            }

        }
        
        public void WatchSongs()
        {
            foreach(string s in songs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
