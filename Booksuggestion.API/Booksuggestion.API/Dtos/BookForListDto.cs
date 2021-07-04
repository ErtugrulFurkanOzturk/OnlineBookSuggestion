using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksuggestion.API.Dtos
{
    public class BookForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

    }
}
