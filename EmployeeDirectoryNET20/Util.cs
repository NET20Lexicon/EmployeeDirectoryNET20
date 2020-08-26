using System;

namespace EmployeeDirectoryNET20
{
    internal static class Util
    {
        internal static string AskForString(string prompt)
        {
            bool success = false;
            string answer;

            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        internal static int AskForInt(string prompt)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(prompt);

                success = int.TryParse(input, out answer);
                if (!success) Console.WriteLine("Wrong format");

            } while (!success);

            return answer;
        }
    }
}