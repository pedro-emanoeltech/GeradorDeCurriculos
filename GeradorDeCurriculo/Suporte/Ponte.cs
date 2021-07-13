using GeradorDeCurriculo.Dados.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeCurriculo
{
    public static class Ponte
    {
        public static Usuarios UsuarioLogado { get; set; }

        public static DadosPessoais Candidato { get; set; }

        public static Empresa Empresa { get; set; }


    }
}
