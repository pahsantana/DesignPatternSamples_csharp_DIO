using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPConsultarPontuacaoRepository : IDetranConsultarPontuacaoRepository
    {
        private readonly ILogger _LoggerP;

        public DetranSPConsultarPontuacaoRepository(ILogger<DetranSPConsultarPontuacaoRepository> logger)
        {
            _LoggerP = logger;
        }

        public Task<IEnumerable<Pontuacao>> ConsultarPontuacao(Habilitacao habilitacao)
        {
            _LoggerP.LogDebug($"Consultando pontuação da CNH {habilitacao.NumeroRegistro} para o estado de SP.");
            return Task.FromResult<IEnumerable<Pontuacao>>(new List<Pontuacao>() { new Pontuacao() });
        }
    }
}
