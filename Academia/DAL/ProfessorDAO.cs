using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.DAL
{
    class ProfessorDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarProfessor(Professor p)
        {
            if (BuscarNomeSenha(p.cpf, p.senha) == null)
            {
                ctx.TAB_PROFESSOR.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Professor> ListarProfessores()
            => ctx.TAB_PROFESSOR.ToList();

        public static Professor BuscarNomeSenha(String cpf, String senha)
        {
            return ctx.TAB_PROFESSOR.FirstOrDefault(x => x.cpf.Equals(cpf) && x.senha.Equals(senha));
        }
        public static void DeletarProfessor(String cpf, String senha)
        {
            AvaliacaoDAO.DeletarAvaliacao(cpf, senha);
            ctx.TAB_PROFESSOR.Remove(ProfessorDAO.BuscarNomeSenha(cpf, senha));
            ctx.SaveChanges();
        }
        public static Professor BuscarId(int id)
        {
            return ctx.TAB_PROFESSOR.FirstOrDefault(x => x.idProfessor.Equals(id));
        }
        public static bool UpdateProfessor(Professor a, String cpf, String senha, int id)
        {
            if (BuscarNomeSenha(a.cpf, a.senha) == null || BuscarNomeSenha(a.cpf, a.senha).idProfessor == id)
            {
                Professor professor = ctx.TAB_PROFESSOR.First(x => x.cpf.Equals(cpf) && x.senha.Equals(senha));
                professor.nome = a.nome;
                professor.senha = a.senha;
                professor.email = a.email;
                professor.estado = a.estado;
                professor.cidade = a.cidade;
                professor.bairro = a.bairro;
                professor.email = a.email;
                professor.cpf = a.cpf;
                professor.rg = a.rg;
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
