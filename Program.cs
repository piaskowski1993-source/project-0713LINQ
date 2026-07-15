
public class Program
{
    public static void Main (string[] args)
    {
        var reader = new SongReader ();
        var songs  = reader.ReadSongs("Music Info.csv");
        Console.WriteLine(songs.Count);
    }
}