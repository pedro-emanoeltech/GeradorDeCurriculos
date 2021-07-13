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
    public class UsuariosDAO : Conexao
    {

        public List<Usuarios> Listar(string nome)
        {

            return acessoDB.Query<Usuarios>(@"select *from Usuarios WHERE Login LIKE '%" + nome + "%' Order By Login ").ToList();
        }

        public Usuarios Buscar(int id)
        {
            return acessoDB.Query<Usuarios>(@"select *from Usuarios where ID=@id", new { id }).SingleOrDefault();

        }

        public Usuarios EntrarLogin(string login, string senha)

        {
            //FALTA FAZER O TRATAMENTO PARA USUARIOS IGUAIS
            return acessoDB.Query<Usuarios>(@"select *from Usuarios where Login=@login  AND Senha=@senha ", new { login, senha }).SingleOrDefault();

        }


        public bool Excluir(int id)
        {
            return acessoDB.Execute(@"DELETE from Usuarios where ID=@pID",
                new { pID = id }) == 1;
        }

        public int Salvar(Usuarios usuarios)
        {
            if (usuarios.ID == 0)
            {


                return acessoDB.Execute("INSERT INTO Usuarios (Nome,Login,Senha,Ativo,AcessoCurriculo,AcessoEmpresa) VALUES (@Nome,@Login,@Senha,@Ativo,@AcessoCurriculo,@AcessoEmpresa) SELECT @@Identity", usuarios);

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE Usuarios SET Nome=@Nome, Login=@Login, Senha=@Senha, Ativo=@Ativo, AcessoCurriculo=@AcessoCurriculo, AcessoEmpresa=@AcessoEmpresa WHERE Usuarios.ID = @ID", usuarios) == 1)
                    return usuarios.ID;

                else
                    return 0;
            }



        }

        


    }



    
}
