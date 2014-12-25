using ClopFx.Demo.Commands;

namespace ClopFx.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Engine.CreateNew()
                .WithCommand<PrintLogonName>()
                .Process(args);
        }
    }
}
