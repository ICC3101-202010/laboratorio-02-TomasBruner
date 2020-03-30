using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Rojo", "J balvin", "Colores", "Urbano");
            Song s2 = new Song("Alguien soy yo", "Enrique Iglesias", "Insomniac", "Baladas");
            Song s3 = new Song("The One", "Back Street Boys", "Millennium", "Pop");

            //Canciones predeterminadas en la lista
            Espotifai lista1 = new Espotifai();
            lista1.AddSong(s1.Information());
            lista1.AddSong(s2.Information());
            lista1.AddSong(s3.Information());


            Console.WriteLine("Welcome to Espotifi");
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine("1. See songs in the list");
            Console.WriteLine("2. Add song to the list");
            Console.WriteLine("3. Exit");
            string choice;
            choice = Console.ReadLine();
            while (choice == "1" || choice == "2" || choice == "3")
            {
                if (choice == "1")
                {
                    lista1.WatchSongs();

                }
                else if (choice == "2")
                {
                    Console.WriteLine("Name:");
                    string newName;
                    newName = Console.ReadLine();
                    Console.WriteLine("Artist:");
                    string newArtist;
                    newArtist = Console.ReadLine();
                    Console.WriteLine("Album:");
                    string newAlbum;
                    newAlbum = Console.ReadLine();
                    Console.WriteLine("Genre:");
                    string newGenre;
                    newGenre = Console.ReadLine();
                    Song newSong = new Song(newName, newArtist, newAlbum, newGenre);
                    if (lista1.AddSong(newSong.Information()) == false)
                    {
                        
                        Console.WriteLine("The song already exists");
                    }
                    else
                    {
                        lista1.AddSong(newSong.Information());
                        Console.WriteLine("The song has been added");
                    }
                    
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("Welcome to Espotifi");
                Console.WriteLine("What would you like to do?:");
                Console.WriteLine("1. See songs in the list");
                Console.WriteLine("2. Add song to the list");
                Console.WriteLine("3. Exit");
                choice = Console.ReadLine();
            }
            Console.ReadKey();


        }
        
    }
    

    



}
    

