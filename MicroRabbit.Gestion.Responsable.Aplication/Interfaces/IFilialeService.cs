using MicroRabbit.Gestion.Responsable.Aplication.Models;
using MicroRabbit.Gestion.Responsable.Domain.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Aplication.Interfaces
{
    public interface IFilialeService
    {
        IEnumerable<Filiale> GetFiliales();
        //rabbit
        void Transfer(FilialeEnv filialeEnv);
        Filiale GetFiliale(int id);

        int PostFiliale(Filiale Filiale);

        int PutFiliale(int id, Filiale Filiale);

        bool DeleteFiliale(int id);


    }
}
   