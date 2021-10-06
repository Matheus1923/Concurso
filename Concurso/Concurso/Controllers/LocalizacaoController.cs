using Concurso.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Concurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizacaoController : ControllerBase
    {

        public Contexto Contexto { get; set; }

        public LocalizacaoController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }
        
        [HttpGet]
        public List<Localizacao> Get()
        {
            return Contexto.Localizacaos.ToList();
        }

        [HttpGet("idLocalizacao/{idLocalizacao}")]
        public List<Localizacao> filtrar(int id)
        {
            return Contexto.Localizacaos.Where(e => e.IdLocalizacao == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Localizacao>> Create(Localizacao Localizacao)
        {
            Localizacao.IdLocalizacao = 0;
            Contexto.Localizacaos.Add(Localizacao);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Localizacao.IdLocalizacao, Localizacao });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Localizacao>> Update(Localizacao Localizacao)
        {
            Contexto.Localizacaos.Update(Localizacao);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Localizacao.IdLocalizacao, Localizacao });
        }

        [HttpPost]
        [Route("remove")]
        public async Task<ActionResult<Localizacao>> Remove(Localizacao Localizacao)
        {
            Contexto.Localizacaos.Remove(Localizacao);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Localizacao.IdLocalizacao, Localizacao });
        }
    }
}
