using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models
{
    [Table("TAB_IMC")]
    class Imc
    {
        public Imc ()
        {
            criadoEm = DateTime.Now;
        }
        [Key]
        public int idImc { get; set; }
        public Aluno aluno { get; set; }
        public double altura { get; set; }
        public double peso { get; set; }
        public DateTime criadoEm { get; set; }
        public String imcResult { get; set; }
        public String resultado { get; set; }
    }
}
