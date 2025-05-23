﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1_1Form
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person (string firstName, string lastName, string phoneNumber, string email, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public string ToString()
        {
            return $"{FirstName} {LastName}" + Environment.NewLine + $"Phone: {PhoneNumber}" + Environment.NewLine + $"Email: {Email}" + Environment.NewLine + $"Address: {Address}" + Environment.NewLine;
        }
    }
}
