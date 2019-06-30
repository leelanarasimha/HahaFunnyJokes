using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HahaFunnyJokes.Domain
{
    public class Category
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedDate { get; set; }
        
        
        
        public int UserId { get; set; }
        public User User { get; set; }



        
    }
}
