using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [Required]
        [StringLength(50,MinimumLength=5,ErrorMessage ="5-50 karakter arasında giriş yapınız!")]
        public string WriterName { get; set; }

        public string WriterAbout { get; set; }
        [Required]

        public string WriterImage { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string WriterMail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string WriterPassword { get; set; }

        public bool WriterStatus { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
