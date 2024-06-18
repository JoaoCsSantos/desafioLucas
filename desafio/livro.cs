public class Livro
{
    public string Titulo { get; set; }
    public Autor Autor { get; set; }
    public double Preco { get; set; }

    public Livro(string titulo, Autor autor)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = 0.0; // Preço padrão
    }

    public Livro(string titulo, Autor autor, double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Autor.MostrarInfo();
        Console.WriteLine($"Preço: {Preco:C}");
    }

    public void AplicarDesconto(double porcentagemDesconto)
    {
        Preco -= Preco * (porcentagemDesconto / 100);
    }

    public void AplicarDesconto(int valorFixoDesconto)
    {
        Preco -= valorFixoDesconto;
    }
}
