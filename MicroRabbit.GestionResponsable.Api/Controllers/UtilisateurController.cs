using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Gestion.Responsable.Aplication.Interfaces;
using MicroRabbit.Gestion.Responsable.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.GestionResponsable.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilsateurController : ControllerBase
    {
        private readonly IUtilisateureService _utilisateureService;

        public UtilsateurController(IUtilisateureService utilisateureService)
        {
            _utilisateureService = utilisateureService;
        }

        // GET api/Utilisateur
        [HttpGet]
        public ActionResult<IEnumerable<Utilisateur>> Get()
        {
            return Ok(_utilisateureService.GetUtilisateurs());
        }


        // GET api/Utilisateur/5
        [HttpGet("{id}")]
        public ActionResult<Utilisateur> Get1(int id)
        {
            return Ok(_utilisateureService.GetUtilisateur(id));
        }


        // DELETE: api/Utilisateurs/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteUtilisateur(int id)
        {
            return Ok(_utilisateureService.DeleteUtilisateur(id));
        }



        // PUT: api/Utilisateurs/5
        [HttpPut("{id}")]
        public ActionResult<int> PutUtilisateur(int id, [FromBody] Utilisateur utilisateur)
        {
            if (id != utilisateur.UtilisateurID)
            {
                return BadRequest();
            }

            return Ok(_utilisateureService.PutUtilisateur(id, utilisateur));


        }


        // POST api/Utilisateur
        [HttpPost]
        public ActionResult<int> Post([FromBody] Utilisateur utilisateur)
        {
            return Ok(_utilisateureService.PostUtilisateur(utilisateur));
        }

        //private ActionResult<int> Ok(object p, Utilisateur utilisateur1, object utilisateur2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
