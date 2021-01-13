using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Infra.Repository.Detran;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace DesignPatternsSamples.Infra.Repository.Detran.Tests
{
    public class DetranConsultarPontuacaoFactoryTests : IClassFixture<DependencyInjectionFixture>
    {
        private readonly IDetranConsultarPontuacaoFactory _Factory;

        public DetranConsultarPontuacaoFactoryTests(DependencyInjectionFixture dependencyInjectionFixture)
        {
            var serviceProvider = dependencyInjectionFixture.ServiceProvider;
            _Factory = serviceProvider.GetService<IDetranConsultarPontuacaoFactory>();
        }

        [Theory(DisplayName = "Dado um UF que está devidamente registrado no Factory devemos receber a sua implementação correspondente")]
        [InlineData("SP", typeof(DetranSPConsultarPontuacaoRepository))]
        [InlineData("RJ", typeof(DetranRJConsultarPontuacaoRepository))]
        public void InstanciarServicoPorUFRegistrado(string uf, Type implementacao)
        {
            var resultado = _Factory.Create(uf);

            Assert.NotNull(resultado);
            Assert.IsType(implementacao, resultado);
        }

        [Fact(DisplayName = "Dado um UF que não está registrado no Factory devemos receber NULL")]
        public void InstanciarServicoPorUFNaoRegistrado()
        {
            IDetranConsultarPontuacaoRepository implementacao = _Factory.Create("CE");

            Assert.Null(implementacao);
        }
    }
}
