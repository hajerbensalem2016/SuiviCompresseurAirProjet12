using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Data.Repository
{
    public class CompresseurFilialeRepository : ICompresseurFilialeRepository
    {
        private CompresseurDbContext _DbContext;
        public CompresseurFilialeRepository(CompresseurDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IEnumerable<CompresseurFiliale> GetCompresseursFiliales()
        {
            return _DbContext.CompresseurFiliales;
        }
    }
}
