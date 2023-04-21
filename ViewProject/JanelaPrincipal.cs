using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormJanelaPrincipal : Form
    {
        private  FornecedorCotroller fornecedorCotroller = new FornecedorCotroller();
        private NotaEntradaController controller;
        
        private ProdutoController ProdutoController;
        public FormJanelaPrincipal()
        {

            InitializeComponent();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new FormFornecedor(fornecedorCotroller).ShowDialog();

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new FormNotaEntrada(controller,fornecedorCotroller,ProdutoController).ShowDialog();
        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
