
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spital
{
   public class Medic:Persoana,Detalii
    {
        public String departament { get; set; }

        public Medic(string id,string nume, string prenume,string departament) :base(id,nume,prenume) {
       
            this.departament = departament;
        }       
        public string afisare(Persoana a)
        {
            return a.afisare()  + "  " + this.departament;
        }

    }
   

}

