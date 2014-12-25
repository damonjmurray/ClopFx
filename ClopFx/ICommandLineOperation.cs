namespace ClopFx
{
    public interface ICommandLineOperation
    {
        string Name { get; }
        string CommandArgument { get; }
        string Description { get; }

        void Execute(string[] args);
        OperationHelp GetOperationHelp();
    }
}
