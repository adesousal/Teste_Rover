
namespace Rover.Validacoes
{
    public  class ValidaConfirmacao
    {
        public static bool Confirma(string mensagem)
        {
            const string erroConfirmacao = "Digite S ou N";

            
            var confirmacao = Console.ReadLine(); // Solicita que o usuário confirme os valores das coordenadas;
            while (string.IsNullOrEmpty(confirmacao))
            {
                Console.WriteLine(erroConfirmacao);
                confirmacao = Console.ReadLine();
            }
            if (confirmacao.Trim().ToUpper() == "S")
                return true;
            else if (confirmacao.Trim().ToUpper() != "N")
            {
                Console.WriteLine(erroConfirmacao);
                return false;
            }
            else
            {
                Console.WriteLine(mensagem);
                return false;
            }                
        }
    }
}
