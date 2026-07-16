
using System.Runtime.InteropServices;

public class Program
{
    public static void Main (string[] args)
    {
        var reader = new SongReader();
        var songs  = reader.ReadSongs("Music Info.csv");    
       
       while (true)
        {
            Console.WriteLine("Welcome, Let's find your song \n [1]Name [2] Artist[3] Tags [4] Year");
            string? choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                Console.WriteLine("ENTER A SONG NAME OR A PART OF THE SONG'S NAME");
                var find = Console.ReadLine();
                var findSongs = songs.Where(song => song.Name.ToLower().Contains(find.ToLower())).ToList();
               
                for (int i = 0; i < findSongs.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. { findSongs [i].Name}");
                    }
            Console.WriteLine("\n ENTER SONG'S NUMBER FOR SONG DETAILS \n");
            string? pick = Console.ReadLine();

            if(int.TryParse(pick, out int chosen))
                    {
                        var song = findSongs[chosen - 1];
                        Console.WriteLine($"\n{ song.Name} by {song.Artist}, {string.Join(",", song.Tags)}, {song.Year} \n");
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT, CHOOS A VALID NUMBER FROM THE LIST");
                    }

                break;

                case "2":
                 Console.WriteLine("ENTER AN ARTIST NAME OR A PART OF THE ARTIST'S NAME");
                var find2 = Console.ReadLine();
                var findArt = songs.Where(song => song.Artist.ToLower().Contains(find2.ToLower())).ToList();
               
                for (int i = 0; i < findArt.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. { findArt [i].Name}");
                    }
            Console.WriteLine("\n ENTER SONG'S NUMBER FOR SONG DETAILS \n");
            string? pick2 = Console.ReadLine();

            if(int.TryParse(pick2, out int chosen2))
                    {
                        var song = findArt[chosen2 - 1];
                        Console.WriteLine($"\n{ song.Name} by {song.Artist}, {string.Join(",", song.Tags)}, {song.Year} \n");
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT, CHOOS A VALID NUMBER FROM THE LIST");
                    }
                break;

                case "3":
                   Console.WriteLine("ENTER AN TAG NAME OR A PART OF THE TAGS'S NAME");
                var find3 = Console.ReadLine();
                var findTag = songs.Where(song => song.Tags.Any(tag => tag.ToLower().Contains(find3.ToLower()))).ToList();
               
                for (int i = 0; i < findTag.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. { findTag [i].Name}");
                    }
            Console.WriteLine("\n ENTER SONG'S NUMBER FOR SONG DETAILS \n");
            string? pick3 = Console.ReadLine();

            if(int.TryParse(pick3, out int chosen3))
                    {
                        var song = findTag[chosen3 - 1];
                        Console.WriteLine($"\n{ song.Name} by {song.Artist}, {string.Join(",", song.Tags)}, {song.Year} \n");
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT, CHOOS A VALID NUMBER FROM THE LIST");
                    }
                break;

                case "4":
                
                Console.WriteLine("ENTER A YEAR");
                var find4 = Console.ReadLine();
                if(int.TryParse(find4, out int year4))
                    {
                    var findYear =songs.Where(song =>song.Year == year4).ToList();
                
                    for (int i = 0; i < findYear.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. { findYear [i].Name}");
                    }
                    
            Console.WriteLine("\n ENTER SONG'S NUMBER FOR SONG DETAILS \n");
            string? pick4 = Console.ReadLine();

            if(int.TryParse(pick4, out int chosen4))
                    {
                        var song = findYear[chosen4 - 1];
                        Console.WriteLine($"\n{ song.Name} by {song.Artist}, {string.Join(",", song.Tags)}, {song.Year} \n");
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT, CHOOS A VALID NUMBER FROM THE LIST");
                    }
                    }
                else
                    {
                    Console.WriteLine("INCORECT INPUT TRY AGAIN");
                    }
                break;

                default:
                Console.WriteLine("Invalid input, please try again");

                break;

            }
        }

        
    }
}

/*
        var reader = new SongReader ();
        var songs  = reader.ReadSongs("Music Info.csv");
        Console.WriteLine(songs.Count);

        var results = songs.Where( song => song.Year > 2000).ToList();
        var names   = results.Select (song => song.Name).Take(10);
        
        foreach (var name in names )
        Console.WriteLine(name);
*/