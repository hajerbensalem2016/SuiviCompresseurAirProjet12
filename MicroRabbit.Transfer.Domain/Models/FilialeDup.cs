using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace MicroRabbit.GestionCompresseur.Domain.Models

{
    public  class FilialeDup
    {
        [Key]
        public int FilialeID { get; set; }

        public string Nom { get; set; }

        public string Code { get; set; }





    }
}
