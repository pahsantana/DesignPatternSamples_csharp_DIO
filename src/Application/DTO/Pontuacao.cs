using System;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]
    public class Pontuacao
    {
        public DateTime DataOcorrencia { get; set; }
        public string DescricaoCTB { get; set; }
        public string Gravidade { get; set; }
        public int Pontos { get; set; }
        public double ValorMulta { get; set; }

    }
}
