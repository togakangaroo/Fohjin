using Fohjin.DDD.Commands;
using Fohjin.DDD.Domain.Client;
using Fohjin.DDD.EventStore;

namespace Fohjin.DDD.CommandHandlers
{
    public class ChangeClientNameCommandHandler : ICommandHandler<ChangeClientNameCommand>
    {
        private readonly IDomainRepository _repository;

        public ChangeClientNameCommandHandler(IDomainRepository repository)
        {
            _repository = repository;
        }

        public void Execute(ChangeClientNameCommand compensatingCommand)
        {
            var client = _repository.GetById<Client>(compensatingCommand.Id);

            client.UpdateClientName(new ClientName(compensatingCommand.ClientName));
        }
    }
}