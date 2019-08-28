using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Domain.Models
{
   public  class Utilisateur
    {
        public int UtilisateurID { get; set; }

        public string Nom { get; set; }

        public string Login { get; set; }

        public string MotDePasse { get; set; }


        public int FilialeID { get; set; }
        public Filiale Filiale { get; set; }





    }
}