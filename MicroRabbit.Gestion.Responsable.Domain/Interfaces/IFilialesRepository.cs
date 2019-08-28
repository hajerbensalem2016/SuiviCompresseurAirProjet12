using MicroRabbit.Gestion.Responsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Domain.Interfaces
{
    public interface IFilialesRepository
    {
        IEnumerable<Filiale> GetFiliales();

        void AddF(Filiale filiale);
        Filiale GetFiliale(int id);

        int PutFiliale(int id, Filiale Filiale);

        int PostFiliale(Filiale Filiale);

        bool DeleteFiliale(int id);
    }

}