using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spital
{
    public class Persoana
    {
        public String cod { get; set; }
       public  String nume { get; set; }
        public String prenume { get; set; }


       public Persoana(String id,  String nume, String prenume) {
            this.cod = id;         
            this.nume = nume;
            this.prenume = prenume;
        }

        public Persoana(String id, String nume)
        {
            this.cod = id;
            this.nume = nume;
            
        }


        public string afisare()
        {
            return this.cod +  "  " + this.nume + "  " + this.prenume;
        }

     
    }
}
