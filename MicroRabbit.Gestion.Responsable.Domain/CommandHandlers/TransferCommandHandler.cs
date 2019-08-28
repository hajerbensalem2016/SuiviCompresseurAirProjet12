using MediatR;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Gestion.Responsable.Domain.Commands;
using MicroRabbit.Gestion.Responsable.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Gestion.Responsable.Domain.CommandHandlers
{
   public  class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new SendListeCreateEvent(request.FilialeID, request.Nom, request.Code));

            return Task.FromResult(true);
        }


    }
}


   