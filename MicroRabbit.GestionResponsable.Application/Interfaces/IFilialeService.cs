
using MicroRabbit.GestionResponsable.Application.Models;
using MicroRabbit.GestionResponsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionResponsable.Application.Interfaces
{
    public interface IFilialeService
    {
        IEnumerable<Filiale> GetFiliales();
        void Transfer(FilialeEnv filialeEnv);
    }
}