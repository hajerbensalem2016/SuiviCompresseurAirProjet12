using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.GestionCompresseur.Domain.Events;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.GestionCompresseur.Domain.EventHandlers
{
    public class FilialeEventHandler : IEventHandler<SendListeCreateEvent>
    {
        private readonly IFilialeDupRepository _filialeDupRepository;
        public FilialeEventHandler(IFilialeDupRepository filialeDupRepository )
        {
            _filialeDupRepository = filialeDupRepository;
        }
        public Task Handle(SendListeCreateEvent @event)
        {
            _filialeDupRepository.Add(new FilialeDup()
            {

                FilialeID = @event.FilialeID,
                Nom = "rached",
                Code = @event.Code
            });
            return Task.CompletedTask;
        }
    }
}
