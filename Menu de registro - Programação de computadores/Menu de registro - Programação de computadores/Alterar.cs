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
    public partial class Alterar : Form
    {
        Form1 form;
        Carro carroAlterar = new Carro();
        public Alterar(Form1 form)
        {
            InitializeComponent();
            this.form = form; 
        }

      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (form.listaCarros.Exists(c => c.placa == tBoxPlacaBuscar.Text.ToUpper()))
            {
                
                carroAlterar = form.listaCarros.First(c => c.placa == tBoxPlacaBuscar.Text.ToUpper());

                txtModeloAntigo.Text = carroAlterar.modelo;
                txtCorAntiga.Text = carroAlterar.cor;
                txtFabricanteAntiga.Text = carroAlterar.fabricante;
                txtPlacaAntiga.Text = carroAlterar.placa;

                btnBuscar.Enabled = false;
                tBoxPlacaBuscar.Enabled = false;

                tBoxModelo.Enabled = true;
                cBoxCor.Enabled = true;
                cBoxFabricante.Enabled = true;
                tBoxPlaca.Enabled = true;
                btnAlterar.Enabled = true;
            }
            else { MessageBox.Show("Veiculo não encontrado"); }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (tBoxModelo.Text != "")
            {
                carroAlterar.modelo = tBoxModelo.Text;
            }
            if (tBoxPlaca.MaskCompleted)
            {
                carroAlterar.placa = tBoxPlaca.Text;
            }
            carroAlterar.fabricante = cBoxFabricante.Text;
            carroAlterar.cor = cBoxCor.Text;

            DialogResult dialogResult = MessageBox.Show("Alterar: " + txtFabricanteAntiga.Text + " " + txtModeloAntigo.Text + ", cor " + txtCorAntiga.Text + " Placa " + txtPlacaAntiga.Text + Environment.NewLine + "para:" + Environment.NewLine +
                                                         carroAlterar.fabricante + " " + carroAlterar.modelo + ", cor " + carroAlterar.cor + " Placa " + carroAlterar.placa , "Alterar Veiculo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                form.ExcluirCarro(carroAlterar.placa);
                form.IncluirCarro(carroAlterar.modelo, carroAlterar.cor, carroAlterar.fabricante, carroAlterar.placa);
                this.Close();
            }
            

        }
    }
}
