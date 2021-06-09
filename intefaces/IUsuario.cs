using Projeto_Produtos.Classes;

namespace Projeto_Produtos.intefaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario usuario);
        string Deletar(Usuario usuario);
    }
}