using System.Collections.Generic;
using Projeto_Produtos.Classes;

namespace Projeto_Produtos.intefaces
{
    public interface IProduto
    {
        string Cadastrar(Produto produto);
        List<Produto> Listar();
        string Deletar(Produto produto);
    }
}