using System.Collections.Generic;

namespace HahaFunnyJokes.Domain
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<UserHobby> UserHobbies { get; set; } 
    }
}