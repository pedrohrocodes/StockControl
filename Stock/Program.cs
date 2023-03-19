using System;
using System.Globalization;

namespace Stock {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Preço: ");
            var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            var quantity = int.Parse(Console.ReadLine());

            var product = new Product(name, price, quantity);

            Console.WriteLine($"Dados do produto: {product}\n");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            var addToStock = int.Parse(Console.ReadLine());

            product.AddProduct(addToStock);

            Console.WriteLine($"Dados atualizados: {product}\n");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            var removeToStock = int.Parse(Console.ReadLine());

            product.RemoveProduct(removeToStock);

            Console.WriteLine($"Dados atualizados: {product}");
        }
    }
}
