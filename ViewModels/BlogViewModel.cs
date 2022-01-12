using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogs.ViewModels
{
    public class BlogViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string BannerImageUrl { get; set; }
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        [NotMapped]
        public IEnumerable<string> Tags { get; set; }
        
    }
}