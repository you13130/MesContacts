using System;
using System.Drawing;

namespace MesContacts
{
    public class Contact
    {
        //Variables
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string address;
        private string city;
        private Image photo;


        // Properties

        public string FirstName { get => firstName; private set => firstName = value; }

        public string LastName { get => lastName; private set => lastName = value; }

        public string Email { get => email; private set => email = value; }

        public string PhoneNumber { get => phoneNumber; private set => phoneNumber = value; }

        public string Address { get => address; private set => address = value; }

        public string City { get => city; private set => city = value; }

        public Image Photo { get => photo; private set => photo = value; }


        //Constructors 

        public Contact()
        {


        }


        public Contact(string firstName, string lastName, string email, string phoneNumber, string address, string city, Image photo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.City = city;
            this.Photo = photo;


        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }



    }
}