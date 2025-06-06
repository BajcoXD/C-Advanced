﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entities.Models
{
    public class User
    {
        public User(int id, string name, int age) 
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name}, Age: {Age}";
        }

    }
}
