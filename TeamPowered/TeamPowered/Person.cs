﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPowered
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Role { get; set; }
    }
}
