using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linQ_next_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1


            List<BankAccount> list = new List<BankAccount>()
            {
                new BankAccount() { Name = "Saba" , Lastname = "Gogichaishvili" , AccountNumber = 00001 , Balance = 30000    } , 
                new BankAccount() { Name = "Zuka" , Lastname = "Arevazde" , AccountNumber = 00002 , Balance = 743    } ,
                new BankAccount() { Name = "Saba" , Lastname = "Burduli" , AccountNumber = 00003 , Balance = 134789    } ,


            }; 


            foreach (var item in list) 
                Console.WriteLine($"Name : {item.Name} - lastname : {item.Lastname}  -  AccountNumber : {item.AccountNumber}  -   Balance : {item.Balance}  ");
            




        }

        public class BankAccount {
            public string Name { get; set; }
            public string Lastname { get; set; }
            public int AccountNumber { get; set; }
            public int Balance { get; set; }

        }

    }
}
