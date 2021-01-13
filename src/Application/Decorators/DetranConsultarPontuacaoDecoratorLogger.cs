using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranConsultarPontuacaoDecoratorLogger : IDetranConsultarPontuacaoService
    {
        private readonly IDetranConsultarPontuacaoService _Inner;
        private readonly ILogger<DetranConsultarPontuacaoDecoratorLogger> _Logger;

        public DetranConsultarPontuacaoDecoratorLogger(
            IDetranConsultarPontuacaoService inner,
            ILogger<DetranConsultarPontuacaoDecoratorLogger> logger)
        {
            _Inner = inner;
            _Logger = logger;
        }

        public async Task<IEnumerable<Pontuacao>> ConsultarPontuacao(Habilitacao habilitacao)
        {
            Stopwatch watch = Stopwatch.StartNew();
            _Logger.LogInformation($"Iniciando a execução do método ConsultarPontuacao({habilitacao})");
            var result = await _Inner.ConsultarPontuacao(habilitacao);
            watch.Stop(); 
            _Logger.LogInformation($"Encerrando a execução do método ConsultarPontuacao({habilitacao}) {watch.ElapsedMilliseconds}ms");
            return result;
        }
    }
}