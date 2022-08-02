using System;

namespace Helper
{
    public class User
    { 
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public User(string name, string mail, string password, string age, string dateOfBirth, string gender)
        {
            Name = name;
            Mail = mail;
            Password = password;
            Age = age;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
    }
}