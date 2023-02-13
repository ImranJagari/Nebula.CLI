using Nebula.CLI.Core.Interfaces;
using Nebula.CLI.Core.Models;
using System.Text.RegularExpressions;

namespace Nebula.CLI.Services;

public sealed partial class SubCommandService
{
	private IDictionary<string, ISubCommand> _subCommands = new Dictionary<string, ISubCommand>();

	public SubCommandService()
	{
		Initialize();
	}

	private void Initialize()
	{
		_subCommands.Clear();
	}

	public void InvokeSubCommand(params string[] commandParameters)
	{
		if (commandParameters.Length <= 0)
		{
			//TODO: Send help documentation ?
			return;
		}

		var commandParams = GetCommandParams(commandParameters);
	}

	private static IEnumerable<CommandParam> GetCommandParams(string[] commandParameters)
	{
		foreach (var _ in from param in commandParameters
						  let matches = CommandParamRegex().Matches(param)
						  from match in matches.Cast<Match>()
						  select match)
		{
			yield return new CommandParam
			{
				ParamName = _.Groups["paramName"].Value,
				Value = _.Groups["paramValue"].Value.Trim().Trim('"'),
			};
		}
	}

	[GeneratedRegex("[\\/-]?((?<paramName>\\w+)(?:[=:](?<paramValue>\"[^\"]+\"|[^\\s\"]+))?)(?:\\s+|$)", RegexOptions.Compiled)]
	private static partial Regex CommandParamRegex();
}