using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Services
{
    public class FilialeDupService : IFilialeDupService
    {
        private readonly IFilialeDupRepository _filialeDupRepository;
        private readonly IEventBus _bus;
        public FilialeDupService(IFilialeDupRepository filialeDupRepository, IEventBus bus)
        {
            _filialeDupRepository = filialeDupRepository;
            _bus = bus;
        }


        public IEnumerable<FilialeDup> GetFilialesDup()
        {
            return _filialeDupRepository.GetFilialesDup();
        }
    }
}