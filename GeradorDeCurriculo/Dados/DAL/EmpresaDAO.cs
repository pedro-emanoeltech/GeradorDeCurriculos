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
    public class EmpresaDAO : Conexao
    {



        public Empresa Buscar(int id)
        {
            return acessoDB.Query<Empresa>(@"select *from Empresas where ID=@id", new { id }).SingleOrDefault();

        }

       

        public Empresa Rastreio(int id)
        {
            return acessoDB.Query<Empresa>(@"select *from Empresas where IDUsuario=@id", new { id }).SingleOrDefault();

        }



        public int Salvar(Empresa empresa)
        {


            if (empresa.ID == 0)
            {

                return acessoDB.Execute("INSERT INTO Empresas (CNPJ,Nome,Setor,Cidade,Endereco,Bairro,Numero,IDUsuario) VALUES (@CNPJ,@Nome,@Setor,@Cidade,@Endereco,@Bairro,@Numero,@IDUsuario) SELECT @@Identity", empresa);

            }
            else
            {
                //UPDATE
                if (acessoDB.Execute("UPDATE empresas SET CNPJ =@CNPJ ,Nome = @Nome ,Setor=@Setor, Cidade=@Cidade,Endereco=@Endereco,Bairro =@Bairro,Numero=@Numero ,IDUsuario=@IDUsuario WHERE Empresas.ID = @ID", empresa) == 1)
                    return empresa.ID;

                else
                    return 0;
            }
            


        }


    }
}
