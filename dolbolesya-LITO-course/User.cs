using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolbolesya_LITO_course
{
    class User
    {
        public uint id;
        public string? name
        {
            get { return name; }
            set { name = value; }   
        }
        public int age;

        public string? profession;
        private int salary { get; set; }


    }
}
