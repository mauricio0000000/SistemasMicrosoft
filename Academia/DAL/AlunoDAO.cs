using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.DAL
{
    class AlunoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarAluno(Aluno a)
        {
            if (BuscarNomeSenha(a.cpf, a.senha) == null)
            {
                ctx.TAB_ALUNO.Add(a);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Aluno> ListarAlunos()
            => ctx.TAB_ALUNO.ToList();

        public static Aluno BuscarNomeSenha(String cpf, String senha)
        {
            return ctx.TAB_ALUNO.FirstOrDefault(x => x.cpf.Equals(cpf) && x.senha.Equals(senha));
        }

        public static Aluno BuscarAlunoPorCPF(String cpf)
        {
            return ctx.TAB_ALUNO.FirstOrDefault(x => x.cpf.Equals(cpf));
        }
        public static Aluno BuscarAlunoPorId(int i )
        {
            return ctx.TAB_ALUNO.FirstOrDefault(x => x.idAluno.Equals(i));
        }
        public static void DeletarAluno(String cpf, String senha)
        {
            AvaliacaoDAO.DeletarAvaliacao(cpf, senha);
            ImcDAO.DeletaImc(cpf, senha);
            ctx.TAB_ALUNO.Remove(AlunoDAO.BuscarNomeSenha(cpf, senha));
            ctx.SaveChanges();
        }
        public static bool UpdateAluno(Aluno a, String cpf, String senha, int id)
        {
            if (BuscarNomeSenha(a.cpf, a.senha) == null || BuscarNomeSenha(a.cpf, a.senha).idAluno == id)
            {
                Aluno aluno = ctx.TAB_ALUNO.Single(x => x.cpf.Equals(cpf) && x.senha.Equals(senha));
                aluno.nome = a.nome;
                aluno.senha = a.senha;
                aluno.email = a.email;
                aluno.estado = a.estado;
                aluno.cidade = a.cidade;
                aluno.bairro = a.bairro;
                aluno.email = a.email;
                aluno.cpf = a.cpf;
                aluno.rg = a.rg;
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
