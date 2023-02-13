using Nebula.CLI.Core.Attributes;
using Nebula.CLI.Core.Interfaces;
using Nebula.CLI.Core.Models;

namespace Nebula.CLI.Scripts
{
	public class HelpCommandScript : ISubCommand
	{
		[Parameter(Name = "commandName")]
		public string SubCommandName { get; set; } = string.Empty;

		public void Initialize()
		{
		}

		public void Handle()
		{
		}
	}
}