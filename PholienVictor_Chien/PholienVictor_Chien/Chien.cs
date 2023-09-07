using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PholienVictor_Chien
{
    class Chien
    {
        private string _nom;
        private string _race;
        private int _age;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private string _genre;
        private bool _sterilise;

        public UnChien(string nom, string race, int age, bool enOrdreDeVaccin, bool puce, string genre, bool sterilise, bool dresse)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _genre = genre;
            _sterilise = sterilise;

        }

        public string AffichageChien()
        {
            string chaine = "Nom : " + _nom + "// Race : " + _race + "Age : " + _age + " // Vaccin : " + _enOrdreDeVaccin + " // Puce : " + _puce + " // Genre : " + _genre + " // Sterilisé : " + _sterilise + " // dresse : ";
            return chaine;
        }

        public void Promener()
        {
            Console.WriteLine("Chien Promener");
        }

        public void Dresser()
        {
            Console.WriteLine("Chien Dresser");
        }

        public void Vacciner()
        {
            Console.WriteLine("Chien Vacciner");
        }
    }
}
