using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_de_registro___Programação_de_computadores
{
    
    public partial class Pesquisar : Form
    {
        Form1 form;
        public Pesquisar(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            resultado.Clear();

            for (int i = 0; i < form.listaCarros.Count; i++)
            {
                if (form.listaCarros[i].modelo == tBoxPesquisa.Text || form.listaCarros[i].fabricante == tBoxPesquisa.Text || form.listaCarros[i].cor == tBoxPesquisa.Text || form.listaCarros[i].placa == tBoxPesquisa.Text.ToUpper())
                { resultado.AppendText(form.listaCarros[i].fabricante + " " + form.listaCarros[i].modelo + " " + form.listaCarros[i].cor + " " + form.listaCarros[i].placa + Environment.NewLine); }                   
            }
        }
    }
}
