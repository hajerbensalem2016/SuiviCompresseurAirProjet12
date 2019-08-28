using MicroRabbit.GestionResponsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.GestionResponsable.Domain.Interfaces
{
    public interface IUtilisateursRepository
    {
        IEnumerable<Utilisateur> GetUtilisateurs();

        Utilisateur GetUtilisateur(int id);

        int PutUtilisateur(int id, Utilisateur Utilisateur);

        int PostUtilisateur(Utilisateur utilisateur);

        bool DeleteUtilisateur(int id);
    }
}
