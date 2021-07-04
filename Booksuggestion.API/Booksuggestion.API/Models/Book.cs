using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksuggestion.API.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }


    }
}
