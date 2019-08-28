
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Interfaces

{
    public interface IFilialeDupService
    {
        IEnumerable<FilialeDup> GetFilialesDup();
      
    }
}