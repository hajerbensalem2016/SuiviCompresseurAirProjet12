using MicroRabbit.GestionFournisseur.Data.Context;
using MicroRabbit.GestionFournisseur.Domain.Interfaces;
using MicroRabbit.GestionFournisseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Data.Repository
{
    public class FournisseurRepository : IFournisseurRepository
    {
        private FournisseurDbContext _db;

        public FournisseurRepository(FournisseurDbContext db)
        {
            _db = db;
        }

        public void AddF(Fournisseur fournisseur)
        {
            _db.Fournisseurs.Add(fournisseur);
            _db.SaveChanges();
        }


        public IEnumerable<Fournisseur> GetFournisseurs()
        {
            return _db.Fournisseurs;
        }
    }
}
