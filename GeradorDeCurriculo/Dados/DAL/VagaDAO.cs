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
    public class VagasDAO : Conexao
    {



      

        public List<Vagas> Listar(string TituloVaga)
        {

            return acessoDB.Query<Vagas>(@"select *from Vagas WHERE TituloVaga LIKE '%" + TituloVaga + "%' Order By TituloVaga ").ToList();
        }

        public List<Vagas> ListarEmpresa(int id)
        {

            return acessoDB.Query<Vagas>(@"select *from Vagas WHERE IDEmpresa =" + id + " Order By TituloVaga").ToList();
        }

        public Vagas Buscar(int id)
        {
            return acessoDB.Query<Vagas>(@"select *from  Vagas where ID=@id", new { id }).SingleOrDefault();

        }

        public Vagas Rastreio(int id)
        {
            return acessoDB.Query<Vagas>(@"select *from  Vagas where IDUsuario=@id", new { id }).SingleOrDefault();

        }

        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from Vagas where ID=@pID",
                new { pID = id }) == 1;
        }

        public int Salvar(Vagas vagas)
        {


            if (vagas.ID == 0)
            {

                return acessoDB.Execute("INSERT INTO  Vagas (TituloVaga,Descricao,Atividade,Requisitos,Salario,Cidade,TipoVaga,IDEmpresa) VALUES (@TituloVaga,@Descricao,@Atividade,@Requisitos,@Salario,@Cidade,@TipoVaga,@IDEmpresa) SELECT @@Identity", vagas);

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE Vagas SET TituloVaga=@TituloVaga, Descricao=@Descricao, Atividade=@Atividade, Requisitos=@Requisitos, Salario=@Salario, Cidade=@Cidade, TipoVaga=@TipoVaga, IDEmpresa=@IDEmpresa WHERE Vagas.ID = @ID", vagas ) == 1)
                    return vagas.ID;

                else
                    return 0;
            }
            


        }


    }
}
