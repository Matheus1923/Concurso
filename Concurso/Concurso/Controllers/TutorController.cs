using Concurso.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public TutorController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Tutor> Get()
        {
            return Contexto.Tutors.ToList();
        }

        [HttpGet("{id}")]
        public Tutor Get(int id)
        {
            return Contexto.Tutors.First(e => e.IdTutor == id);
        }

        [HttpGet("idTutor/{idTutor}")]
        public List<Tutor> filtrar(int id)
        {
            return Contexto.Tutors.Where(e => e.IdTutor == id).ToList();
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Tutor>> Create(Tutor Tutor)
        {
            Tutor.IdTutor = 0;
            Contexto.Tutors.Add(Tutor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Tutor.IdTutor, Tutor });
        }


        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<Tutor>> Update(Tutor Tutor)
        {
            Contexto.Tutors.Update(Tutor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Tutor.IdTutor, Tutor });
        }

        [HttpPost]
        [Route("remove")]
        public async Task<ActionResult<Tutor>> Remove(Tutor Tutor)
        {
            Contexto.Tutors.Remove(Tutor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Tutor.IdTutor, Tutor });
        }
    }
}
