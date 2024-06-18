using System;

class Program
{
    public static void Main()
    {
        // Criação de um autor
        Autor autor = new Autor("J.K. Rowling", "Britânica");

        // Criação de um livro com preço inicial
        Livro livro1 = new Livro("Harry Potter e a Pedra Filosofal", autor, 39.90);
        
        // Criação de um livro sem preço inicial (preço padrão é 0.0)
        Livro livro2 = new Livro("Harry Potter e a Câmara Secreta", autor);

        // Mostrando informações dos livros
        Console.WriteLine("Informações do Livro 1:");
        livro1.MostrarInfo();
        
        Console.WriteLine("\nInformações do Livro 2:");
        livro2.MostrarInfo();

        // Aplicando desconto por porcentagem no primeiro livro
        livro1.AplicarDesconto(10.0);
        Console.WriteLine("\nPreço do Livro 1 após 10% de desconto:");
        livro1.MostrarInfo();

        // Aplicando desconto por valor fixo no segundo livro
        livro2.AplicarDesconto(5);
        Console.WriteLine("\nPreço do Livro 2 após desconto fixo de 5 unidades:");
        livro2.MostrarInfo();
    }
}
