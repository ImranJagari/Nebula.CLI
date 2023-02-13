using Nebula.CLI.Core.Attributes;
using Nebula.CLI.Core.Interfaces;
using Nebula.CLI.Core.Models;

namespace Nebula.CLI.Scripts
{
    public class HelpCommandScript : ISubCommand
    {
        [Parameter<string>("commandName", "all")]
        public string SubCommandName { get; set; } = string.Empty;

        public void Initialize(params CommandParam[] commandParams)
        {
        }

        public void Handle()
        {
            throw new NotImplementedException();
        }
    }
}