using Projeto_Produtos.Classes;

namespace Projeto_Produtos.intefaces
{
    public interface Imarca
    {
        string Cadastrar(Marca marca);
        void Listar();

        string Deletar(Marca marca);
    }
}