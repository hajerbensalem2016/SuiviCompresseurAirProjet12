using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionResponsable.Domain.Commands

{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(string nom, string code)
        {
            Nom = nom;
            Code = code;
        }
    }


}

