using MicroRabbit.Gestion.Responsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Aplication.Interfaces
{
    public interface IUtilisateureService
    {
        IEnumerable<Utilisateur> GetUtilisateurs();

        Utilisateur GetUtilisateur(int id);

        int PostUtilisateur(Utilisateur utilisateur);

        int PutUtilisateur(int id, Utilisateur utilisateur);

        bool DeleteUtilisateur(int id);


    }
}