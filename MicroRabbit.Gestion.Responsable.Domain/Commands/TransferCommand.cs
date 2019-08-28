using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Gestion.Responsable.Domain.Commands
{
    public class TransferCommand : Command
    {
        public int FilialeID { get; protected set; }
        public String Nom { get; protected set; }
        public String Code { get; protected set; }

    }
}
