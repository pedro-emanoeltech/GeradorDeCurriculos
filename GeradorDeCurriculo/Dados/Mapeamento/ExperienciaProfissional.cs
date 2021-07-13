using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCurriculo.Dados.Mapeamento
{
    public class ExperienciaProfissional
    {
        public int ID { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public string Segmento { get; set; }
        public decimal Salario { get; set; }
        public string Descricao { get; set; }
        public int IDDadosPessoais { get; set; }

        // referencia
        public DadosPessoais dadosPessoais { get; set; }
    }
}
