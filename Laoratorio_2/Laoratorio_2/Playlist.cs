using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio_2
{
    class Playlist
    {
        private string name;
        private Song[] songs = { };

        public Playlist(string inputname, Song[] inputsongs)
        {
            name = inputname;
            songs = inputsongs;
        }

        public string InfoPlaylist()
        {
            return ("PLaylist name:" + name + "and this songs are in" + songs);
        }
 
    }
}
