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
        
        public List<Marca> Marcas = new List<Marca>();

        public Marca(){
            
        }
        public Marca(int _codigo){
            Codigo = _codigo;
        }
        public Marca(int _codigo, string Nome){
            Codigo = _codigo;
            NomeMarca = Nome;
            DataCadastro = DateTime.Now;
        }

        public string Cadastrar(Marca Marca)
        {
            Marcas.Add(Marca);
            return $"A marca foi adcionada com sucesso";
        }

        public string Deletar(Marca marca)
        {
            Marcas.Remove(Marcas.Find(x => x.Codigo == marca.Codigo));
            return $"A marca foi removida com sucesso";
        }
        public string Escolher(Marca marca)
        {
            return "Marca selecionada com sucesso";
        }
        public List<Marca> Listar()
        {
            foreach(Marca m in Marcas){
                Console.WriteLine($"||||- Codigo: {m.Codigo} - Nome: {m.NomeMarca} -||||*\n");
            }
            return Marcas;
        }
    }
}