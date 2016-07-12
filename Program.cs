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
            string cheer_prefix = "give me a"; //uncomment for the second commented code
            string requires_an = "aeiolnfshrmx";

            Console.WriteLine("What is your name?");
            Console.Write(prompt);
           
            string user_name = Console.ReadLine().ToLower(); //Read from terminal, save to variable
            
            // loop through the user_name array
            /*for (int i = 0; i < user_name.Length; i++)
            {
             string cheer_prefix = "give me a"; //resets the cheer_prefix variable every iteration through for loop
            if (requires_an.IndexOf(user_name[i])> -1 )
                { //then it's in the requires_an array
                    cheer_prefix += "n";
                }
                   Console.WriteLine(cheer_prefix + ".. " + user_name[i].ToString() );  
                }
            */
                //implicit conversion
            for (int i = 0; i < user_name.Length; i++)
            {
                if (requires_an.Contains(user_name[i]))
                {
                    Console.WriteLine(cheer_prefix  + "n" + ".. " + user_name[i]);
                }else
                {
                    Console.WriteLine(cheer_prefix + ".. " + user_name[i]);
                }
            }


            /*
            for (int i = 0; i < user_name.Length; i++)
            {
                if (requires_an.IndexOf(user_name[i])> -1 )
                { //then it's in the requires_an array
                    Console.WriteLine(cheer_prefix  + "n" + ".. " + user_name[i].ToString() ); 
                } else
                { // does not require and "an"
                   Console.WriteLine(cheer_prefix + ".. " + user_name[i].ToString() );  
                }
                
            }
            */

            // user_name.ToUpper() is turning the user name to upper case.
            // ToUpper() is functionality specific to Strings
            // ToUpper() accepts not argumnts            
            
            

        

            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");  

                      
            
        }
    }
}
