using System.Collections.Generic;

namespace HahaFunnyJokes.Domain.Entities
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        
        public List<UserHobby> UserHobbies { get; set; } 
    }
}