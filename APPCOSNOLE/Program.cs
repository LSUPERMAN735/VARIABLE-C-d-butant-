
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPCOSNOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un caractère svp");
            string chaine = Console.ReadLine();
            Console.WriteLine("Vous avez donné la valeur : "+ chaine);
            //Convertira la valeur contenue des chaines (string) en une valeur de type entier//
            int ValeurDeChaine = Convert.ToInt32(chaine);
            int ValeurAuCarre = ValeurDeChaine * ValeurDeChaine;
            Console.WriteLine("le carré de : " + chaine +" est égal à " + ValeurAuCarre);

            Console.Read();
        }
    }
}
