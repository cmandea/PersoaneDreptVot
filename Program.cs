using System.IO;
using System.Xml.Linq;
namespace PersoaneDreptVot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti Numele:");
            string nume = Console.ReadLine();

            nume = nume.ToUpper();

            Console.Write("Introduceti Prenumele:");
            string prenume = Console.ReadLine();

            prenume = prenume.ToUpper();


            int varsta = CitescNumar("Introduceti varsta:");

            if (varsta >= 18) 
            {
                Console.WriteLine("Te numesti " + nume + " " + prenume + ", ai varsta de " + varsta + " ani si ai drept de vot!");
            }
            else
            {
                Console.WriteLine("Te numesti " + nume + " " + prenume + ", ai varsta de " + varsta + " ani si nu ai drept de vot!");
            }
            



        }

        static int CitescNumar(string numar)
        {
            bool fNumar = false;


            while (!fNumar)
            {
                Console.Write(numar);
                string txtRead = Console.ReadLine();
                fNumar = int.TryParse(txtRead, out int result);
                if (fNumar)
                {
                    return result;
                }
                else 
                {
                    Console.WriteLine("Textul introdus '" + txtRead + "' nu reprezinta un numar! ");
                }

            }
            return 0;
        }
       
    }
}