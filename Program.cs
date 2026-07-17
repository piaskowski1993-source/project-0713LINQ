
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
                SongView.ShowResults(findSongs);
                break;

                case "2":
                 Console.WriteLine("ENTER AN ARTIST NAME OR A PART OF THE ARTIST'S NAME");
                var find2 = Console.ReadLine();
                var findArt = songs.Where(song => song.Artist.ToLower().Contains(find2.ToLower())).ToList();
                SongView.ShowResults(findArt);
                break;

                case "3":
                   Console.WriteLine("ENTER AN TAG NAME OR A PART OF THE TAGS'S NAME");
                var find3 = Console.ReadLine();
                var findTag = songs.Where(song => song.Tags.Any(tag => tag.ToLower().Contains(find3.ToLower()))).ToList();
                SongView.ShowResults(findTag);
                break;

                case "4":
                
                Console.WriteLine("ENTER A YEAR");
                var find4 = Console.ReadLine();
                if(int.TryParse(find4, out int year4))
                    {
                    var findYear =songs.Where(song =>song.Year == year4).ToList();
                    SongView.ShowResults(findYear);
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