using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Models;

namespace Academia.DAL
{
    class AvaliacaoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarAvaliacao(Professor p ,Avaliacao a)
        {
            if (ValidarAvaliacao(p, a, a.aluno) == null || ValidarAvaliacao(p, a, a.aluno).statusAvaliacao == "Recusada")
            {
                ctx.TAB_AVALIACAO.Add(a);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static void AceitarAvaliacao(int i)
        {
            Avaliacao v = ctx.TAB_AVALIACAO.Single(x => x.idAvaliacao.Equals(i));
            v.statusAvaliacao = "Aceita";
            ctx.SaveChanges();
        }

        public static void RecusarAvaliacao(int i)
        {
            Avaliacao v = ctx.TAB_AVALIACAO.Single(x => x.idAvaliacao.Equals(i));
            v.statusAvaliacao = "Recusada";
            ctx.SaveChanges();
        }

        public static List<Avaliacao> ListarAvaliacaos()
        {
            return ctx.TAB_AVALIACAO.Include("aluno").Include("professor").ToList();
        }

        public static Avaliacao BuscarAvaliacaoPorId(int id)
        {
            return ctx.TAB_AVALIACAO.FirstOrDefault(x => x.idAvaliacao.Equals(id));
        }

        public static Avaliacao BuscarAvaliacaoPorIdAluno(int id)
        {
            return ctx.TAB_AVALIACAO
                .Include("aluno")
                .Include("professor")
                .OrderByDescending(x => x.dataMarcada)
                .FirstOrDefault(x => x.aluno.idAluno.Equals(id));
        }
        //var company = context.Companies
        //     .Include(co => co.Employees).ThenInclude(emp => emp.Employee_Car)
        //     .Include(co => co.Employees).ThenInclude(emp => emp.Employee_Country)
        //     .FirstOrDefault(co => co.companyID == companyID);
        public static Avaliacao ValidarAvaliacao(Professor p, Avaliacao a, Aluno l)
        {
            return ctx.TAB_AVALIACAO.OrderByDescending(x => x.dataMarcada).FirstOrDefault(x => x.professor.idProfessor.Equals(p.idProfessor) && x.dataMarcada.Value.Day == a.dataMarcada.Value.Day && x.dataMarcada.Value.Hour == a.dataMarcada.Value.Hour && x.dataMarcada.Value.Month == a.dataMarcada.Value.Month && x.dataMarcada.Value.Year == a.dataMarcada.Value.Year);
        }

        public static void DeletarAvaliacao(String cpf, String senha)
        {
            foreach (Avaliacao ava in ListarAvaliacaos())
            {
                if (ava.aluno.cpf.Equals(cpf) && ava.aluno.senha.Equals(senha))
                {
                    ctx.TAB_AVALIACAO.Remove(ava);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
