using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //varibles section
            string prompt ="> ";
            string cheer_prefix = "give me a.. ";


            Console.WriteLine("What is your name?");
            Console.Write(prompt);
           
            string user_name = Console.ReadLine(); //Read from terminal, save to variable
            
            for (int i = 0; i < user_name.Length; i++)
            {
                Console.WriteLine(cheer_prefix + user_name[i]); 
            }


            // user_name.ToUpper() is turning the user name to upper case.
            // ToUpper() is functionality specific to Strings
            // ToUpper() accepts not argumnts            
            
            // loop through the user_name array

        

            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");  

                      
            
        }
    }
}
