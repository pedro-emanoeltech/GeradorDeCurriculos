using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCurriculo.Dados.Mapeamento
{
    public class Formacao
    {
        public int ID { get; set; }
        public string Curso { get; set; }
        public string FormacaoNivel { get; set; }
        public string Status { get; set; }

        // datatime? para aceitar null
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string Descricao { get; set; }
        public int IDDadosPessoais { get; set; }

        // referencia
        public DadosPessoais dadosPessoais { get; set; }


    }
}
