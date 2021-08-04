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
    public class DadosPessoaisDAO : Conexao
    {

        public List<DadosPessoais> Listar(int id)
        {

            return acessoDB.Query<DadosPessoais>(@"select *from DadosPessoais WHERE IDUsuario="+ id+" Order By Nome").ToList();
        }

        public DadosPessoais exite(int id)
        {

            return acessoDB.Query<DadosPessoais>(@"select *from DadosPessoais where IDUsuario=@id", new { id }).SingleOrDefault();
        }

        public DadosPessoais Buscar(int id)
        {
            return acessoDB.Query<DadosPessoais>(@"select *from DadosPessoais where ID=@id", new { id }).SingleOrDefault();

        }

        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from DadosPessoais where ID=@pID",
                new { pID = id }) == 1;

        }

        public int Salvar(DadosPessoais dadospessoais)
        {
            if (dadospessoais.ID == 0)
            {

                return acessoDB.Execute("INSERT INTO DadosPessoais (Nome,DataNascimento,Endereco,Bairro,Cidade,Nacionalidade,Telefone,IDUsuario) VALUES (@NOME ,@DataNascimento, @Endereco ,@Bairro ,@cidade ,@Nacionalidade,@Telefone,@IDUsuario) SELECT @@Identity", dadospessoais);

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE DadosPessoais SET Nome = @Nome ,DataNascimento = @DataNascimento, Endereco= @Endereco, Bairro=@Bairro, Cidade=@Cidade, Nacionalidade=@Nacionalidade, Telefone=@Telefone, IDUsuario=@IDUsuario WHERE DadosPessoais.ID = @ID", dadospessoais) == 1)
                    return dadospessoais.ID;

                else
                    return 0;
            }

        }


    }
}
