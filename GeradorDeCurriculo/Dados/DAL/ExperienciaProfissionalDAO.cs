using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bibliotecas 
using Dapper; 
using GeradorDeCurriculo.Suporte;
using GeradorDeCurriculo.Dados.Mapeamento;
using System.Data;
using System.Data.SqlClient;

namespace GeradorDeCurriculo.Dados.DAL
{
    public class ExperienciaProfissionalDAO : Conexao
    {
        public List<ExperienciaProfissional> Listar(int id)
        {

            return acessoDB.Query<ExperienciaProfissional>(@"select *from ExperienciaProfissional WHERE IDDadosPessoais =" + id + " Order By Empresa").ToList();
        }


        public ExperienciaProfissional Buscar (int id)
        {
            return acessoDB.Query<ExperienciaProfissional>(@"select *from ExperienciaProfissional WHERE ID=@id ", new { id }).FirstOrDefault();
        }

       
        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from ExperienciaProfissional where ID=@pID",
                new { pID = id }) == 1;
        }

        public int ExcluirVinculo(int id)
        {
            return acessoDB.Execute(@"DELETE from ExperienciaProfissional  where IDDadosPessoais = @pId", new { pId = id });
        }

        public int Salvar(ExperienciaProfissional experienciaprofissional)
        {
            if (experienciaprofissional.ID == 0)
            {
                return acessoDB.Query<int>(@"INSERT INTO experienciaprofissional (Empresa,Cargo,Segmento,Salario,Descricao,IDDadosPessoais) VALUES (@Empresa,@Cargo,@Segmento,@Salario,@Descricao,@IDDadosPessoais) SELECT @@Identity", experienciaprofissional).SingleOrDefault();

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE experienciaprofissional SET Empresa= @empresa, Cargo = @Cargo, Segmento= @Segmento, Salario = @Salario, Descricao = @Descricao, IDDadosPessoais = @IDDadosPessoais WHERE ID = @ID", experienciaprofissional) == 1)
                    return experienciaprofissional.ID;

                else
                    return 0;
            }



        }


    }
}
