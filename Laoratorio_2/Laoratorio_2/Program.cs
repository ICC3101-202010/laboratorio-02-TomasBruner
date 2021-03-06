﻿using System;
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
            Song s1 = new Song("rojo", "j balvin", "colores", "urbano");
            Song s2 = new Song("alguien soy yo", "enrique iglesias", "insomniac", "baladas");
            Song s3 = new Song("the One", "back Street Boys", "millennium", "pop");

            //Canciones predeterminadas en la lista
            Espotifai lista1 = new Espotifai();
            lista1.AddSong(s1.Information());
            lista1.AddSong(s2.Information());
            lista1.AddSong(s3.Information());


            Console.WriteLine("Welcome to Espotifi");
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine("1. See songs in the list");
            Console.WriteLine("2. Add song to the list");
            Console.WriteLine("3. Choose songs for criterion");
            Console.WriteLine("4. Exit");
            string choice;
            choice = Console.ReadLine();
            while (choice == "1" || choice == "2" || choice == "3" || choice == "4")
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
                    else if (lista1.AddSong(newSong.Information()) == true)
                    {
                        lista1.AddSong(newSong.Information());
                        Console.WriteLine("The song has been added");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Choose a criterion (name, artist, genre, album)");
                    string criteria = Console.ReadLine();
                    if (criteria == "name" || criteria == "artist" || criteria == "genre" || criteria == "album")
                    {
                        Console.WriteLine("Choose a value for this criterion");
                        string value = Console.ReadLine();
                        lista1.SongsForCriteria(criteria, value);
                        
                    }
                    else
                    {
                        Console.WriteLine("This criterion doesn´t exist");
                    }
                    
                }
                
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("What would you like to do?:");
                Console.WriteLine("1. See songs in the list");
                Console.WriteLine("2. Add song to the list");
                Console.WriteLine("3. Choose songs for criterion");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();
            }
            Console.ReadKey();


        }
        
    }
    

    



}
    

