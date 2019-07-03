using System;
namespace HahaFunnyJokes.Domain.Entities
{
    public class Joke
    {
        public Joke()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }


    }
}
