using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCurriculo.Dados.Mapeamento
{
    public class Empresa

    {
        public int ID { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }
        public  string Cidade { get; set; }
        public string Endereco{ get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public int IDUsuario { get; set; }




    }
}
