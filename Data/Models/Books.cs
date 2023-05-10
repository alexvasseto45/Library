using System;
using System.Collections.Generic;

namespace Library.Data.Models
{
    public partial class Books
    {
        public Books() { }
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int UserRating { get; set; }
        public float AverageRating { get; set; }

       
    }
}
