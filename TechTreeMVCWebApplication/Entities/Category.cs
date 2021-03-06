using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVCWebApplication.Entities
{
    public class Category
    {
        public int Id{ get; set; }

        [Required]
        [StringLength(200,MinimumLength = 2)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string ThumbnailImagePath { get; set; }

        //here i provide Foreign key to CategoryItem Table
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        //here i provide Foreign Key to UserCategory
        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }

}
