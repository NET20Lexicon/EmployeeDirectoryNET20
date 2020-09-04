using System;

namespace EmployeeDirectoryNET20
{
    internal class StrartUp
    {
        internal IUI GetUI()
        {
            return new ConsoleUI();
        }
    }
}