using System;
using System.Security.Principal;

namespace ClopFx.Demo.Commands
{
    public class PrintLogonName : ICommandLineOperation
    {
        public string Name
        {
            get { return "Print Logon Name"; }
        }

        public string CommandArgument
        {
            get { return "pln"; }
        }

        public string Description
        {
            get { return "Prints the users Windows logon name to the console window"; }
        }

        public void Execute(string[] args)
        {
            var user = WindowsIdentity.GetCurrent() == null
                ? "unknown"
                : WindowsIdentity.GetCurrent().Name;

            Console.WriteLine(user);
        }
        
        public OperationHelp GetOperationHelp()
        {
            return new OperationHelp(this);
        }
    }
}
