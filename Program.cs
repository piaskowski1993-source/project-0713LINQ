
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
            Console.WriteLine("\n ENTER FULL SONG NAME FOR SONG DETAILS \n");
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
                break;

                case "3":
                break;

                case "4":
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