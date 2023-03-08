using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Udon
{
    class Journal
    {
        string _name;
        public string Name
        {
            get { return _name != null ? _name : "JournalDefaultName"; }
            set { _name = value; }
        }

        int _foundDate;
        public  int FoundDate 
        {
            get { return _foundDate; }
            set { _foundDate = (value < 1900) ? 2000 : value; }
        }

        string _description;
        public string Description
        {
            get { return _description != null ? _description : "Just a description"; }
            set { _description = value; }
        }

        public string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber != null ? _phoneNumber : "+71234567890"; }
            set { _phoneNumber = value; }
        }

        public string _email;
        public string Email
        {
            get { return _email != null ? _email : "defaultemail@yahoo.com"; }
            set { _email = value; }
        }

        public void Print()
        {
            WriteLine($"Name: {Name}\nFoundation date: {FoundDate}\nDescription: {Description}\n" +
                $"Phone Number: {PhoneNumber}\nEmail: {Email}\n");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal jrl1 = new Journal();

            Journal jrl2 = new Journal
            {
                Name = "Best Journal",
                FoundDate = 2011,
                Description = "You`ve opened the best journal ever!",
                PhoneNumber = "+75648679167",
                Email = "bestjournal@yahoo.com"
            };

            jrl1.Print();
            jrl2.Print();
        }
    }
}