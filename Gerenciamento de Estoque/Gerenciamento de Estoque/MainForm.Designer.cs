/*
 * Created by SharpDevelop.
 * User: Alex Junio
 * Date: 27/07/2026
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gerenciamento_de_Estoque
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gboGerenciamentodeEstoque;
		private System.Windows.Forms.DataGridView dgvProdutos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn colValorEmEstoque;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.NumericUpDown nudQuantidade;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.Label lblPesquisar;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.Label lblPreco;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCódigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPreço;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gboGerenciamentodeEstoque = new System.Windows.Forms.GroupBox();
			this.dgvProdutos = new System.Windows.Forms.DataGridView();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.lblPesquisar = new System.Windows.Forms.Label();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.lblPreco = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.colCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colValorEmEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gboGerenciamentodeEstoque.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
			this.SuspendLayout();
			// 
			// gboGerenciamentodeEstoque
			// 
			this.gboGerenciamentodeEstoque.Controls.Add(this.dgvProdutos);
			this.gboGerenciamentodeEstoque.Controls.Add(this.btnSair);
			this.gboGerenciamentodeEstoque.Controls.Add(this.btnLimpar);
			this.gboGerenciamentodeEstoque.Controls.Add(this.btnPesquisar);
			this.gboGerenciamentodeEstoque.Controls.Add(this.btnExcluir);
			this.gboGerenciamentodeEstoque.Controls.Add(this.btnAtualizar);
			this.gboGerenciamentodeEstoque.Controls.Add(this.btnAdicionar);
			this.gboGerenciamentodeEstoque.Controls.Add(this.txtPesquisar);
			this.gboGerenciamentodeEstoque.Controls.Add(this.txtNome);
			this.gboGerenciamentodeEstoque.Controls.Add(this.txtCodigo);
			this.gboGerenciamentodeEstoque.Controls.Add(this.txtPreco);
			this.gboGerenciamentodeEstoque.Controls.Add(this.nudQuantidade);
			this.gboGerenciamentodeEstoque.Controls.Add(this.cmbCategoria);
			this.gboGerenciamentodeEstoque.Controls.Add(this.lblPesquisar);
			this.gboGerenciamentodeEstoque.Controls.Add(this.lblQuantidade);
			this.gboGerenciamentodeEstoque.Controls.Add(this.lblPreco);
			this.gboGerenciamentodeEstoque.Controls.Add(this.lblCategoria);
			this.gboGerenciamentodeEstoque.Controls.Add(this.lblNome);
			this.gboGerenciamentodeEstoque.Controls.Add(this.lblCodigo);
			this.gboGerenciamentodeEstoque.Location = new System.Drawing.Point(12, 12);
			this.gboGerenciamentodeEstoque.Name = "gboGerenciamentodeEstoque";
			this.gboGerenciamentodeEstoque.Size = new System.Drawing.Size(1179, 692);
			this.gboGerenciamentodeEstoque.TabIndex = 0;
			this.gboGerenciamentodeEstoque.TabStop = false;
			this.gboGerenciamentodeEstoque.Text = "Sistema de Gerenciamento de Estoque";
			// 
			// dgvProdutos
			// 
			this.dgvProdutos.AllowUserToAddRows = false;
			this.dgvProdutos.AllowUserToDeleteRows = false;
			this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colCódigo,
			this.colNome,
			this.colCategoria,
			this.colPreço,
			this.colQuantidade,
			this.colValorEmEstoque});
			this.dgvProdutos.EnableHeadersVisualStyles = false;
			this.dgvProdutos.Location = new System.Drawing.Point(6, 447);
			this.dgvProdutos.MultiSelect = false;
			this.dgvProdutos.Name = "dgvProdutos";
			this.dgvProdutos.ReadOnly = true;
			this.dgvProdutos.RowHeadersVisible = false;
			this.dgvProdutos.RowTemplate.Height = 24;
			this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProdutos.Size = new System.Drawing.Size(1159, 239);
			this.dgvProdutos.TabIndex = 18;
			this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutosCellContentClick);
			// 
			// btnSair
			// 
			this.btnSair.AutoSize = true;
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSair.Location = new System.Drawing.Point(1025, 392);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(140, 49);
			this.btnSair.TabIndex = 17;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.AutoSize = true;
			this.btnLimpar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnLimpar.Location = new System.Drawing.Point(844, 392);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(140, 49);
			this.btnLimpar.TabIndex = 16;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.AutoSize = true;
			this.btnPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnPesquisar.Location = new System.Drawing.Point(632, 392);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(179, 49);
			this.btnPesquisar.TabIndex = 15;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// btnExcluir
			// 
			this.btnExcluir.AutoSize = true;
			this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnExcluir.Location = new System.Drawing.Point(443, 392);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(140, 49);
			this.btnExcluir.TabIndex = 14;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.AutoSize = true;
			this.btnAtualizar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnAtualizar.Location = new System.Drawing.Point(232, 392);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(160, 49);
			this.btnAtualizar.TabIndex = 13;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = false;
			this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizarClick);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.AutoSize = true;
			this.btnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnAdicionar.Location = new System.Drawing.Point(6, 392);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(170, 49);
			this.btnAdicionar.TabIndex = 12;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = false;
			this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionarClick);
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisar.Location = new System.Drawing.Point(798, 325);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(291, 36);
			this.txtPesquisar.TabIndex = 11;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(373, 147);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(291, 36);
			this.txtNome.TabIndex = 10;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(6, 147);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(291, 36);
			this.txtCodigo.TabIndex = 9;
			// 
			// txtPreco
			// 
			this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPreco.Location = new System.Drawing.Point(6, 325);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(291, 36);
			this.txtPreco.TabIndex = 8;
			// 
			// nudQuantidade
			// 
			this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudQuantidade.Location = new System.Drawing.Point(383, 325);
			this.nudQuantidade.Name = "nudQuantidade";
			this.nudQuantidade.Size = new System.Drawing.Size(291, 36);
			this.nudQuantidade.TabIndex = 7;
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Items.AddRange(new object[] {
			"Informática",
			"Periféricos",
			"Eletrônicos",
			"Escritório",
			"Acessórios",
			"Outros"});
			this.cmbCategoria.Location = new System.Drawing.Point(798, 146);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(291, 37);
			this.cmbCategoria.TabIndex = 6;
			// 
			// lblPesquisar
			// 
			this.lblPesquisar.AutoSize = true;
			this.lblPesquisar.Location = new System.Drawing.Point(798, 283);
			this.lblPesquisar.Name = "lblPesquisar";
			this.lblPesquisar.Size = new System.Drawing.Size(163, 38);
			this.lblPesquisar.TabIndex = 5;
			this.lblPesquisar.Text = "Pesquisar";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Location = new System.Drawing.Point(373, 283);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(185, 38);
			this.lblQuantidade.TabIndex = 4;
			this.lblQuantidade.Text = "Quantidade";
			// 
			// lblPreco
			// 
			this.lblPreco.AutoSize = true;
			this.lblPreco.Location = new System.Drawing.Point(6, 283);
			this.lblPreco.Name = "lblPreco";
			this.lblPreco.Size = new System.Drawing.Size(103, 38);
			this.lblPreco.TabIndex = 3;
			this.lblPreco.Text = "Preço";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(798, 104);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(158, 38);
			this.lblCategoria.TabIndex = 2;
			this.lblCategoria.Text = "Categoria";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(373, 104);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(272, 38);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome do Produto";
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(6, 104);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(120, 38);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código";
			// 
			// colCódigo
			// 
			this.colCódigo.DataPropertyName = "Código";
			this.colCódigo.HeaderText = "Código";
			this.colCódigo.Name = "colCódigo";
			this.colCódigo.ReadOnly = true;
			// 
			// colNome
			// 
			this.colNome.DataPropertyName = "Nome";
			this.colNome.HeaderText = "Nome";
			this.colNome.Name = "colNome";
			this.colNome.ReadOnly = true;
			// 
			// colCategoria
			// 
			this.colCategoria.DataPropertyName = "Categoria";
			this.colCategoria.HeaderText = "Categoria";
			this.colCategoria.Name = "colCategoria";
			this.colCategoria.ReadOnly = true;
			// 
			// colPreço
			// 
			this.colPreço.DataPropertyName = "Preço";
			dataGridViewCellStyle2.Format = "C2";
			this.colPreço.DefaultCellStyle = dataGridViewCellStyle2;
			this.colPreço.HeaderText = "Preço";
			this.colPreço.Name = "colPreço";
			this.colPreço.ReadOnly = true;
			// 
			// colQuantidade
			// 
			this.colQuantidade.DataPropertyName = "Quantidade";
			this.colQuantidade.HeaderText = "Quantidade";
			this.colQuantidade.Name = "colQuantidade";
			this.colQuantidade.ReadOnly = true;
			// 
			// colValorEmEstoque
			// 
			this.colValorEmEstoque.DataPropertyName = "ValorEmEstoque";
			dataGridViewCellStyle3.Format = "C2";
			this.colValorEmEstoque.DefaultCellStyle = dataGridViewCellStyle3;
			this.colValorEmEstoque.HeaderText = "Valor Em Estoque";
			this.colValorEmEstoque.Name = "colValorEmEstoque";
			this.colValorEmEstoque.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1204, 716);
			this.Controls.Add(this.gboGerenciamentodeEstoque);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerenciamento de Estoque";
			this.gboGerenciamentodeEstoque.ResumeLayout(false);
			this.gboGerenciamentodeEstoque.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
