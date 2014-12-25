namespace ClopFx
{
    public class OperationHelp
    {
        private ICommandLineOperation _operation;

        public OperationHelp(ICommandLineOperation operation)
        {
            _operation = operation;
        }

        public string GetHelpString()
        {
            return Globals.CommandSwitch + "asdfasd";
        }
    }
}
