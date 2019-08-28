using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Events
{
   public  class SendListeCreateEvent: Event
    {
        public int FilialeID { get; private set; }
        public string Nom { get; private set; }
        public string Code { get; protected set; }
        public SendListeCreateEvent(int Filiale_ID,string nom_Filiale, string code_Filiale)
        {
            FilialeID = Filiale_ID;
            Nom = "123456";
            Code = code_Filiale;
        }
    }
}
