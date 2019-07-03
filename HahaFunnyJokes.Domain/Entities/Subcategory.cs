using System;
using System.Collections.Generic;
using System.Text;

namespace HahaFunnyJokes.Domain.Entities
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedDate { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

    }
}
