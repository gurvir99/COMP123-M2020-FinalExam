using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_M2020_FinalExam
{
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }
        
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        

        public Character (string first_name="", string last_name="", string strength="", string dexterity="", string constitution="",
            string intelligence="", string wisdom="", string charisma="", string race="")
        {
            this.FirstName = first_name;
            this.LastName = last_name;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Constitution = constitution;
            this.Intelligence = intelligence;
            this.Wisdom = wisdom;
            this.Charisma = charisma;
            this.Race = race;
        }
    }
}