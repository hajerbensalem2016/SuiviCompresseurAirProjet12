using MicroRabbit.GestionResponsable.Domain.Models;
using MicroRabbit.GestionResponsableAplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionResponsableAplication.Interfaces
{
    public interface IFilialeService
    {
        IEnumerable<Filiale> GetFiliales();
        void Transfer(FilialeEnv filialeEnv);
    }
}