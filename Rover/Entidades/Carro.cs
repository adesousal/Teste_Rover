
namespace Rover.Entidades
{
    public class Carro
    {
        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }
        public string Orientacao { get; set; }

        public static string MovimentaCarro(Mapa mapa, Carro carro, string instrucao)
        {
            foreach (char c in instrucao) // Percorre cada caracter (letra) da instrução fornecida pelo usuário;
            {
                switch (c.ToString().ToUpper()) // Transforma a letra em string e a deixa em maiúscula;
                {
                    case "L": // Compara a letra da instrução com a letra L, caso não seja, segue para o próximo;
                        switch (carro.Orientacao.ToUpper()) // Caso seja L, tranforma a letra que representa a orientação do rover, em maiúscula;
                        {
                            case "N": // Caso a letra que representa a orientação do rover se N, muda sua orientação para W, caso não, segue para o próximo e sucessivamente;
                                carro.Orientacao = "W";
                                break;
                            case "W":
                                carro.Orientacao = "S";
                                break;
                            case "S":
                                carro.Orientacao = "E";
                                break;
                            case "E":
                                carro.Orientacao = "N";
                                break;
                        }
                        break;

                    case "R": // Mesmo caso do L acima;
                        switch (carro.Orientacao.ToUpper())
                        {
                            case "N":
                                carro.Orientacao = "E";
                                break;
                            case "E":
                                carro.Orientacao = "S";
                                break;
                            case "S":
                                carro.Orientacao = "W";
                                break;
                            case "W":
                                carro.Orientacao = "N";
                                break;
                        }
                        break;

                    case "M": // Caso M, o rover "movimenta-se" pelo platô e de acordo com sua orientação, altera-se sua coordenada x ou y;
                        switch (carro.Orientacao.ToUpper())
                        {
                            case "N":
                                carro.PosicaoY = carro.PosicaoY + 1;
                                if (carro.PosicaoY > mapa.MapY)
                                    return "Erro: ";
                                break;
                            case "E":
                                carro.PosicaoX = carro.PosicaoX + 1;
                                if (carro.PosicaoX > mapa.MapX)
                                    return "Erro: ";
                                break;
                            case "S":
                                carro.PosicaoY = carro.PosicaoY - 1;
                                if (carro.PosicaoY < 0)
                                    return "Erro: ";
                                break;
                            case "W":
                                carro.PosicaoX = carro.PosicaoX - 1;
                                if (carro.PosicaoX < 0)
                                    return "Erro: ";
                                break;
                        }
                        break;
                }
            }

            return carro.PosicaoX.ToString() + " " + carro.PosicaoY.ToString() + " " + carro.Orientacao.ToUpper(); // Retorna as coordenadas e orientação do rover como string;
        }
    }
}
