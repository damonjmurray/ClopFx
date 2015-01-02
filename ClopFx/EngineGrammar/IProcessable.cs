using System.IO;

namespace ClopFx.EngineGrammar
{
    public interface IProcessable
    {
        IProcessable OutputTo(TextWriter outputTarget);
        ProcessResult Process(string[] args);
    }
}
