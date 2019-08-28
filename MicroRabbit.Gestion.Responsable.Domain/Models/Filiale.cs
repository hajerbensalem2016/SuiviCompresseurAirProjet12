using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Domain.Models
{
  public   class Filiale
    {
        public int FilialeID { get; set; }

        public string Nom { get; set; }
        public string Code { get; set; }




        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }





    }
}
