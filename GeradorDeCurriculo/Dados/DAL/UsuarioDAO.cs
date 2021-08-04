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
    public class UsuarioDAO : Conexao
    {

        public List<Usuario> Listar(string nome)
        {

            return acessoDB.Query<Usuario>(@"select *from Usuario WHERE Login LIKE '%" + nome + "%' Order By Login ").ToList();
        }

        public Usuario Buscar(int id)
        {
            return acessoDB.Query<Usuario>(@"select *from Usuario where ID=@id", new { id }).SingleOrDefault();

        }

        public Usuario EntrarLogin(string login, string senha)

        {
            //FALTA FAZER O TRATAMENTO PARA USUARIOS IGUAIS
            return acessoDB.Query<Usuario>(@"select *from Usuario where Login=@login  AND Senha=@senha ", new { login, senha }).SingleOrDefault();

        }

        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from Usuario where ID=@pID",
                new { pID = id }) == 1;
        }

        public int Salvar(Usuario usuarios)
        {
            if (usuarios.ID == 0)
            {

                return acessoDB.Execute("INSERT INTO Usuario (Nome,Login,Senha,Ativo,AcessoCurriculo,AcessoEmpresa) VALUES (@Nome,@Login,@Senha,@Ativo,@AcessoCurriculo,@AcessoEmpresa) SELECT @@Identity", usuarios);

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha, Ativo=@Ativo, AcessoCurriculo=@AcessoCurriculo, AcessoEmpresa=@AcessoEmpresa WHERE Usuario.ID = @ID", usuarios) == 1)
                    return usuarios.ID;

                else
                    return 0;
            }

        }

    }
    
}
