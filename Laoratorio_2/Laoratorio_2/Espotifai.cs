using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio_2
{
    class Espotifai 
    {

        public Espotifai()
        {

        }

        List<String> songs = new List<String>();

        public bool AddSong(String song)
        {
            if (songs.Contains(song))
            {
                return false;
            }
            else
            {
                songs.Add(song);
                return true;
            }
        }

        
        public void WatchSongs()
        {
            int i = 0;
            while (i < songs.Count)
            {
                Console.WriteLine(songs[i]);
                i++;
            }
        }

    }
}
