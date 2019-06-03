using Loca.Shared.Commands;

namespace Loca.Domain.Commands.Results
{
    public class UserCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
