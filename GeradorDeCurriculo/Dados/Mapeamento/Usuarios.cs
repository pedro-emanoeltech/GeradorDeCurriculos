﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCurriculo.Dados.Mapeamento
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string  Senha{ get; set; }
        public bool Ativo { get; set; }
        public bool AcessoCurriculo { get; set; }
        public bool AcessoEmpresa { get; set; }
       


    }
}
