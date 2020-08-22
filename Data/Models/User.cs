using System.Collections.Generic;

namespace Skrawl.API.Data.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public string Role { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}