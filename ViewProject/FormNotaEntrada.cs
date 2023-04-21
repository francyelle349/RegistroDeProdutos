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
    public partial class FormNotaEntrada : Form
    {
        private NotaEntradaController controller;
        private FornecedorCotroller fornecedorCotroller;
        private ProdutoController ProdutoController;
        public FormNotaEntrada(NotaEntradaController controller, FornecedorCotroller fornecedorcontroller, ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorCotroller = fornecedorcontroller;
            this.ProdutoController = produtoController;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNotaEntrada_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
