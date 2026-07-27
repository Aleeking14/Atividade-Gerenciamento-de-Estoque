using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Gerenciamento_de_Estoque
{
	
	public partial class MainForm : Form
	{
		 List<Produto> produtos = new List<Produto>();
		 Produto produtoSelecionado = null;
		
		public MainForm()
		{
			
			InitializeComponent();
		}
		void BtnAdicionarClick(object sender, EventArgs e)
		{
	       int codigo;
           decimal preco;

    if (!int.TryParse(txtCodigo.Text, out codigo))
    {
        MessageBox.Show("Informe um código válido."); 
        return;
    }

    if (txtNome.Text == "")
    {
        MessageBox.Show("Digite o nome do produto.");
        return;
    }

    if (cmbCategoria.SelectedIndex == 0)
    {
        MessageBox.Show("Selecione uma categoria.");
        return;
    }

    if (!decimal.TryParse(txtPreco.Text, out preco) || preco <= 0)
    {
        MessageBox.Show("Informe um preço válido.");
        return;
    }

    if (produtos.Any(p => p.Codigo == codigo))
    {
        MessageBox.Show("Já existe um produto com esse código.");
        return;
    }

    Produto produto = new Produto(
        codigo,
        txtNome.Text,
        cmbCategoria.Text,
        preco,
        (int)nudQuantidade.Value
    );

      produtos.Add(produto);
      AtualizarDataGrid();
      LimparCampos();

        MessageBox.Show("Produto cadastrado com sucesso!");
	}
		
		void AtualizarDataGrid()
      {
        dgvProdutos.DataSource = null;
        dgvProdutos.DataSource = produtos;
      }
   
	  void LimparCampos()
      {
        txtCodigo.Clear();
        txtNome.Clear();
        txtPreco.Clear();
        txtPesquisar.Clear();

        cmbCategoria.SelectedIndex = 0;
        nudQuantidade.Value = 0;

        txtCodigo.Focus(); 
      }
		void DgvProdutosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
           if (e.RowIndex >= 0)
    {
        produtoSelecionado = produtos[e.RowIndex];

        txtCodigo.Text = produtoSelecionado.Codigo.ToString();
        txtNome.Text = produtoSelecionado.Nome;
        cmbCategoria.Text = produtoSelecionado.Categoria;
        txtPreco.Text = produtoSelecionado.Preco.ToString();
        nudQuantidade.Value = produtoSelecionado.Quantidade;
		}
		
	 }
		void BtnAtualizarClick(object sender, EventArgs e)
		{
	        if (produtoSelecionado == null)
    {
        MessageBox.Show("Selecione um produto.");
        return;
    }

       produtoSelecionado.Nome = txtNome.Text;
       produtoSelecionado.Categoria = cmbCategoria.Text;
       produtoSelecionado.Preco = decimal.Parse(txtPreco.Text);
       produtoSelecionado.Quantidade = (int)nudQuantidade.Value;

       AtualizarDataGrid();

       MessageBox.Show("Produto atualizado com sucesso!");

       LimparCampos();
	  }
		void BtnExcluirClick(object sender, EventArgs e)
		{
	         if (produtoSelecionado == null)
    {
        MessageBox.Show("Selecione um produto.");
        return;
    }

    DialogResult resposta = MessageBox.Show(
        "Deseja excluir este produto?",
        "Confirmação",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

    if (resposta == DialogResult.Yes)
    {
        produtos.Remove(produtoSelecionado);

        AtualizarDataGrid();

        LimparCampos();

        produtoSelecionado = null;

        MessageBox.Show("Produto excluído.");
		}
	  }
		void BtnPesquisarClick(object sender, EventArgs e)
		{
	         string pesquisa = txtPesquisar.Text.ToLower();

    List<Produto> lista = new List<Produto>();

    foreach (Produto p in produtos)
    {
        if (p.Nome.ToLower().Contains(pesquisa)
            || p.Categoria.ToLower().Contains(pesquisa)
            || p.Codigo.ToString().Contains(pesquisa))
        {
            lista.Add(p);
        }
    }
           dgvProdutos.DataSource = null;
           dgvProdutos.DataSource = lista;
		}
		void BtnLimparClick(object sender, EventArgs e)
		{
	         LimparCampos();

             produtoSelecionado = null;

             AtualizarDataGrid();
		}
		void BtnSairClick(object sender, EventArgs e)
		{
	          DialogResult resposta = MessageBox.Show(
        "Deseja realmente sair?",
        "Confirmação",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

      if (resposta == DialogResult.Yes)
      {
        this.Close();
      }
		}
   }
}