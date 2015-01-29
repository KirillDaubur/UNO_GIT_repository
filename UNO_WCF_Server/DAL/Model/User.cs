using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public  class User
    {
        public int id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string email { get; set; }

        public string passwoed { get; set; }

        public int age { get; set; }

        public string male { get; set; }
    }
}
