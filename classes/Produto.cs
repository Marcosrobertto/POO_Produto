using System;
using System.Collections.Generic;

namespace POO_de_Produtos.classes
{
    public class Produto
    {
        public int Codigo {get;set;}
        public string NomeProduto {get;set;}
        public float preco {get;set;}
        public DateTime DataCadastro {get;set;}
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();

        public List<Produto> ListaDeProdutos = new List<Produto>();
        public void Cadastrar(){
            Produto novoProduto = new Produto();
            
            System.Console.WriteLine("Digite o codigo do Produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do Produto: ");
            novoProduto.NomeProduto = Console.ReadLine();
            
            System.Console.WriteLine("Digite o Preco do Produto: ");
            novoProduto.preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.Today;
            
            novoProduto.Marca = Marca.Cadastrar();
            
            novoProduto.CadastradoPor = new Usuario();
            
            ListaDeProdutos.Add(novoProduto);

        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Produto item in ListaDeProdutos)
            {
                System.Console.WriteLine($"Codigo: {item.Codigo}");
                System.Console.WriteLine($"Produto: {item.NomeProduto}");
                System.Console.WriteLine($"Preco: {item.preco}");
                System.Console.WriteLine($"Marca: {item.Marca}");
                System.Console.WriteLine($"Cadastrado Por: {item.CadastradoPor.Nome}");
            }
            Console.ResetColor();
        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete); 
        }


    }
}