using System;
using System.Collections.Generic;

namespace POO_de_Produtos.classes
{
    public class Marca
    {
        public int Codigo {get;set;}
        public string NomeMarca {get;set;}
        public DateTime DataCadastro {get;set;}

        public List<Marca> ListaDeMarcas = new List<Marca>();

        public Marca Cadastrar(){
            Marca novaMarca = new Marca();
            Console.WriteLine("Digite o codigo da Marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da Marca: ");
            novaMarca.NomeMarca = Console.ReadLine();

            
            DataCadastro = DateTime.Today;
            ListaDeMarcas.Add(novaMarca);
            return novaMarca;

        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            foreach (Marca item in ListaDeMarcas)
            {
                System.Console.WriteLine($"Codigo: {item.Codigo}");
                System.Console.WriteLine($"Marca: {item.NomeMarca}");
                System.Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
            }
            
            
            Console.ResetColor();
        }
        public void Deletar(int cod){
            Marca marcaDelete = ListaDeMarcas.Find(m => m.Codigo == cod);
            ListaDeMarcas.Remove(marcaDelete);
        }
        

    }
}