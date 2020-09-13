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
    public partial class Excluir : Form
    {
        Form1 form;
        public Excluir(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tBoxPlacaExcluir.MaskCompleted)
            {
                if (form.listaCarros.Exists(c => c.placa == tBoxPlacaExcluir.Text.ToUpper()))
                {
                    DialogResult dialogResult = MessageBox.Show("Tem certeza  de deseja excluir este veiculo?", "Excluir Veiculo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        form.ExcluirCarro(tBoxPlacaExcluir.Text);
                        this.Close();
                    }
                   

                }
                else
                {
                    MessageBox.Show("Veiculo ja encontrado");
                   
                }

            }
            else { MessageBox.Show("insira a placa do veiculo para excluir"); }
        }
    }
}
