﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_5
{
    internal struct Person
    {
        public int Age {  get; set; }
        public string Name { get; set; }

        public Person (int age , string name)
        {
            Age = age;
            Name = name;
        }
        public override string ToString()
        {
            return $"age = {Age} name = {Name}";
        }
    }
}
