using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Aplication.Models
{
   public  class FilialeEnv
    {

        public int FilialeID { get; set; }

        public string Nom { get; set; }

        public string Code { get; set; }




        public virtual ICollection<UtilisateurEnv> utilisateurEnv { get; set; }





    }
}
