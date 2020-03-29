using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio_2
{
    public class Song
    {
        private string name;
        private string genre;
        private string artist;
        private string album;

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Genre
        {
            get
            {
                return this.genre;
            }
        }
        public string Artist
        {
            get
            {
                return this.artist;
            }
        }
        public string Album
        {
            get
            {
                return this.album;
            }
        }

        public Song(string name, string artist, string album, string genre)
        {
            this.name = name;
            this.artist = artist;
            this.album = album;
            this.genre = genre;
        }
        public string Information()
        {
            return ("Name:" + name + ", Artist:" + artist + ", Album:" + album + ", Genre:" + genre);
        }


    }
}
