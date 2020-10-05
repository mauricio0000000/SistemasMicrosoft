using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models
{
    class Context : DbContext
    {
        //Nomear o banco de dados
        public Context() : base("DbAcademia") { }

        //Definir as classes que vão virar tabelas no banco
        public DbSet<Aluno> TAB_ALUNO { get; set; }
        public DbSet<Professor> TAB_PROFESSOR { get; set; }
        public DbSet<Imc> TAB_IMC { get; set; }
        public DbSet<Avaliacao> TAB_AVALIACAO { get; set; }
    }
}
