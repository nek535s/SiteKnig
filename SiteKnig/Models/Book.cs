﻿namespace SiteKnig.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; }= string.Empty;
        public DateTime DatePublication { get; set; }
    }
}
