using System;

namespace EmployeeDirectoryNET20
{
    //Static class cant make instances of. Exactly as the Console class for example
    internal static class Util
    {
        //must be static in a static class
        //string return type
        //AskForString method name
        internal static string AskForString(string prompt)
        {
            bool success = false;
            string answer; //Scope

            do //Repeat
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                //If answer is not null or empty string
                if (!string.IsNullOrEmpty(answer))
                {
                    //Set bool success to true to exit loop
                    success = true;
                }

            } while (!success); //until we have get a correct value

            return answer; //return value
        }

        internal static int AskForInt(string prompt)
        {
            bool success = false;
            int answer; //Scope

            do //Repeat
            {
                //Try to parse string to int returns bool
                //If true exit loop
                string input = AskForString(prompt);

                success = int.TryParse(input, out answer);
                if (!success) 
                    Console.WriteLine("Wrong format"); //Write error message

            } while (!success);

            //Returns parsed string
            return answer;
        }
    }
}