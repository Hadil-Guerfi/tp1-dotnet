using System;

namespace TP1
{
    class Eleve//le nom de la classe doit commencer par une lettre majuscule, on doit aussi modifier le nom du constructeur (même nom que la classe)
    {
        private string nom;//attribut d'instance (propre à l'instance)
        private int niveau;//attribut d'instance (propre à l'instance)
        public int nbEleve;//attribut d'instance (propre à l'instance)
        public Eleve(string nom, int niveau) : base()//le principe fondamental est l'héritage, dans ce cas notre classe hérite de la classe Object
        {
            this.nom = nom;
            this.niveau = niveau;
            nbEleve++;//c'est pour incrémenter l'attribut nbEleve, il sera initialisé par 1 pour chaque instance
        }
        public Eleve() : this("Anonyme", 0) { }//c'est un constructeur qui utilise un autre constructeur dont les paramètres acceptent "Anonyme", 0
        //il est utilisé comme constructeur par défaut
        String setNiveauGetNom(int niv) { //il faut modifier le nom de la méthode
            niveau = niv;//cette instruction réagit comme un setter pour l'attribut niveau 
            return this.nom;//cette instruction réagit comme un getter pour l'attribut nom
        }
        public void setNiveau(int niveau) { this.niveau = niveau; }
        public string getNom() { return nom; }
        //redéfinition de ToString c'est un override de la méthode ToString qui est déclenchée automatiquement lors de l'affichage d'une instance de cette classe
        public override String ToString()//la méthode ToString s'écrit avec un T majuscule
        { return "Eleve " + nbEleve + " " + nom + " niveau " + niveau; }
    }
    internal class Program
    {
        static void Main(string [] args)//la méthode Main s'écrit avec un M majuscule et elle reçoit comme paramètre un tableau de string
        {
            Eleve e1 = new Eleve("Ahmed", 5);
            Console.WriteLine(e1);
            Eleve e2, e3 = e1;//e3 fait référence au même objet que la variable e1, e3 et e1 pointent vers le même objet en mémoire.
            e1 = new Eleve();
            e2 = new Eleve("Ines",2);
            Console.WriteLine(e1+"\n"+e2+"\n"+e3);
            //on a e1 = new Eleve(); le constructeur par défaut est appelé d'où les valeurs Anonyme et 0
            //on a e2 = new Eleve("Ines",2); d'où les valeurs Ines et 2
            //on a e3=e1; avant que e1 = new Eleve(); d'où elle contient les valeurs initiales de e1 c'est-à-dire Ahmed et 5
            Console.ReadLine();
            return;
        }
    }
}
