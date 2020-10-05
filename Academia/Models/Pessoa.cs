using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Academia.Models
{
    class Pessoa
    {
        public String nome { get; set; }
        public String senha { get; set; }
        public String email { get; set; }
        public String cpf { get; set; }
        public String rg { get; set; }
        public String estado { get; set; }
        public String cidade { get; set; }
        public String bairro { get; set; }
        public DateTime criadoEm { get; set; }
    }
}
