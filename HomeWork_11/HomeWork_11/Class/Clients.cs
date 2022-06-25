using HomeWork_11.Class.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11.Class
{
    class Clients
    {

        public static int idrole;
        private string passport;
        

        public Clients()
        {
        }

        public Clients(string surname, string name, string lastname, string number, string passport)
        {
            SurName = surname;
            Name = name;
            LastName = lastname;
            Number = number;
            Passport = passport;

        }

        public string SurName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }


        public string Passport
        {
            get
            {
                if (idrole==1)
                {
                    return passport;
                }
                else
                {
                    return "********";
                }
            }

            set
            {
                passport = value;
            }
        }

        
    }
}
