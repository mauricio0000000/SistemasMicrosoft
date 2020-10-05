using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.DAL
{
    class ImcDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static void CadastrarImc(Imc p)
        {
            ctx.TAB_IMC.Add(p);
            ctx.SaveChanges();
        }

        public static List<Imc> ListarImces()
            => ctx.TAB_IMC.ToList();

        public static Imc BuscarId(int id)
        {
            return ctx.TAB_IMC.FirstOrDefault(x => x.idImc.Equals(id));
        }
        public static void DeletaImc(String cpf, String senha)
        {
            foreach (Imc imc in ListarImces())
            {
                if (imc.aluno.cpf.ToString() == cpf.ToString() && imc.aluno.senha.ToString() == senha.ToString())
                {
                    ctx.TAB_IMC.Remove(imc);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
