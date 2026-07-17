public class SongView
{

static public void ShowResults(List<Song> result)
{
    for (int i = 0; i < result.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. { result [i].Name}");
                    }
            Console.WriteLine("\n ENTER SONG'S NUMBER FOR SONG DETAILS \n");
            string? pick = Console.ReadLine();

            if(int.TryParse(pick, out int chosen))
                    {
                        var song = result[chosen - 1];
                        Console.WriteLine($"\n{ song.Name} by {song.Artist}, {string.Join(",", song.Tags)}, {song.Year} \n");
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT, CHOOS A VALID NUMBER FROM THE LIST");
                    }

}
}