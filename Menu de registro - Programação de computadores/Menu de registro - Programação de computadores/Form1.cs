using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_de_registro___Programação_de_computadores
{
    public partial class Form1 : Form
    {
        public List<Carro> listaCarros = new List<Carro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir incluir = new Incluir(this);
            incluir.Show();
        }
        public void IncluirCarro(string modelo, string cor, string fabricante, string placa)
        {
            Carro novoCarro = new Carro();

            novoCarro.modelo = modelo;
            novoCarro.cor = cor;
            novoCarro.fabricante = fabricante;
            novoCarro.placa = placa.ToUpper();
            

            listaCarros.Add(novoCarro);
            txtNumeroRegistros.Text = "Numero de registros: " + listaCarros.Count;
        }
        public void ExcluirCarro(string placa)
        {
            listaCarros.Remove(listaCarros.Find(x => x.placa == placa.ToUpper()));
            txtNumeroRegistros.Text = "Numero de registros: " + listaCarros.Count;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar(this);
            alterar.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir(this);
            excluir.Show();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar pesquisar = new Pesquisar(this);
            pesquisar.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sair?", "Fechar aplicativo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {              
                this.Close();
            }
        }
    }
    public class Carro
    {
        public string modelo;
        public string cor;
        public string fabricante;
        public string placa;   
    }
}
