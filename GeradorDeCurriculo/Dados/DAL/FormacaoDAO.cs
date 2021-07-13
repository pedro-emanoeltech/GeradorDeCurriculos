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
    public class FormacaoDAO : Conexao
    {

      
        public List<Formacao> Listar(int id)
        {

            return acessoDB.Query<Formacao>(@"select *from Formacao WHERE IDDadosPessoais =" + id + " Order By Curso").ToList();
        }

        public List<Formacao> ListarAndamento(int id)
        {

            return acessoDB.Query<Formacao>(@"select from Formacao WHERE ID =" + id ).ToList();
        }

        public Formacao Buscar(int id)
        {
            return acessoDB.Query<Formacao>(@"select *from Formacao where ID=@id", new { id }).SingleOrDefault();

        }
        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from Formacao where ID=@pID",
                new { pID = id }) == 1;
        }

        public int ExcluirVinculo(int id)
        {
            return acessoDB.Execute(@"DELETE from Formacao where IDDadosPessoais = @pId", new { pId = id });
        }

        public int Salvar(Formacao Formacao)
        {
            if (Formacao.ID == 0)
            {
                return acessoDB.Query<int>(@"INSERT INTO Formacao (Curso,FormacaoNivel,Status,Inicio,Termino,Descricao,IDDadosPessoais) VALUES (@Curso,@FormacaoNivel,@Status,@Inicio,@Termino,@Descricao,@IDDadosPessoais) SELECT @@Identity", Formacao).SingleOrDefault();

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE Formacao SET Curso = @Curso ,FormacaoNivel = @FormacaoNivel,Status = @Status,Inicio = @Inicio,Termino = @Termino,Descricao= @Descricao,IDDadosPessoais = @IDDadosPessoais WHERE ID = @ID", Formacao) == 1)
                    return Formacao.ID;

                else
                    return 0;
            }



        }


    }
}
