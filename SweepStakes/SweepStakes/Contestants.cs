using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
   public class Contestants
    {
       string firstname;
       string lastname;
       string emailaddress;
       public int registrationnumber;
       public string result = "pending";


        public void ContestantInfo()
         {
            Console.WriteLine("What is your first name?");
            this.firstname = Console.ReadLine();
            Console.WriteLine("What is your Last name?");
            this.lastname = Console.ReadLine();
            Console.WriteLine("What is your E-mail Address?");
            this.emailaddress = Console.ReadLine();
            //.registrationnumber = registrationnumber;
        }

        



    }
}
