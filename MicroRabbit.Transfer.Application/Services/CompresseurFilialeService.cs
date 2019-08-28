using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Data.Repository;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Services
{
    public class CompresseurFilialeService : ICompresseurFilialeService
    {
        private readonly ICompresseurFilialeRepository _compresseurFilialeRepository;

    public CompresseurFilialeService(ICompresseurFilialeRepository compresseurFilialeRepository)
    {
            _compresseurFilialeRepository = compresseurFilialeRepository;
        
    }

        public IEnumerable<CompresseurFiliale> GetCompresseursFiliales()
        {
            return _compresseurFilialeRepository.GetCompresseursFiliales();
        }

     
}
}
