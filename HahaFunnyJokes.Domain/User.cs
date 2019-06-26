using System;
using System.Collections.Generic;

namespace HahaFunnyJokes.Domain
{
    public class User
    {
        public User()
        {
            Jokes = new List<Joke>();
            UserHobbies = new List<UserHobby>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public List<Joke> Jokes { get; set; }
        
        public List<UserHobby> UserHobbies { get; set; }
    }
}
