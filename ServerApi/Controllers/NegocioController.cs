using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ServerApi.Helper;
using ServerApi.Models;
using ServerApiBaleares.Models.DTO;

namespace ServerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegocioController : BaseController
    {

        public NegocioController(DataContext data) : base(data)
        {

        }

        [SyncfusionJson]
        [HttpGet("GetEstaAbierto/{negocio}/{año}/{mes}/{dia}")]
        public async Task<ActionResult<List<NegocioControl>>> GetEstaAbierto(string negocio,int año, int mes, int dia)
        {
            try
            {  
                DateTime dia1 = new DateTime(año, mes,  dia);
                string diaName = dia1.ToString("dddd", new CultureInfo("es-ES"));
                var rows = ctx.NegocioControl.Where(x => x.Negocio.Contains(negocio) && x.DiaDeLaSemana.Contains(diaName)).Select(x=>new NegocioDTO() { HorarioApertura=x.HorarioApertura,HorarioCierre=x.HorarioCierre  }  ).ToList();

                return Ok(new { Items = rows, Count = rows.Count() });


            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [SyncfusionJson]
        [HttpGet("GetTotales/{tipo}/{desde}/{hasta}")]
        public async Task<ActionResult<List<NegocioControl>>> GetTotales(int tipo, int desde, int hasta)
        {
            try
            {
                var rows = ctx.NegocioControl.ToList();
                return Ok(new { Items = rows, Count = rows.Count() });
            }
            catch (Exception ex)
            {
               
                return BadRequest();
            }
        }
    }
}