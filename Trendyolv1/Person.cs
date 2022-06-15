using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyolv1
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public List<string> Phones { get; set; }
        public List<int> Numbers { get; set; }
        public string[] Address { get; set; }
        public string Gender { get; set; }
    }
}
