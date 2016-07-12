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
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            string user_name = Console.ReadLine(); //Read from terminal, save to variable
            
            // user_name.ToUpper() is turning the user name to upper case.
            // ToUpper() is functionality specific to Strings
            // ToUpper() accepts not argumnts            
            
            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");  

                      
            
        }
    }
}
