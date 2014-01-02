﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Angela.Tests
{
    internal class Person
    {
        private string _middleName
            ;
        // firstname FirstName fname first_name
        public string FirstName { get; set; }

        // lastname LastName lname last_name
        public string LastName { get; set; }

        // word
        public string Title { get; set; }

        // age
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public int NumberOfKids { get; set; }


        // emailaddress EmailAddress email_address
        public string EmailAddress { get; set; }

        public string Twitter { get; set; }

        // phonenumber PhoneNumber phone_number
        public string PhoneNumber { get; set; }

        // decimal
        public decimal HeightInMetres { get; set; }

        public void SetMiddleName(string middleName)
        {
            _middleName = middleName;
        }

        public string GetMiddleName()
        {
            return _middleName;
        }

    }
}
