using System;

namespace Gerenciamento_de_Estoque
{
	
	public class Produto
	{
	  public int Codigo { get; set; }
      public string Nome { get; set; }
      public string Categoria { get; set; }
      public decimal Preco { get; set; }
      public int Quantidade { get; set; }

      public decimal ValorEmEstoque
      {
        get { return Preco * Quantidade; }
      }

      public Produto(int codigo, string nome, string categoria, decimal preco, int quantidade)
      {
        Codigo = codigo;
        Nome = nome;
        Categoria = categoria;
        Preco = preco;
        Quantidade = quantidade;
	}
  }
}