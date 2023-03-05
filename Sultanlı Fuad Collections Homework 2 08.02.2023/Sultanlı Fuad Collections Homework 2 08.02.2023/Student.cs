using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sultanlı_Fuad_Collections_Homework_2_08._02._2023
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Pin { get; set; }

        public string GetDetails()
        {
            return ($"Name : {Name} Surname : {Surname} Pin :{Pin}");
        }
    }
}
