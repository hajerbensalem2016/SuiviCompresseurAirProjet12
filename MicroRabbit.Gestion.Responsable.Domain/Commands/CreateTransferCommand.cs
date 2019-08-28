using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int filialeID, string nom, string code)
    {
            FilialeID = filialeID;
        Nom = nom;
        Code = code;
    }
}


}

