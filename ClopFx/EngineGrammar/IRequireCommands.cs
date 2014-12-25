namespace ClopFx.EngineGrammar
{
    public interface IRequireCommands : IAddCommands
    {
        IProcessable WithAllCommands();
    }
}
