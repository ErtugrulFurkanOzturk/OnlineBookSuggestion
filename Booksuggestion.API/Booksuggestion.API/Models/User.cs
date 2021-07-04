using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksuggestion.API.Models
{
    public class User
    {
        public User()
            {
            Books = new List<Book>();
            }
        public int Id { get; set; }
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        public string Username { get; set; }
        public List<Book> Books { get; set; }
    }
}
