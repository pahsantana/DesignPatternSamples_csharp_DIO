using System;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranConsultarPontuacaoFactory
    {
        public IDetranConsultarPontuacaoFactory Register(string UF, Type repository);
        public IDetranConsultarPontuacaoRepository Create(string UF);
    }
}
