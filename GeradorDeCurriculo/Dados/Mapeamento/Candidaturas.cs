﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCurriculo.Dados.Mapeamento
{
    public class Candidaturas
    {
        public int ID { get; set; }
        public int IDVaga { get; set; }
        public int IDDadosPessoais { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Situacao { get; set; }
        public string instrucoes { get; set; }
        public string CurriculoNome { get; set; }






    }
}
