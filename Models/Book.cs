using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onliga.Models
{
    public class Book
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$"), Required, StringLength(30, MinimumLength = 3)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; }
    }
}