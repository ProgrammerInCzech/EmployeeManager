using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    class Employee
    {
        /*
         * Proměnné jsem si dal všechny public proto, abych s nimi mohl dále pracovat
         */

        public string Name;
        public string Surname;
        public string Title;
        
        /*
         * This slouží k tomu, abych poukázal na aktuální třídu
         * Konstruktor je zde, aby mě to nutilo zadat všechny informace nejen ty, co chci
         */
        
        public Employee(string Name, string Surname, string Title)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Title = Title;
        }
        
    }
    class Developer:Employee
    {
        public string EmployeeLevel;
        public Developer(string EmployeeLevel, string Name, string Surname, string Title) : base(Name, Surname, Title)
        {
            this.EmployeeLevel = EmployeeLevel;
        }

        /*
         * Zde se vyskytl problém, kde jsem nedokázal přijít na to jak z returnu dostat hodnotu zpět do Form1.cs
         * VYŘEŠENO díky dokumentaci https://docs.microsoft.com/cs-cz/dotnet/csharp/programming-guide/classes-and-structs/methods
        */

        public virtual string Level(string Lvl)
        {
            float Money = 30000;
            if (Lvl == "Junior")
            {
                Money = 30000 * 1;
            }
            if (Lvl == "Middle")
            {
                Money = Money * 2 * 1.1f;
            }
            if (Lvl == "Senior")
            {
                Money = Money * 3 * 1.4f;
            }
            if (Lvl == "")
            {
                Money = 0;
            }
            return Money.ToString();
        }
        


    }
    class Administrators:Developer
    {
        public Administrators(string EmployeeLevel, string Name, string Surname, string Title) :base(EmployeeLevel, Name, Surname, Title)
        {

        }

        public override string Level(string Lvl)
        {
            float Money = 28000;
            if (Lvl == "Junior")
            {
                Money = 28000 * 1;
            }
            if (Lvl == "Middle")
            {
                Money = Money * 1.5f * 1.1f;
            }
            if (Lvl == "Senior")
            {
                Money = Money * 2 * 1.4f;
            }
            if(Lvl == "")
            {
                Money = 0;
            }

            return Money.ToString();
        }

    }
    class ITandOthers:Employee
    {
        public ITandOthers(string Name, string Surname, string Title) :base( Name,Surname,Title)
        {
            
        }
        public void Money()
        {
            int value = 35000;
        }
      
    }
}
