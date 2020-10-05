using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models
{
    [Table("TAB_PROFESSOR")]
    class Professor : Pessoa
    {
        public Professor()
        {
            criadoEm = DateTime.Now;
        }

        [Key]
        public int idProfessor { get; set; }
        
    }
}
