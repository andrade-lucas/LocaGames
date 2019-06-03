using Loca.Domain.Commands.Inputs;
using Loca.Domain.Repositories;
using Loca.Domain.ValueObjects;
using Loca.Shared.Commands;
using System;

namespace Loca.Domain.Commands.Handlers
{
    public class UserHandler : ICommandHandler<UserCreateCommand>
    {
        private readonly IUserRepository _repository;

        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handler(ICommand command)
        {
            //Name name = new Name(command)
            throw new NotImplementedException();
        }
    }
}
