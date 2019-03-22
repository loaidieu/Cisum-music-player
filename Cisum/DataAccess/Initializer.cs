using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cisum.Business;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Cisum.DataAccess
{
   public class Initializer
    {
        public static List< Playlist> allPlayLists = new List<Playlist>();

        public static Playlist GetPlaylistByName(string playlistName)
        {
            foreach (Playlist pl in allPlayLists)
            {
                if (pl.PlaylistName == playlistName)
                {
                    return pl;
                }
            }
            return null;
        }

        public static List<Playlist> LoadPlayLists(string xmlFileName)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Playlist>));
            StreamReader reader = new StreamReader(xmlFileName);
            List<Playlist> playLists = (List<Playlist>)xmlSerializer.Deserialize(reader);
            reader.Close();

            List<Playlist> tempSortedList = new List<Playlist>();
            foreach (Playlist obj in playLists)
            {
                tempSortedList.Add(obj);
            }
            return tempSortedList;
        }


        public static void SavePlayLists(string xmlFileName)
        {
            //List<Playlist> tempList = new List<Playlist>();
            //List<String> keys = (List<String>)allPlayLists.Keys;

            //foreach (string key in keys)
            //{
            //    Playlist obj = allPlayLists[key];
            //    tempList.Add(obj);
            //}

            using (var writer = XmlWriter.Create(xmlFileName))
            {
                var serializer = new XmlSerializer(typeof(List<Playlist>));
                serializer.Serialize(writer, Initializer.allPlayLists);
            }
        }
        public static bool AddPlayList(Playlist playList)
        {
            string name = playList.PlaylistName;
            for (int i = 0; i < allPlayLists.Count; i++)
            {
                if (allPlayLists[i].PlaylistName == name)
                {
                    string message = "This PlayList Name already Exists!";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
          
            }
            allPlayLists.Add(playList);
            return true;
        }
    }
}
