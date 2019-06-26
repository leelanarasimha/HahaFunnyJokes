using System;
namespace HahaFunnyJokes.Domain
{
    public class Joke
    {
        public Joke()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
