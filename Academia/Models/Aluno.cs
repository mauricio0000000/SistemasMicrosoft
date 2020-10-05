using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models
{
    [Table("TAB_ALUNO")]
    class Aluno : Pessoa
    {
        public Aluno()
        {
            criadoEm = DateTime.Now;
        }

        [Key]
        public int idAluno { get; set; }

        public override string ToString()
        {
            return this.cpf + " - " +this.nome;
        }
    }
}
