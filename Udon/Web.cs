using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Udon
{
    class Web
    {
        static string _name;
        public static string Name
        {
            get { return _name != null ? _name : "Just a website";}
            set { _name = value; }
        }

        static string _url;
        public static string URL
        {
            get { return _url != null ? _url : "https://github.com/ChocoChocobo"; }
            set { _url = value; }
        }

        static string _description;
        public static string Description
        {
            get { return _description != null ? _description : "You should`ve entered description!!!"; }
            set { _description = value; }
        }

        static string _ip;
        public static string IP
        {
            get { return _ip != null ? _ip : "8.8.8.8"; }
            set { _ip = value; }
        }

        public void Print()
        {
            WriteLine($"Website name: {Name}\nURL: {URL}\nDescription: {Description}\nIP: {IP}\n");
        }
    }

    internal class Website
    {
        static void Main(string[] args)
        {
            /*Web website1 = new Web();

            Web website2 = new Web
            {
                Name = "Primitive server",
                URL = "myserver.com",
                Description = "Using props",
                IP = "8.8.8.8"
            };
            website1.Print();
            website2.Print();*/

            WriteLine("Welcome to \"Primitive site builder v1!\"");
            Web website = new Web();
            Write("Name of your website: ");
            Web.Name = ReadLine();
            Write("URL of your website: ");
            Web.URL = ReadLine();
            Write("Description of your website: ");
            Web.Description= ReadLine();
            Write("IP: ");
            Web.IP = ReadLine();
            Write("\n");

            WriteLine("Here is your website!");
            website.Print();

       
        }
    }
}
