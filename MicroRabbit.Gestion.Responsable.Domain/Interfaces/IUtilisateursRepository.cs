using MicroRabbit.Gestion.Responsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Domain.Interfaces
{
  public   interface IUtilisateursRepository
    {
        IEnumerable<Utilisateur> GetUtilisateurs();

        Utilisateur GetUtilisateur(int id);

        int PutUtilisateur(int id, Utilisateur Utilisateur);

        int PostUtilisateur(Utilisateur utilisateur);

        bool DeleteUtilisateur(int id);
    }
}
