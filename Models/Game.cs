using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreSqlDb.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Engineer { get; set; }
        public string Link { get; set; }
    }
}
