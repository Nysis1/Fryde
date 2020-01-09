using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fryde.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public IEnumerable<Models.Music> Musics { get; set; }
    }
}
