namespace ClopFx.EngineGrammar
{
    public interface IAddCommands
    {
        ICanBeProcessed WithCommand<T>() where T : ICommandLineOperation, new();
    }
}
