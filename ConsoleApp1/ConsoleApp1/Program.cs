using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailVerification
{
    class Program
    {

        
        public static void Main(string[] args)
        {
            //getting email from user
            Console.Write("Write your e-mail: ");
            string email = askForEmail();

            
            while (checkIfEmailIsValid(email) == false)
            {
                Console.WriteLine("Your email is not valid, please reinsert.");
                //asks user again for the email (now a valid one)
                email = askForEmail();
            }

            //tells user that the email is now valid
            Console.WriteLine("Your email is now valid.");
            

            Console.ReadKey();
           
        }

        public static bool checkIfEmailIsValid(string email)
        {
            //doing verifications, still needs to check if there are letters after the '.' and before.
            //missing special char verification
            if (email.Contains('@') != true | email.Contains('.') != true | email.Contains(' ') == true)
            {
                return false;
            }
            return true;
        }

        public static string askForEmail()
        {
            Console.Write("Write your e-mail: ");
            string email = Console.ReadLine();
            return email;
        }

    }
}
