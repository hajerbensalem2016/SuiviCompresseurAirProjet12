
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Interfaces

{
    public  interface IFilialeDupRepository
    {
        IEnumerable<FilialeDup> GetFilialesDup();
        void Add(FilialeDup filialeDup);

    }
}