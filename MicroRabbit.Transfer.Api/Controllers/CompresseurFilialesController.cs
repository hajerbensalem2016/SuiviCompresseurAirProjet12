using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Domain.Models;
using MicroRabbit.GestionCompresseur.Application.Services;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Application.Interfaces;

namespace MicroRabbit.GestionCompresseur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompresseurFilialesController : ControllerBase
    {
        private readonly ICompresseurFilialeService CompresseurFilialeService;

        public CompresseurFilialesController(ICompresseurFilialeService compresseurFilialeService)
        {
            CompresseurFilialeService = compresseurFilialeService;
        }

        // GET api/transfer
        [HttpGet]
        public ActionResult<IEnumerable<CompresseurFiliale>> GetCompresseursFiliales()
        {
            return Ok(CompresseurFilialeService.GetCompresseursFiliales());
        }



    }
}
