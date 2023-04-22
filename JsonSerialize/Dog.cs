﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialize
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }
}
