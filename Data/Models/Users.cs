using System;
using System.Collections.Generic;

namespace Library.Data.Models
{
    public partial class Users
    {
        public Users() { }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
