using System.Collections.Generic;
using Projeto_Produtos.Classes;

namespace Projeto_Produtos.intefaces
{
    public interface Imarca
    {
        string Cadastrar(Marca marca);
        List<Marca> Listar();

        string Deletar(Marca marca);
    }
}