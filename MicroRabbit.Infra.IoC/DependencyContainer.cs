using MediatR;
using MicroRabbit.GestionFournisseur.Application.Interfaces;
using MicroRabbit.GestionFournisseur.Application.Services;
using MicroRabbit.GestionFournisseur.Data.Context;
using MicroRabbit.GestionFournisseur.Data.Repository;
using MicroRabbit.GestionFournisseur.Domain.CommandHandlers;
using MicroRabbit.GestionFournisseur.Domain.Commands;
using MicroRabbit.GestionFournisseur.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Application.Services;
using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Data.Repository;
//using MicroRabbit.GestionCompresseur.Domain.EventHandlers;
//using MicroRabbit.GestionCompresseur.Domain.Events;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Gestion.Responsable.Domain.Interfaces;
using MicroRabbit.Gestion.Responsable.Data.Repository;
using MicroRabbit.Gestion.Responsable.Data.Context;
using MicroRabbit.Gestion.Responsable.Aplication.Interfaces;
using MicroRabbit.Gestion.Responsable.Aplication.Services;
using MicroRabbit.Gestion.Responsable.Domain.Commands;
using MicroRabbit.Gestion.Responsable.Domain.CommandHandlers;
using MicroRabbit.GestionResponsable.Data.Repository;
using MicroRabbit.GestionCompresseur.Domain.Events;
using MicroRabbit.GestionCompresseur.Domain.EventHandlers;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            //services.AddTransient<CreationEventHandler>();
            //hajer
            services.AddTransient<FilialeEventHandler>();


            //Domain Events
            services.AddTransient<IEventHandler<CreationDoneEvent>, CreationEventHandler>();
           
                //hajer

            services.AddTransient<IEventHandler<SendListeCreateEvent>, FilialeEventHandler>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateFournisseurCommand, bool>, FournisseurCommandHandler>();
            //hajer
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application Services
            services.AddTransient<IFournisseurService, FournisseurService>();
            //hajer
            services.AddTransient<IFilialeService, FilialeService>();
            services.AddTransient<ICompresseurService, CompresseurService>();
<<<<<<< Updated upstream
            services.AddTransient<ICompresseurFilialeService, CompresseurFilialeService>();
=======
            //hajer
            services.AddTransient<IFilialeDupService, FilialeDupService>();
            //hajer
            services.AddTransient<IUtilisateureService, UtilisateurService>();
            //hajer

>>>>>>> Stashed changes

            //Data
     
            services.AddTransient<IFournisseurRepository, FournisseurRepository>();
            //hajer
            services.AddTransient<IFilialesRepository, FilialesRepository>();

            services.AddTransient<IFilialeDupRepository, FilialeDupRepository>();
            services.AddTransient<ICompresseurRepository, CompresseurRepository>();
<<<<<<< Updated upstream
            services.AddTransient<ICompresseurFilialeRepository, CompresseurFilialeRepository>();
=======
>>>>>>> Stashed changes
            services.AddTransient<FournisseurDbContext>();
            services.AddTransient<Gestion_Responsable_DBContext>();

            services.AddTransient<CompresseurDbContext>();
<<<<<<< Updated upstream
            
=======
            //hajer
            //hajer
            services.AddTransient<IUtilisateursRepository, UtilisateursRepository>();
            //hajer

            //hajer
         
>>>>>>> Stashed changes
        }
    }
}
