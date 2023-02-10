using NebulaCLI.Core;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace NebulaCLI.Services;

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
        foreach (var param in commandParameters)
        {
            var matches = CommandParamRegex().Matches(param);
        }
    }

    [GeneratedRegex("[\\/-]?((?<paramName>\\w+)(?:[=:](?<paramValue>\"[^\"]+\"|[^\\s\"]+))?)(?:\\s+|$)", RegexOptions.Compiled)]
    private static partial Regex CommandParamRegex();
}
