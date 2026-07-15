public class Song
{
    public required string Name { get; set; }
    public required string Artist { get; set; }

    public required List <string> Tags { get; set; }

    public int Year { get; set; }
}
