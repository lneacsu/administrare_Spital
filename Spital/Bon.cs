using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spital
{
    public class Bon
    {
        String codBon { get; set; }
        int pret { get; set; }
        Pacient cnp { get; set; }
        Boala cod { get; set; }

        public Bon(string codBon,int pret,Pacient cnp,Boala cod) {
            this.codBon = codBon;
            this.pret = pret;
            this.cnp = cnp;
            this.cod = cod;
        }

        public Bon(Boala cod,int pret)
        {
            this.cod = cod;
            this.pret = pret;
        }

        public float totalPlata() {
            return pret * Convert.ToInt32(this.cod.durataInernare);
        }
    }
}
