using Rover.Entidades;
using Rover.Validacoes;

namespace Rover.Tests
{
    public class RoverTests
    {
        [Fact]
        public void ValidaMapa()
        {
            var retorno = new ValidacaoMapa()
            {
                Sucesso = true,
                Plato = new Mapa()
                {
                    MapX = 3,
                    MapY = 3
                }

            };
            Object.Equals(retorno, ValidacaoMapa.ValidaMapa("3 3"));
        }

        [Fact]
        public void ValidaRover()
        {
            var retorno = new ValidacaoCarro()
            {
                Sucesso = true,
                Carro = new Carro()
                {
                    PosicaoX = 1,
                    PosicaoY = 3,
                    Orientacao = "S"
                }

            };
            Object.Equals(retorno, ValidacaoCarro.ValidaCarro("1 1 S"));
        }

        [Fact]
        public void ValidaInstrucao()
        {
            var retorno = new ValidacaoInstrucao()
            {
                Sucesso = true,
                Instrucao = "LMRMMLMR"

            };
            Object.Equals(retorno, ValidacaoInstrucao.ValidaInstrucao("LMRMMLMR"));
        }

        [Fact]
        public void MovimentaCarro()
        {
            var mapa = new Mapa()
            {
                MapX = 5,
                MapY = 5
            };

            var carro = new Carro()
            {
                PosicaoX = 1,
                PosicaoY = 2,
                Orientacao = "N"
            };

            var orientacao = "LMLMLMLMM";

            Object.Equals("1 3 N", Carro.MovimentaCarro(mapa, carro, orientacao));
        }
    }
}