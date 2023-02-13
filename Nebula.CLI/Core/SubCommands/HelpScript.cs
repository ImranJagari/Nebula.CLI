using Nebula.CLI.Core.Attributes;
using Nebula.CLI.Core.Interfaces;
using Nebula.CLI.Core.Models;

namespace Nebula.CLI.Core.SubCommands
{
	[CommandName("help")]
	public class HelpSubCommand : ISubCommand
	{
		[Parameter(Name = "subCommand", IsOptional = true)]
		public string? SubCommandName { get; set; }

		public void Initialize()
		{
		}

		public void Handle()
		{
		}
	}
}