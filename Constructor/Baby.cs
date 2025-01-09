using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Constructor
{
    public class Baby
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }

        public Baby()//Default Constructor
        {
            Console.WriteLine("Ingaaaa\n");
            BirthDate = DateTime.Now;
        }
        public Baby(string name, string surname)// isim ve soyisim alan constructor
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("\nIngaaaa\n");
            BirthDate = DateTime.Now;
        }
    };
    
}


