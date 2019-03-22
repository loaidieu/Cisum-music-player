using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cisum.Business
{
    [Serializable()]
    public class Playlist 
    {
        private string playlistName;
        private List<string> songPaths;
        public void AddSongToPlaylist(string songPath)
        {
            songPaths.Add(songPath);
        }
        public List<string> SongPaths { get => songPaths; }
        public string PlaylistName { get => playlistName; set => playlistName = value; }

        public Playlist(string name)
        {
            this.playlistName = name;
            this.songPaths = new List<string>();
        }

        public Playlist()
        {
            this.playlistName = "Default name";
            this.songPaths = new List<string>();
        }

        public int Count()
        {
            return this.songPaths.Count();
        }
    }
}
