using System;
using System.Collections.Generic;
using Projeto_Produtos.intefaces;

namespace Projeto_Produtos.Classes
{
    public class Produto : IProduto
    {
        private int Codigo;
        
        public string NomeProduto { get; set; }
        
        private float Preço;
        
        private DateTime DataCadastro;
        
        public Marca marca;
        public Usuario CadastradoPor { get; set; }

        List<Produto> ListaDeProdutos = new List<Produto>();
        Usuario u = new Usuario();
        Marca m = new Marca();
        public Produto(){
            
        }
        public Produto(int _codigo){
            Codigo = _codigo;
        }
        public Produto(int _codigo, string _nome, float _preço, Marca _marca){
            Codigo = _codigo;
            NomeProduto =  _nome;
            Preço = _preço;
            marca = _marca;
            // CadastradoPor = u.Nome;
        }

        public string Cadastrar(Produto Produto)
        {
            ListaDeProdutos.Add(Produto);
            return "Produto Cadastrado";
        }


        public string Deletar(Produto Produto)
        {
            ListaDeProdutos.Remove(ListaDeProdutos.Find(x => x.Codigo == Codigo));;
            return "Produto Deletado com sucesso";
        }
        public List<Produto> Listar()
        {
            foreach(Produto p in ListaDeProdutos){
                Console.WriteLine($@"{p.NomeProduto} - {p.Preço:C2} - {m.NomeMarca}");
            }
            return ListaDeProdutos;
        }
    }
}