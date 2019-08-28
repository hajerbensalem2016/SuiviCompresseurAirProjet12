using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Gestion.Responsable.Aplication.Interfaces;
using MicroRabbit.Gestion.Responsable.Domain.Interfaces;
using MicroRabbit.Gestion.Responsable.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Aplication.Services
{
    public class UtilisateurService : IUtilisateureService
    {
        private readonly IUtilisateursRepository _utilisateursRepository;
        private readonly IEventBus _bus;
        public UtilisateurService(IUtilisateursRepository utilisateursRepository, IEventBus bus)
        {
            _utilisateursRepository = utilisateursRepository;
            _bus = bus;
        }

        public bool DeleteUtilisateur(int id)
        {
            return _utilisateursRepository.DeleteUtilisateur(id);
        }

        public Utilisateur GetUtilisateur(int id)
        {
            return _utilisateursRepository.GetUtilisateur(id);
        }

        public IEnumerable<Utilisateur> GetUtilisateurs()
        {
            return _utilisateursRepository.GetUtilisateurs();
        }

        public int PostUtilisateur(Utilisateur utilisateur) => _utilisateursRepository.PostUtilisateur(utilisateur);

        public int PutUtilisateur(int id, Utilisateur utilisateur)
        {
            return _utilisateursRepository.PutUtilisateur(id, utilisateur);
        }
    }
}



