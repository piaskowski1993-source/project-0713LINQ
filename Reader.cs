public class SongReader
{

public List<Song> ReadSongs(string filepPath)
{
    var songs = new List<Song>();
    var lines = File.ReadAllLines(filepPath);

    foreach (var line in lines.Skip(1))
    {
    var fields = ParseLine(line);

    if(!int.TryParse(fields[7], out int year)) 
    continue;

    var tags = fields [5]
                .Split(',')
                .Select(tag => tag.Trim())
                .ToList();
    
    var song = new Song
    {
     Name   = fields[1],
     Artist = fields[2],
     Tags   = tags,
     Year   = year
    };
    songs.Add(song);
    }
    return songs;

    
}
public List<string> ParseLine( string line )
{
    var fields   = new List<string>();
    var current  = "";
    var inQuotes = false;
    
        foreach (char c in line )
        {
            if (c == '"')
            inQuotes = !inQuotes;
            else if ( c == ',' && !inQuotes)
        {
            fields.Add(current);
            current = "";
        }            
        
            else current += c;
        }
            fields.Add(current);
            return fields;
        
    
}
}
