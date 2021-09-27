using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubCore.Domain
{
    public class Film
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Film(string id, string name, string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }
    }
}
