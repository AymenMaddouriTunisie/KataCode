using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataCode.ImplClass;

namespace KataCode
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Out.WriteLine("Veuillez Entrez un entier :");
            string ligne = Console.In.ReadLine();
           
           
            try
            {
                KataCodeImpl kataCodeImpl = new KataCodeImpl();
                Console.WriteLine(kataCodeImpl.compute(ligne) 
                   + "\n" 
                   + "\n" 
                   + "\n"
                   + "\n"
                   + "\n" 
                   + "-------------------------------------------------------------" 
                   + "\n" + "Développer par Aymen Maddouri , le " 
                   + DateTime.Now.ToString() 
                   + "\n" 
                   + "-------------------------------------------------------------");                                         
                Console.ReadKey();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();

            }


        }
    }
}
