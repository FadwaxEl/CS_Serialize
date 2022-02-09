using System;
using System.Collections.Generic;
using System.Text;

namespace Serialisation
{
    class Class1
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }

        public Class1()
        {

        }
        public Class1(string s, string p, int a)
        {
            nom = s;
            prenom = p;
            age = a;
        }
       public  void Afficher()
        {
            Console.WriteLine($"Nom: {this.nom}");
            Console.WriteLine($"Prenom: {this.prenom}");
            Console.WriteLine($"Age: {this.age}");
        }
    }
}
