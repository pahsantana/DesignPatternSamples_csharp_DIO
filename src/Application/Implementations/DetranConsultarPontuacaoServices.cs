using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranConsultarPontuacaoServices : IDetranConsultarPontuacaoService
    {
        private readonly IDetranConsultarPontuacaoFactory _Factory;

        public DetranConsultarPontuacaoServices(IDetranConsultarPontuacaoFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<Pontuacao>> ConsultarPontuacao(Habilitacao habilitacao)
        {
            IDetranConsultarPontuacaoRepository repository = _Factory.Create(habilitacao.UF);
            return repository.ConsultarPontuacao(habilitacao);
        }
    }
}
