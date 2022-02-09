using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 elem = new Class1("Chaimae", "Elalaoui", 18);
            Class1 elem2 = new Class1("Khadija", "Elalaoui", 68);
            Class1 elem3 = new Class1("Leila", "Elalaoui", 80);

            List<Class1> groupe = new List<Class1>();

            groupe.Add(elem);
            groupe.Add(elem2);
            groupe.Add(elem3);
            /***File Name**/
            string Filename = "Content.json";
            /**Serialisation**/
            string jsonString = JsonSerializer.Serialize(groupe);

           Console.WriteLine(jsonString);
            /**Ecriture dans le fichier**/
            File.WriteAllText(Filename, jsonString);
            /**Affichage dans la console**/
            Console.WriteLine(File.ReadAllText(Filename));

            Console.WriteLine("--------------Deserialise-------------------");

            string jsond = File.ReadAllText(Filename);

            List<Class1> deserializze = JsonSerializer.Deserialize<List<Class1>>(jsond);


            foreach(Class1 c in deserializze)
            {
                c.Afficher();
            }





            Console.ReadKey();


        }
    }
}
