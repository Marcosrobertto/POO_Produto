using System;

namespace POO_de_Produtos.classes
{
    public class Login
    {
        public bool Logado {get;set;}
        
        public Login(){
            Logar();
            if(Logado == true){
                GerarMenu();
            }
        }
        
        public void GerarMenu(){

                Produto produto = new Produto();
                Marca marca = new Marca();
                string opcao = "n";

            do{
                Console.WriteLine($"Escolha uma opção:");
                Console.WriteLine($"1 - Cadastrar Marca");
                Console.WriteLine($"2 - Listar Marca");
                Console.WriteLine($"3 - Excluir Marca");
                Console.WriteLine($"4 - Cadastrar Produto");
                Console.WriteLine($"5 - Listar Produto");
                Console.WriteLine($"6 - Excluir Produto");
                Console.WriteLine($"0 - Sair");

                opcao = Console.ReadLine();

                switch(opcao){
                    case "1":
                    marca.Cadastrar();
                        break;
                    case "2":
                    marca.Listar();
                        break;
                    case "3":
                    System.Console.WriteLine("Digite um codigo para excluir a marca");
                    int codigo = int.Parse(Console.ReadLine());
                    marca.Deletar(codigo);
                        break;
                    case "4":
                    produto.Cadastrar();
                        break;
                    case "5":
                    produto.Listar();
                        break;
                    case "6":
                    System.Console.WriteLine("Digite um codigo para excluir um produto");
                    int codigoProduto = int.Parse(Console.ReadLine());
                    marca.Deletar(codigoProduto);
                        break;
                }


            }while(opcao != "0");


        }

        public void Logar(){

            Usuario user = new Usuario();
            System.Console.WriteLine("Digite seu email: ");
            string emailLogin =Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senhaLogin =Console.ReadLine();

            if(emailLogin == user.Email && senhaLogin == user.Senha){
                Logado = true;
                System.Console.WriteLine("Login efetuado com sucesso!");

            }else{
                System.Console.WriteLine("Falha ao realzar o Login, tente novamente.");
            }


        }
        public void Deslogar(){
            Logado = false;
        }
    }
}