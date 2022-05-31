using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =5)]
        public string BlogTitle { get; set; }
        [Required]
        public string BlogContent { get; set; }
       
        public string ThumbNailImage { get; set; }
        [Required]
        public string Image { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
