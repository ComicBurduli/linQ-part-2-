using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net", "hsNameD.com", "hsNameE.org",
            //"hsNameF.org", "hsNameG.tv", "hsNameH.net", "hsNameI.tv" }. დაბეჭდეთ მხოლოდ domain სახელები
            //(.com, .net, .org და აშ);




            //string[] webites = { "hsNameA.com", "hsNameB.net", "hsNameC.net", "hsNameD.com", "hsNameE.org", "hsNameF.org", "hsNameG.tv", "hsNameH.net", "hsNameI.tv" }; 




            // var GGdomains  = from site in webites 
            //                group site by site.Split(',').Last() into Results

            //                where Results.Key == "com"
            //                //where Results.Key ==  "net"
            //                //where Results.Key ==  "org"


            //                select Results;



            //foreach (var Sdomain in GGdomains)
            //{
            //    Console.WriteLine(Sdomain.Key);


            //    foreach (var site in Sdomain)
            //        Console.Write("\t" + site);


            //}



            //Console.ReadKey();  

            string[] websites = { "hsNameA.com", "hsNameB.net", "hsNameC.net", "hsNameD.com", "hsNameE.org", "hsNameF.org", "hsNameG.tv", "hsNameH.net", "hsNameI.tv" };

            foreach (string website in websites)
            {
                string domain = website.Substring(website.LastIndexOf('.'));
                Console.WriteLine(domain);
            }


        }
    }
}
