using System;
using MetodosConstrutores.classes;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.Code = 7; 
            produto1.Name = "Fanta Laranja"; 
            produto1.Description = "Refrigerante sabor laranja";
            Console.WriteLine($"Código do produto: {produto1.Code} - Nome do Produto: {produto1.Name} - Descrição do produto: {produto1.Description}");

            Produto produto2 = new Produto(1);
            Console.WriteLine($"Código do Produto: {produto2.Code}");

            Produto produto3 = new Produto(1,"Café Pilão","Café Tradicional 500g",200);
            Console.WriteLine($"Código do produto: {produto3.Code} - Nome do produto: {produto3.Name} - Descrição do produto: {produto3.Description} - Estoque do produto: {produto3.Stock}");
        }
    }
}
