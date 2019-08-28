using MicroRabbit.GestionResponsable.Application.Interfaces;
using MicroRabbit.GestionResponsable.Application.Models;
using MicroRabbit.GestionResponsable.Domain.Commands;
using MicroRabbit.GestionResponsable.Domain.Interfaces;
using MicroRabbit.GestionResponsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace MicroRabbit.GestionResponsable.Application.Services
{
 
    public class FilialeService : IFilialeService
    {
        private readonly IFilialesRepository _filialeIRepository;
        private readonly IEventBus _bus;
        public FilialeService(IFilialesRepository filialeIRepository, IEventBus bus)
        {
            _filialeIRepository = filialeIRepository;
            _bus = bus;
        }
        public IEnumerable<Filiale> GetFiliales()
        {
            return _filialeIRepository.GetFiliales();
        }

     
        public void Transfer(FilialeEnv filialeEnv)
        {
            var createTransferCommand = new CreateTransferCommand(
     filialeEnv.Nom,
     filialeEnv.Code





      );
            _bus.SendCommand(createTransferCommand);
        }
    }
}
