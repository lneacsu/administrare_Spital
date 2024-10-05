using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spital
{
    class DetaliiPacient 
    {
        Pacient id { get; set; }
        String numeContact { get; set; }
        String localitate { get; set; }
        String adresa { get; set; }
        String nrContact { get; set; }

        public DetaliiPacient(Pacient id,string localitate,string adresa,string numeContact,string nrContact)
        {
            this.id = id;
            this.numeContact = numeContact;
            this.localitate = localitate;
            this.adresa = adresa;
            this.nrContact = nrContact;
        }



    }
}
