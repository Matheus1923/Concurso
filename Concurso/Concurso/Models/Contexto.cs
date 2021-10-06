using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concurso.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Localizacao> Localizacaos { get; set; }

        public DbSet<Candidato> Candidatos { get; set; }

        public DbSet<Tutor> Tutors { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
