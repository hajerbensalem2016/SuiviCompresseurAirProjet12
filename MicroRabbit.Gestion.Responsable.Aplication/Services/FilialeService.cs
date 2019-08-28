using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Gestion.Responsable.Aplication.Interfaces;
using MicroRabbit.Gestion.Responsable.Aplication.Models;
using MicroRabbit.Gestion.Responsable.Domain.Commands;
using MicroRabbit.Gestion.Responsable.Domain.Interfaces;
using MicroRabbit.Gestion.Responsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Aplication.Services
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

        public bool DeleteFiliale(int id)
        {
            return _filialeIRepository.DeleteFiliale(id);
        }

        public Filiale GetFiliale(int id)
        {
            return _filialeIRepository.GetFiliale(id);
        }

        public IEnumerable<Filiale> GetFiliales()
        {
            return _filialeIRepository.GetFiliales();
        }

        public int PostFiliale(Filiale filiale) => _filialeIRepository.PostFiliale(filiale);


        public int PutFiliale(int id, Filiale filiale)
        {
            return _filialeIRepository.PutFiliale(id, filiale);
        }

        //rabbit
        public void Transfer(FilialeEnv filialeEnv)
        {
            var createFilialeCommand = new CreateTransferCommand(
             filialeEnv.FilialeID,
     filialeEnv.Nom,
     filialeEnv.Code





      );
            _bus.SendCommand(createFilialeCommand);
        }

       
    }
}
