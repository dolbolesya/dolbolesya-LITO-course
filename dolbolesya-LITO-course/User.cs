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
        public bool isAdmin = false;

        public string? name;
        public uint age;
        public string? profession;    
        private uint _salary { get; set; }


        public void Me()
        {
            Console.Clear();
            Console.WriteLine(
                $"isAdmin: {isAdmin} \n" +
                $"id: {id}\n" +
                $"\n" +
                $"name: {name}\n" +
                $"age: {age}\n" +
                $"\n" +
                $"profession: {profession}\n" +
                $"salary: {_salary}\n"
                );
        }
    }
}
