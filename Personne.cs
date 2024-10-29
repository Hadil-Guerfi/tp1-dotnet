using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private int telephone;
        public Personne() { }
        public Personne(string nom, string prenom, int age, int telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.telephone = telephone;
        }
        public Personne(Personne p)
        {
            this.nom = p.nom;
            this.prenom = p.prenom;
            this.age = p.age;
            this.telephone = p.telephone;
        }
        public string getNom()
        {
            return nom;
        }
        public void setNom(string nom) {  this.nom = nom; }
    }
}
