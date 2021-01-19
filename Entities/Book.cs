using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Book
    {
        [Key]
        public string IsbnId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Count { get; set; }
    }
}
