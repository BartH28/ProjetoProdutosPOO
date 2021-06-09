using Projeto_Produtos.Classes;

namespace Projeto_Produtos.intefaces
{
    public interface ILogin
    {
        
        string Logar(Usuario usuario);
        string Deslogar(Usuario usuario);
    }
}