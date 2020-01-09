using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fryde.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string FilePath { get; set; }
        public string ContentType { get; set; }
    }
}
