using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCurriculo.Dados.Mapeamento
{
    public class Vagas
    {
        public int ID { get; set; }
        public string TituloVaga { get; set; }
        public string Descricao { get; set; }
        public string Atividade { get; set; }
        public string Requisitos { get; set; }
        public  decimal Salario { get; set; }
        public string Cidade { get; set; }
        public string TipoVaga { get; set; }
        public string IDEmpresa{ get; set; }
       

    }
}
