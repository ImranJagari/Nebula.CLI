using NebulaCLI.Models;

namespace NebulaCLI.Core; 
internal interface ISubCommand
{
    void Initialize(params CommandParam[] commandParams);
    void Handle();
}
