using System.ComponentModel.DataAnnotations;

namespace TuSach.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]


        public int BookID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string BookName { get; set; }

        [Required, StringLength(10000), Display(Name = "Book Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}