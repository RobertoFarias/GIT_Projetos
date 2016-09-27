using Relacionamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Categoria> categorias = new List<Categoria>();

        List<Produto> produtos = new List<Produto>();

        private void Form1_Load(object sender, EventArgs e)
        {


            categorias.Add(new Categoria { CategoriaId = 1, Nome = "Informatica" });
            categorias.Add(new Categoria { CategoriaId = 2, Nome = "EletroDomestico" });
            categorias.Add(new Categoria { CategoriaId = 3, Nome = "Livros" });
            categorias.Add(new Categoria { CategoriaId = 4, Nome = "Roupas" });
            categorias.Add(new Categoria { CategoriaId = 5, Nome = "Comidas" });


            produtos.Add(new Produto { ProdutoId = 100, Nome = "Computador", Pontos = 10, Categoria = categorias.Where(x => x.CategoriaId == 1).FirstOrDefault()});
            produtos.Add(new Produto { ProdutoId = 123, Nome = "Camiseta", Pontos = 10, Categoria = categorias.Where(x => x.CategoriaId == 4).FirstOrDefault() });
            produtos.Add(new Produto { ProdutoId = 142, Nome = "Bolacha", Pontos = 10, Categoria = categorias.Where(x => x.CategoriaId == 5).FirstOrDefault() });
            produtos.Add(new Produto { ProdutoId = 24, Nome = "Microondas", Pontos = 10, Categoria = categorias.Where(x => x.CategoriaId == 2).FirstOrDefault() });
            produtos.Add(new Produto { ProdutoId = 75, Nome = "Biblia", Pontos = 10, Categoria = categorias.Where(x => x.CategoriaId == 3).FirstOrDefault() });






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto = produtos.Where(x => x.Categoria.CategoriaId == int.Parse(txtproduto.Text)).FirstOrDefault();

            lblRetorno.Text = "";
            lblRetorno.Text = "ProdutoID = " + produto.ProdutoId.ToString();
            lblRetorno.Text += " Nome = " + produto.Nome;
            lblRetorno.Text += " Categoria = " + produto.Categoria.Nome;

            
        }
    }
}
