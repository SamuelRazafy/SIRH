using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_bienvenue
{
    class Employe
    {
        public string statutMatrimonial { get; set; }
        public string sexe { get; set; }
        public string adresse { get; set; }
        public string mobile { get; set; }
        public string telephone { get; set; }
        public string nationalite { get; set; }
        public string numCIN { get; set; }
        public string nombreEnfant { get; set; }
        public string dateNaissance { get; set; }
        public string dateEntree { get; set; }
        public string dateSortie { get; set; }
        
       

        public Employe(string statutMatrimonial, string sexe, string adresse, string mobile, string telephone, string nationalite, string numCIN,string nombreEnfant, string dateNaissance, string dateEntree, string dateSortie)
        {
            this.statutMatrimonial = statutMatrimonial;
            this.sexe = sexe;
            this.adresse = adresse;
            this.mobile = mobile;
            this.telephone = telephone;
            this.nationalite = nationalite;
            this.numCIN = numCIN;
            this.nombreEnfant = nombreEnfant;
            this.dateNaissance = dateNaissance;
            this.dateEntree = dateEntree;
            this.dateSortie = dateSortie;
            
           


        }
    }
}
