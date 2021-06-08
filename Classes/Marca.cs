using System;
using System.Collections.Generic;
using Projeto_Produtos.intefaces;

namespace Projeto_Produtos.Classes 
{
    public class Marca : Imarca
    {    
        public int Codigo; 
        public string NomeMarca;
        
        public DateTime DataCadastro;
        
        List<Marca> Marcas = new List<Marca>();

        public string Cadastrar(Marca marca)
        {
            Marcas.Add(marca);
            return $"A marca {marca} foi adcionada com sucesso";
        }

        public string Deletar(Marca marca)
        {
            Marcas.Remove(marca);
            return $"A marca {marca} foi removida com sucesso";
        }

        public void Listar()
        {
            foreach(Marca m in Marcas){
                Console.WriteLine(m.Marcas);
            }
        }
    }
}