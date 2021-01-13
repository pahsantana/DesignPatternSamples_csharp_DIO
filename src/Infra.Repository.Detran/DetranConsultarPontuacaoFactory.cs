using DesignPatternSamples.Application.Repository;
using System;
using System.Collections.Generic;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranConsultarPontuacaoFactory : IDetranConsultarPontuacaoFactory
    {
        private readonly IServiceProvider _ServiceProvider;
        private readonly IDictionary<string, Type> _Repositories = new Dictionary<string, Type>();

        public DetranConsultarPontuacaoFactory(IServiceProvider serviceProvider)
        {
            _ServiceProvider = serviceProvider;
        }

        public IDetranConsultarPontuacaoRepository Create(string UF)
        {
            IDetranConsultarPontuacaoRepository result = null;

            if (_Repositories.TryGetValue(UF, out Type type))
            {
                result = _ServiceProvider.GetService(type) as IDetranConsultarPontuacaoRepository;
            }

            return result;
        }

        public IDetranConsultarPontuacaoFactory Register(string UF, Type repository)
        {
            if (!_Repositories.TryAdd(UF, repository))
            {
                _Repositories[UF] = repository;
            }

            return this;
        }
    }
}
