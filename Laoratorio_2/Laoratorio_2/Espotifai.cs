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

        //Metodo para separar por criterio, considerando que el usuario pondra un criterio de los que se piden y nombres de valores
        //existentes (aunque no esten en la lista)
        public String[] values = { };
        public String[] SongsForCriteria(String criterion, String value)
        {
            if (criterion == "genre")
            {
                int i = 0;
                while (i < songs.Count)
                {
                    if (songs[i].Contains(value))
                    {
                        Console.WriteLine(songs[i]);
                        values.Append(songs[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (criterion == "artist")
            {
                int i = 0;
                while (i < songs.Count)
                {
                    if (songs[i].Contains(value))
                    {
                        Console.WriteLine(songs[i]);
                        values.Append(songs[i]);
                        i++;
                    }
                    else
                    {
                      
                        i++;
                    }
                }
            }
            if (criterion == "name")
            {
                int i = 0;
                while (i < songs.Count)
                {
                    if (songs[i].Contains(value))
                    {
                        Console.WriteLine(songs[i]);
                        values.Append(songs[i]);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("This value doesn´t exist");
                        i++;
                    }
                }
            }
            if (criterion == "album")
            {
                int i = 0;
                while (i < songs.Count)
                {
                    if (songs[i].Contains(value))
                    {
                        Console.WriteLine(songs[i]);
                        values.Append(songs[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            
        return values;
        }

    }
}
