using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models
{
    [Table("TAB_AVALIACAO")]
    class Avaliacao
    {
        public Avaliacao()
        {
            criadoEm = DateTime.Now;
            statusAvaliacao = "Pendente";
        }
        [Key]
        public int idAvaliacao { get; set; }
        public DateTime criadoEm { get; set; }
        public DateTime? dataMarcada { get; set; }
        public Aluno aluno { get; set; }
        public Professor professor { get; set; }
        public String statusAvaliacao { get; set; }

        public override string ToString()
        {
            return aluno.cpf + " - " + aluno.nome;
        }
    }
}
