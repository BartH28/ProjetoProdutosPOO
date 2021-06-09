using System;
using Projeto_Produtos.intefaces;
using System.Collections.Generic;

namespace Projeto_Produtos.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo;
        public string Nome;
        public string Email;
        public string Senha;
        private DateTime DataCadastro;

        List<Usuario> ListaU = new List<Usuario>();

        public Usuario(){}
        public Usuario(int _codigo){
            Codigo = _codigo;
        }
        public Usuario(int _codigo ,string _nome , string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.Now;
        }
        public string Cadastrar(Usuario usuario)
        {
            ListaU.Add(usuario);    
            return "A conta foi cadastrada com sucesso";
        }

        public string Deletar(Usuario usuario)
        {
            ListaU.Remove(usuario);
            return "Conta deletada com sucesso";
        }
    }
}