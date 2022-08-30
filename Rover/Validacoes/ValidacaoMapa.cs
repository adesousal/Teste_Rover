using Rover.Entidades;

namespace Rover.Validacoes
{
    public class ValidacaoMapa
    {
        public bool Sucesso { get; set; }
        public Mapa Plato { get; set; }

        public static ValidacaoMapa ValidaMapa(string xy)
        {
            int n; // Cria uma variável requerida para utilização do TryParse;
            const string erroMapa = "Digite dois números inteiros não negativos, separados por espaço!!!"; // Cria uma constante utilizada para retornar uma mensagem de erro ao usuário;
            
            var validacao = new ValidacaoMapa();
            validacao.Plato = new Mapa();

            
            if (string.IsNullOrEmpty(xy)) // Verifica se o que foi digitado está nulo ou vazio;
            {
                Console.WriteLine(erroMapa);
                xy = Console.ReadLine();
            }
            
            var coordenadas = xy.Trim().Split(" "); // Remove espaços iniciais e finais e cria uma lista com os valores digitados acima, separados por espaço;

            if (coordenadas.Count() != 2) // Verifica a quantidade de valores digitados;
            {
                Console.WriteLine(erroMapa);
            }
            else if (Int32.TryParse(coordenadas[0], out n) && Int32.TryParse(coordenadas[1], out n)) // Transforma os valores digitados em inteiros;
            {
                
                validacao.Plato.MapX = Convert.ToInt32(coordenadas[0]); // Atribui o primeiro valor digitado à coordenada x do platô;
                validacao.Plato.MapY = Convert.ToInt32(coordenadas[1]); // Atribui o segundo valor digitado à coordenada y do platô;        


                // Exibe e solicita confirmação dos valores digitados pelo usuário;
                //const string erroConfirmacao = "Digite as coordenadas do canto superior direito do platô novamente: ";

                //Console.WriteLine("Posição x: {0} / Posição y: {1}", validacao.Plato.MapX, validacao.Plato.MapY);
                //Console.WriteLine("Confirma? S ou N");

                //var confirmacao = ValidaConfirmacao.Confirma(erroConfirmacao);
                //while (!confirmacao)
                //    confirmacao = ValidaConfirmacao.Confirma(erroConfirmacao);

                validacao.Sucesso = true;
            }
            else
            {
                Console.WriteLine(erroMapa);
            }

            return validacao;
        }
    }
}
