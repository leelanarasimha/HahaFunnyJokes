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
            Categories = new List<Category>();
        }

        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
        public int IsAdmin { get; set; }

        public List<Joke> Jokes { get; set; }
        
        public List<UserHobby> UserHobbies { get; set; }

        public List<Category> Categories { get; set; }

    }
}
