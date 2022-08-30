
namespace Rover.Validacoes
{
    public class ValidacaoInstrucao
    {
        public bool Sucesso { get; set; }
        public string Instrucao { get; set; }

        public static ValidacaoInstrucao ValidaInstrucao(string leitura)
        {
            var instrucao = new ValidacaoInstrucao();
            const string erroInstrucao = "Digite apenas as letras: L, R e M, sem espaços!!!";
            const string letrasValidas = "LRM";            

            while (string.IsNullOrEmpty(leitura)) // Verifica se a instrução é nula ou vazia;
            {
                Console.WriteLine(erroInstrucao);
                leitura = Console.ReadLine();
            }

            instrucao.Instrucao = leitura.Trim(); // Remove os espaços iniciais e finais;

            var erro = 0; // Variável criada para contagem de erros;

            foreach (char c in instrucao.Instrucao) // Percorre cada caracter (letra) da instrução fornecida pelo usuário;
            {
                
                if (!Char.IsLetter(c)) // Verifica se o caracter não é letra;
                {
                    Console.WriteLine(erroInstrucao);
                    erro++; // Incrementa a variável erro somando 1 ao seu valor;
                }
                else if (!letrasValidas.Contains(c.ToString().ToUpper())) // Verifica se o caracter não é uma das letras definidas na constante letrasValidas;
                {
                    Console.WriteLine(erroInstrucao);
                    erro++;
                }
            }

            if(erro == 0)
                instrucao.Sucesso = true;

            return instrucao;
        }       
    }
}
