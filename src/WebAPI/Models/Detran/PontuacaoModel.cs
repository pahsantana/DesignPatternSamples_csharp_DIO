using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Models.Detran
{
    public class PontuacaoModel
    {
        public DateTime DataOcorrencia { get; set; }
        public string DescricaoCTB { get; set; }
        public string Gravidade { get; set; }
        public int Pontos { get; set; }
        public double ValorMulta { get; set; }

    }
}
