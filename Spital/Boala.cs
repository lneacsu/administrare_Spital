using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spital
{
    public class Boala
    {
        private int v;

        public String codBoala { get; set; }
        public String numeBoala { get; set; }

        public String durataInernare { get; set; }

        public Boala(string codBoala,string numeBoala,String durata){
            this.codBoala = codBoala;
            this.numeBoala = numeBoala;
            this.durataInernare = durata;
        }

        public Boala(String durata)
        {
            this.durataInernare = durata;
        }

        public String afisare() {
            return this.codBoala+" ";
        }
    }
}
