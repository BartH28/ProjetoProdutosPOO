using System;
using Projeto_Produtos.intefaces;

namespace Projeto_Produtos.Classes
{
    public class Login : ILogin
    {
        private bool Logado = false;
        Produto p = new Produto();
        Marca Marcas = new Marca();
        Usuario u = new Usuario();
        public string Deslogar(Usuario u)
        {
            Logado = false;
            return "O usuario foi deslogado";
        }
        public string Logar(Usuario u)
        {
            do
            {
                Console.WriteLine("Insira sua senha: ");
                string _senha = Console.ReadLine();
                Console.WriteLine("Insira seu email: ");
                string _email = Console.ReadLine();
                if (u.Senha == _senha && u.Email == _email)
                {
                    Logado = true;
                }
                else
                {
                    Logado = false;
                    Console.WriteLine("Este usuario nao existe");
                }
            } while (Logado == false);
            return "Logado com sucesso";
        }
        public Login()
        {
            bool repetir = false;
            Console.WriteLine($@"
                BEM VINDO 
                   AO
          Sistemas de Produtos 

Precione qualquer botão para se cadastrar.          
            ");
            Console.ReadKey();
            Console.WriteLine("\nEscolha um Codigo para o usuario: ");
            int __codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha um Nome para o usuario: ");
            string __nome = Console.ReadLine();
            Console.WriteLine("Escolha um Email para o usuario: ");
            string __email = Console.ReadLine();
            Console.WriteLine("Escolha uma Senha para o usuario: ");
            string __senha = Console.ReadLine();
            Usuario CadastroU = new Usuario(__codigo, __nome, __email, __senha);
            u.Cadastrar(CadastroU);
            repetir = true;
            Console.WriteLine("Agora Faça o login da sua conta\n ");

            Console.WriteLine(Logar(CadastroU));
            do
            {
                Console.WriteLine($@"
Sistema de Produtos

1 - Adicionar Produto
2 - Deletar Produto
3 - Listar produto
4 - Deslogar
                    ");
                string resp2 = Console.ReadLine();
                switch (resp2)
                {
                    case "1":
                        Console.WriteLine("Escolha um Codigo para o Produto: ");
                        int Pcodigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do Produto: ");
                        string Pnome = Console.ReadLine();
                        Console.WriteLine("Escolha um preço para o Produto: ");
                        float Ppreço = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Escolha de Marca do Produto ({Pnome})");
                        Console.WriteLine($@"Voce deve cadastrar uma marca para o produto {Pnome}!\n");
                        bool rep45 = false;
                        do
                        {
                            Marcas.Listar();
                            Console.WriteLine($@"O que deseja fazer?");
                            Console.WriteLine($@"
1 - Remover marca
2 - Adcionar mais marcas                           
                                                     ");
                            string resp3 = Console.ReadLine();

                            switch (resp3)
                            {
                                case "1":
                                    Console.WriteLine("Digite o codigo da marca que deseja deletar: ");
                                    int _MCodigo = int.Parse(Console.ReadLine());
                                    Marca mcodigo = new Marca(_MCodigo);
                                    Console.WriteLine(Marcas.Deletar(mcodigo));
                                    rep45 = true;
                                    break;
                                case "2":
                                    Console.WriteLine("Digite o codigo da Marca: ");
                                    int Mcodigo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o nome da Marca: ");
                                    string Mnome = Console.ReadLine();
                                    Marca m = new Marca(Mcodigo, Mnome);
                                    Console.WriteLine(Marcas.Cadastrar(m));
                                    Produto prod = new Produto(Pcodigo, Pnome, Ppreço, m);
                                    prod.CadastradoPor = CadastroU;
                                    Console.WriteLine(p.Cadastrar(prod));
                                    rep45 = false;
                                    break;
                                default:
                                    rep45 = true;
                                    Console.WriteLine("Alternativa errada");
                                    break;
                            }
                        } while (rep45);
                        break;
                    case "2":
                        Console.WriteLine("Digite o codigo do produto que deseja deletar");
                        int _Pcodigo = int.Parse(Console.ReadLine());
                        Produto pcodigo = new Produto(_Pcodigo);
                        Console.WriteLine(p.Deletar(pcodigo));
                        repetir = true;
                        break;
                    case "3":
                        p.Listar();
                        repetir = true;
                        break;
                    case "4":
                        Console.WriteLine(Deslogar(CadastroU));
                        repetir = false;
                        break;
                    default:
                        break;
                }
            } while (repetir == true);
        }
    }
}
