using System;
using System.Collections.Generic;

namespace HahaFunnyJokes.Domain
{
    public class Role
    {
        public Role()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}