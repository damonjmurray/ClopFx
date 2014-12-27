namespace ClopFx
{
    public class OperationHelp
    {
        private readonly ICommandLineOperation _operation;
        private readonly string _usageExample;

        public OperationHelp(ICommandLineOperation operation, string usageExample)
        {
            _operation = operation;
            _usageExample = usageExample;
        }

        public string GetHelpString()
        {
            var commandSwitch = string.Concat(Globals.CommandSwitch, _operation.CommandArgument);
            return string.Format("\t{0}\t{1} : {2}\n\t\t{3}",
                commandSwitch,
                _operation.Name,
                _operation.Description,
                _usageExample);
        }
    }
}
