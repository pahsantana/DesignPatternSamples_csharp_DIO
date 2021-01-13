using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workbench.IDistributedCache.Extensions;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranConsultarPontuacaoDecoratorCache : IDetranConsultarPontuacaoService
    {
        private readonly IDetranConsultarPontuacaoService _Inner;
        private readonly IDistributedCache _Cache;

        public DetranConsultarPontuacaoDecoratorCache(
            IDetranConsultarPontuacaoService inner,
            IDistributedCache cache)
        {
            _Inner = inner;
            _Cache = cache;
        }

        public Task<IEnumerable<Pontuacao>> ConsultarPontuacao(Habilitacao habilitacao)
        {
            return Task.FromResult(_Cache.GetOrCreate($"{habilitacao.UF}_{habilitacao.NumeroRegistro.ToString()}", () => _Inner.ConsultarPontuacao(habilitacao).Result));
        }
    }
}