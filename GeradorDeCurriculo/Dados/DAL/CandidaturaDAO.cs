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
    public class CandidaturaDAO : Conexao
    {
        public List<Candidatura> Listar(int id)
        {

            return acessoDB.Query<Candidatura>(@"select *from Candidatura WHERE IDVaga =" + id ).ToList();
        }

        public List<Candidatura> ListarCandidato(int idvaga,int iddadospessoais )
        {

            return acessoDB.Query<Candidatura>(@"SELECT *FROM Candidatura WHERE IDVaga=" + idvaga+" AND IDDadosPessoais="+iddadospessoais).ToList();
        }
         
        public Candidatura Buscar (int idvaga, int iddadospessoais)
        {
            return acessoDB.Query<Candidatura>(@"select *from Candidatura WHERE IDVaga=@idvaga and IDdadospessoais=@iddadospessoais  ", new { idvaga, iddadospessoais}).FirstOrDefault();
        }

        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from Candidatura where ID=@pID",
                new { pID = id }) == 1;
        }
       
        public int Salvar(Candidatura candidaturas)
        {

            return acessoDB.Execute(@"INSERT INTO candidatura (IDVaga,IDDadosPessoais,DataCadastro,Situacao,Instrucoes,CurriculoNome) VALUES (@IDVaga,@IDDadosPessoais,@DataCadastro,@Situacao,@Instrucoes,@CurriculoNome) SELECT @@Identity", candidaturas);

        }

    }
}
