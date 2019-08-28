using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MediatR;

using System.Net;
using MicroRabbit.Gestion.Responsable.Aplication.Interfaces;
using MicroRabbit.Gestion.Responsable.Domain.Models;
using MicroRabbit.Gestion.Responsable.Aplication.Models;
using MicroRabbit.Gestion.Responsable.Domain.Interfaces;

namespace MicroRabbit.GestionResponsable.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilialeController : ControllerBase
    {
        private readonly IFilialeService _filialeService;

        private readonly IFilialesRepository _db;


        public FilialeController(IFilialeService filialeService, IFilialesRepository db)
        {
            _filialeService = filialeService;
            _db = db;
        }

        // GET api/Filiale
        [HttpGet]
        public ActionResult<IEnumerable<Filiale>> Get()
        {
            return Ok(_filialeService.GetFiliales());
        }



        /// ////////////////////////////////////
        // GET api/Filiale/5
        [HttpGet("{id}")]
        public ActionResult<Filiale> Get1(int id)
        {
            return Ok(_filialeService.GetFiliale(id));
        }


        // DELETE: api/Filiales/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteFiliale(int id)
        {
            return Ok(_filialeService.DeleteFiliale(id));
        }



        // PUT: api/Filiales/5
        [HttpPut("{id}")]
        public ActionResult<int> PutFiliale(int id, [FromBody] Filiale Filiale)
        {
            if (id != Filiale.FilialeID)
            {
                return BadRequest();
            }

            return Ok(_filialeService.PutFiliale(id, Filiale));


        }






        [HttpPost]
        public IActionResult Post([FromBody] FilialeEnv filialeEnv)
        {

            _filialeService.Transfer(filialeEnv);
            _db.AddF(new Filiale()
            {
                FilialeID = filialeEnv.FilialeID,
                Nom = filialeEnv.Nom,
                Code = filialeEnv.Code,
                
            });
            return Ok(filialeEnv);

        }
}
}
