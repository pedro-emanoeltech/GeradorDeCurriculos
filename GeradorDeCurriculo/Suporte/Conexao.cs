using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GeradorDeCurriculo.Suporte
{
    
    public class Conexao
    {
        public SqlConnection acessoDB = null;

        public Conexao()
        {
            //conexao com o banco utilizando o acessoDB Endereço está no App.config
            var str = System.Configuration.ConfigurationManager.AppSettings["acessoDB"];
            acessoDB = new SqlConnection(str);
        }

    }
}
