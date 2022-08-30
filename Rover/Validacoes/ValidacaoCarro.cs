using Rover.Entidades;

namespace Rover.Validacoes
{
    public class ValidacaoCarro
    {
        public bool Sucesso { get; set; }
        public Carro Carro { get; set; }

        public static ValidacaoCarro ValidaCarro(string xyz)
        {
            int n; // Cria uma variável requerida para utilização do TryParse;
            const string letrasValidas = "NSEW";
            const string erroRover = "Digite dois números inteiros não negativos e uma letra que indique a orientação (face) do Rover (N, S, E, W), separados por espaço!!!"; // Cria uma constante utilizada para retornar uma mensagem de erro ao usuário;

            var validacao = new ValidacaoCarro();
            validacao.Carro = new Carro();            

            if (string.IsNullOrEmpty(xyz)) // Verifica se o que foi digitado está nulo ou vazio;
            {
                Console.WriteLine(erroRover);
                xyz = Console.ReadLine();
            }

            var coordenadas = xyz.Trim().Split(" "); // Remove espaços iniciais e finais e cria uma lista com os valores digitados acima, separados por espaço;

            if (coordenadas.Count() != 3) // Verifica a quantidade de valores digitados;
            {
                Console.WriteLine(erroRover);
            }

            else if (!letrasValidas.Contains(coordenadas[2].ToUpper())) // Verifica se o terceiro valor não é uma das letras definidas na constante letrasValidas;
            {
                Console.WriteLine(erroRover);
            }

            else if (Int32.TryParse(coordenadas[0], out n) && Int32.TryParse(coordenadas[1], out n)) // Transforma o primeiro e segundo valores digitados em inteiros;
            {
                
                validacao.Carro.PosicaoX = Convert.ToInt32(coordenadas[0]); // Atribui o primeiro valor digitado à coordenada x do rover;
                validacao.Carro.PosicaoY = Convert.ToInt32(coordenadas[1]); // Atribui o segundo valor digitado à coordenada y do rover;
                validacao.Carro.Orientacao = coordenadas[2]; // Atribui o terceiro valor digitado à orientação do rover;


                // Exibe e solicita confirmação dos valores digitados pelo usuário;
                //const string erroConfirmacao = "Informe as coordenadas da posição inicial novamente: ";

                //Console.WriteLine("Posição x: {0} / Posição y: {1} / Face: {2}", validacao.Rover.PositionX, validacao.Rover.PositionY, coordenadas[2]);
                //Console.WriteLine("Confirma? S ou N");

                //var confirmacao = ValidaConfirmacao.Confirma(erroConfirmacao);
                //while (!confirmacao)
                //    confirmacao = ValidaConfirmacao.Confirma(erroConfirmacao);

                validacao.Sucesso = true;
            }      

            else
            {
                Console.WriteLine(erroRover);
            }

            return validacao;
        }
    }
}
