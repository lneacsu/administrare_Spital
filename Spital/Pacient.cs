using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spital
{
    public class Pacient :Persoana,Detalii
    {
        public String cnp { get; set; }
        public DateTime dataNasterii { get; set; }
        public float greutate { get; set; }

        public Boala boala { get; set; }
        public Medic medic { get; set; }
        public DateTime internare { get; set; }
        

        public Pacient(string id,  string nume, string prenume, string cnp, DateTime dataNasterii, float greutate, Boala boala, Medic medic, DateTime internare) :base( id,  nume,  prenume)
        {

            this.cnp = cnp;
            this.dataNasterii = dataNasterii;
            this.greutate = greutate;
            this.boala = boala;
            this.medic = medic;
            this.internare = internare;
         
        }
        
        public string afisare(Persoana a) 
        {   
            return  a.afisare()+this.cnp+" "+this.dataNasterii+" "+this.boala + "  " + this.medic + "  " + this.internare + "  "+this.greutate;
        }
    }
}
