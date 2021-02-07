using System;
using System.Collections.Generic;
using System.Text;

namespace Episode2
{
    public class User
    {
        public string  Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        //add construtor caused that email and password is required to create user
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is incorrect.");
            }
            if (Email==email)
            {
                return;
            }
            Email = email;
            Update();
        }
        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password is incorrect.");
            }
            if (Password == password)
            {
                return;
            }
            Password = password;
            Update();
            
        }

        public void SetFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new Exception("FirstName is incorrect.");
            }
            if (FirstName == firstName)
            {
                return;
            }
            FirstName = firstName;
            Update();

        }
        public void SetLasttName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("LastName is incorrect.");
            }
            if (LastName == lastName)
            {
                return;
            }
            LastName = lastName;
            Update();

        }
        public void SetAge(int age)
        {
            if (age < 13)
            {
                throw new Exception("Age must be reater or equal to 14.");
            }
            if(Age==age)
            {
                return;
            }
            Age = age;
            Update();
        }

        public void Activate()
        {

            if (IsActive)
            {
                return;
            }
            IsActive = true;
            Update();
        }
        public void Dectivate()
        {

            if (!IsActive)
            {
                return;
            }
            IsActive = false;
            Update();
        }

        private void Update() 
        {
            UpdatedAt = DateTime.UtcNow;
        }

           


    }
}
