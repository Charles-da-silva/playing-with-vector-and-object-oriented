
namespace Projeto
{
    class Quartos
    {
        public string NomeLocatario { get; set; }
        public string Email { get; set; }

        public Quartos(string nomeEstudante, string email)
        {
            NomeLocatario = nomeEstudante;
            Email = email;
        }
    }    
}