
public class Program
{
    public static void Main (string[] args)
    {
        var reader = new SongReader ();
        var songs  = reader.ReadSongs("Music Info.csv");
        Console.WriteLine(songs.Count);

        var results = songs.Where( song => song.Year > 2000).ToList();
        var names   = results.Select (song => song.Name).Take(10);
        
        foreach (var name in names )
        Console.WriteLine(name);

        
    }
}