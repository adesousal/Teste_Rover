// See https://aka.ms/new-console-template for more information

using Rover.Entidades;
using Rover.Validacoes;

#region Objetos
var mapa = new Mapa(); // Cria um instância do Mapa (platô);
var rover1 = new Carro(); // Cria uma instância do rover;
var rover2 = new Carro(); // Cria outra instância do rover;
#endregion

#region Mapa

Console.WriteLine("Informe as coordenadas do canto superior direito do platô: *(Dois números inteiros não negativos, separados por espaço)");

var xy = Console.ReadLine(); // Lê o que o usuário digitar;

var validacaoMapa = ValidacaoMapa.ValidaMapa(xy); // Chama método que valida os dados informados pelo usuário;

while (!validacaoMapa.Sucesso) // Equanto o usuário não digitar valores válidos, continuará solicitando que os digite até que atenda as condições;
{
    xy = Console.ReadLine();
    validacaoMapa = ValidacaoMapa.ValidaMapa(xy);
}

mapa.MapX = validacaoMapa.Plato.MapX; // Atribui o primeiro valor digitado ao atributo que representa a coordenada x do canto superior direito do mapa (platô);
mapa.MapY = validacaoMapa.Plato.MapY; // Atribui o segundo valor digitado ao atributo que representa a coordenada y do canto superior direito do mapa (platô);

#endregion

#region PrimeiroRover

Console.WriteLine("Informe as coordenadas da posição inicial do primeiro rover: ");

var xyz = Console.ReadLine(); // Lê o que o usuário digitar;

var validacaoRover1 = ValidacaoCarro.ValidaCarro(xyz); // Chama método que valida os dados informados pelo usuário;

while (!validacaoRover1.Sucesso) // Equanto o usuário não digitar valores válidos, continuará solicitando que os digite até que atenda as condições;
{
    xyz = Console.ReadLine();
    validacaoRover1 = ValidacaoCarro.ValidaCarro(xyz);
}

rover1.PosicaoX = validacaoRover1.Carro.PosicaoX; // Atribui o primeiro valor digitado ao atributo que representa a coordenada x da posição inicial do primeiro rover;
rover1.PosicaoY = validacaoRover1.Carro.PosicaoY; // Atribui o segundo valor digitado ao atributo que representa a coordenada y da posição inicial do primeiro rover;
rover1.Orientacao = validacaoRover1.Carro.Orientacao; // Atribui o terceiro valor digitado ao atributo que representa a orientação na posição inicial do primeiro rover;

Console.WriteLine("Informe as instruções para a movimentação do primeiro rover: ");

var instrucaoPrimeiroCarro = Console.ReadLine(); // Lê a instrução fornecida pelo usuário;

var validacaoInstrucao1 = ValidacaoInstrucao.ValidaInstrucao(instrucaoPrimeiroCarro); // Chama método que valida os dados informados pelo usuário;

while (!validacaoInstrucao1.Sucesso)
{
    instrucaoPrimeiroCarro = Console.ReadLine();
    validacaoInstrucao1 = ValidacaoInstrucao.ValidaInstrucao(instrucaoPrimeiroCarro);
}
 
var saidaRover1 = Carro.MovimentaCarro(mapa, rover1, validacaoInstrucao1.Instrucao); // Chama método que "movimenta" o rover sobre o mapa (platô);

#endregion

#region SegundoRover

Console.WriteLine("Informe as coordenadas da posição inicial do segundo rover: ");

var abc = Console.ReadLine();

var validacaoRover2 = ValidacaoCarro.ValidaCarro(abc);

while (!validacaoRover2.Sucesso) // Equanto o usuário não digitar valores válidos, continuará solicitando que os digite até que atenda as condições;
{
    abc = Console.ReadLine();
    validacaoRover2 = ValidacaoCarro.ValidaCarro(abc);
}

// Repeticão do processo do primeiro rover para o segundo rover;

rover2.PosicaoX = validacaoRover2.Carro.PosicaoX;
rover2.PosicaoY = validacaoRover2.Carro.PosicaoY;
rover2.Orientacao = validacaoRover2.Carro.Orientacao;

Console.WriteLine("Informe as instruções para a movimentação do segundo rover: ");

var instrucaoSegundoCarro = Console.ReadLine();

var validacaoInstrucao2 = ValidacaoInstrucao.ValidaInstrucao(instrucaoSegundoCarro);

while (!validacaoInstrucao2.Sucesso)
{
    instrucaoSegundoCarro = Console.ReadLine();
    validacaoInstrucao2 = ValidacaoInstrucao.ValidaInstrucao(instrucaoSegundoCarro);
}

var saidaRover2 = Carro.MovimentaCarro(mapa, rover2, validacaoInstrucao2.Instrucao);

#endregion

#region Saída

if (saidaRover1.Contains("Erro"))
    Console.WriteLine(saidaRover1 + "o primeiro rover movimentou-se para fora do platô");
else
Console.WriteLine("As coordenadas da posição final do primeiro rover são: " + saidaRover1); // Exibe a coordenada final do primeiro rover.

if (saidaRover2.Contains("Erro"))
    Console.WriteLine(saidaRover2 + "o segundo rover movimentou-se para fora do platô");
else
Console.WriteLine("As coordenadas da posição final do segundo rover são: " + saidaRover2); // Exibe a coordenada final do segundo rover.

#endregion









