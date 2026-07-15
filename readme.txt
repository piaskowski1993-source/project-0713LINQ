1.Read the CVS file from the disk
    raw lines of text downloaded from https://www.kaggle.com/datasets/undefinenull/million-song-dataset-spotify-lastfm

2.Parse each line into a song objct (List<Songs>)
    -Split into fields
    -parse year to <int>
    -built a song object

3.Collect into List<Songs>

4.Ask the user what do they want to find

5.Run LINQ queries on the list

6.Display results

Reader: CSV file into a List<Song>
ReadSongs(filepath)
songs = empty list
lines = read all lines from filepath
skip the header line < row 0 is (track_id,name,artist,spotify_preview_url,spotify_id,tags,genre,year,duration_ms,danceability,energy,key,loudness,mode,speechiness,acousticness,instrumentalness,liveness,valence,tempo,time_signature)

foreachline:
fields = ParseLine(line) 
tagList = split tags on ",", trim each one 
year Int = TryParse year

song = new Song {name, artistm, tag List, year int}
add song to songs

return song

Parseline : cutt one line into fields, respecting quotes

ParswLine(line):
fields = empty list
current = empty string
inQuotes = false

foreach character c in line:
if c is '"' flip in quotes
if c is ',' and inQuotes is false 
otherwise
add the last current to fields