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
    public class CandidaturasDAO : Conexao
    {
        public List<Candidaturas> Listar(int id)
        {

            return acessoDB.Query<Candidaturas>(@"select *from Candidaturas WHERE IDVaga =" + id ).ToList();
        }

        public List<Candidaturas> ListarCandidato(int idvaga,int iddadospessoais )
        {

            return acessoDB.Query<Candidaturas>(@"SELECT *FROM Candidaturas WHERE IDVaga="+idvaga+" AND IDDadosPessoais="+iddadospessoais).ToList();
        }

        public Candidaturas Buscar (int idvaga, int iddadospessoais)
        {
            return acessoDB.Query<Candidaturas>(@"select *from Candidaturas WHERE IDVaga=@idvaga and IDdadospessoais=@iddadospessoais  ", new { idvaga, iddadospessoais}).FirstOrDefault();
        }


        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from Candidaturas where ID=@pID",
                new { pID = id }) == 1;
        }

       

        public int Salvar(Candidaturas candidaturas)
        {
           
                return acessoDB.Query<int>(@"INSERT INTO candidaturas (IDVaga,IDDadosPessoais,DataCadastro,Situacao,instrucoes,CurriculoNome) VALUES (@IDVaga,@IDDadosPessoais,@DataCadastro,@Situacao,@instrucoes,@CurriculoNome) SELECT @@Identity", candidaturas).SingleOrDefault();


        }


    }
}
