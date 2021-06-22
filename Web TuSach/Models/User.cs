using System.ComponentModel.DataAnnotations;

namespace TuSach.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int UserID { get; set; }

        [Required, StringLength(100)]
        public string UserName { get; set; }

       [Required, StringLength(15)]
       public string Password { get; set; }
       

    }
}