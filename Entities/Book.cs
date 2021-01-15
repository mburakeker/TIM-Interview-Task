using System;

namespace Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string IsbnId { get; set; }
        public string CurrentHolder { get; set; }
    }
}
