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

        public List<Vaga> Listar(string TituloVaga)
        {

            return acessoDB.Query<Vaga>(@"select *from Vaga WHERE TituloVaga LIKE '%" + TituloVaga + "%' Order By TituloVaga ").ToList();
        }

        public List<Vaga> ListarEmpresa(int id)
        {

            return acessoDB.Query<Vaga>(@"select *from Vaga WHERE IDEmpresa =" + id + " Order By TituloVaga").ToList();
        }

        public Vaga Buscar(int id)
        {
            return acessoDB.Query<Vaga>(@"select *from  Vaga where ID=@id", new { id }).SingleOrDefault();

        }

        public Vaga Rastreio(int id)
        {
            return acessoDB.Query<Vaga>(@"select *from  Vaga where IDUsuario=@id", new { id }).SingleOrDefault();

        }

        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from Vaga where ID=@pID",
                new { pID = id }) == 1;
        }

        public int Salvar(Vaga vagas)
        {

            if (vagas.ID == 0)
            {

                return acessoDB.Execute("INSERT INTO  Vaga (TituloVaga,Descricao,Atividade,Requisitos,Salario,Cidade,TipoVaga,IDEmpresa) VALUES (@TituloVaga,@Descricao,@Atividade,@Requisitos,@Salario,@Cidade,@TipoVaga,@IDEmpresa) SELECT @@Identity", vagas);

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE Vaga SET TituloVaga=@TituloVaga, Descricao=@Descricao, Atividade=@Atividade, Requisitos=@Requisitos, Salario=@Salario, Cidade=@Cidade, TipoVaga=@TipoVaga, IDEmpresa=@IDEmpresa WHERE Vaga.ID = @ID", vagas ) == 1)
                    return vagas.ID;

                else
                    return 0;
            }
            
        }

    }
}
