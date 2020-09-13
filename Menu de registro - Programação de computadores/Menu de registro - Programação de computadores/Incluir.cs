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
    public partial class Incluir : Form
    {
        Form1 form;
        public Incluir(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            
        
            if (tBoxModelo.Text != "" && tBoxPlaca.MaskCompleted)
            {
                if (form.listaCarros.Exists(c => c.placa == tBoxPlaca.Text.ToUpper()))
                {
                    MessageBox.Show("Veiculo ja registrado");
                    
                }
                else
                {
                    form.IncluirCarro(tBoxModelo.Text, cBoxCor.Text, cBoxFabricante.Text, tBoxPlaca.Text);
                    this.Close();
                }
                 
            }
            else { MessageBox.Show("prencha os campos para incluir"); }
        }
    }
}
