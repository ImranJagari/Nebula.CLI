using Nebula.CLI.Core.Models;

namespace Nebula.CLI.Core.Interfaces;

public interface ISubCommand
{
	void Initialize();

	void Handle();
}