namespace Menu_de_registro___Programação_de_computadores
{
    partial class Alterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxPlacaBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxModelo = new System.Windows.Forms.TextBox();
            this.tBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.cBoxFabricante = new System.Windows.Forms.ComboBox();
            this.cBoxCor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModeloAntigo = new System.Windows.Forms.Label();
            this.txtCorAntiga = new System.Windows.Forms.Label();
            this.txtFabricanteAntiga = new System.Windows.Forms.Label();
            this.txtPlacaAntiga = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa do veiculo que deseja alterar:";
            // 
            // tBoxPlacaBuscar
            // 
            this.tBoxPlacaBuscar.Location = new System.Drawing.Point(195, 10);
            this.tBoxPlacaBuscar.Mask = "AAA-0000";
            this.tBoxPlacaBuscar.Name = "tBoxPlacaBuscar";
            this.tBoxPlacaBuscar.Size = new System.Drawing.Size(100, 20);
            this.tBoxPlacaBuscar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fabricante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Placa";
            // 
            // tBoxModelo
            // 
            this.tBoxModelo.Enabled = false;
            this.tBoxModelo.Location = new System.Drawing.Point(16, 140);
            this.tBoxModelo.Name = "tBoxModelo";
            this.tBoxModelo.Size = new System.Drawing.Size(109, 20);
            this.tBoxModelo.TabIndex = 14;
            // 
            // tBoxPlaca
            // 
            this.tBoxPlaca.Enabled = false;
            this.tBoxPlaca.Location = new System.Drawing.Point(355, 139);
            this.tBoxPlaca.Mask = "AAA-0000";
            this.tBoxPlaca.Name = "tBoxPlaca";
            this.tBoxPlaca.Size = new System.Drawing.Size(100, 20);
            this.tBoxPlaca.TabIndex = 15;
            // 
            // cBoxFabricante
            // 
            this.cBoxFabricante.Enabled = false;
            this.cBoxFabricante.FormattingEnabled = true;
            this.cBoxFabricante.Items.AddRange(new object[] {
            "Chevrolet",
            "Chrysler",
            "Citröen",
            "Fiat",
            "Ford",
            "General Motors",
            "Honda",
            "Hyundai",
            "Kia",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen"});
            this.cBoxFabricante.Location = new System.Drawing.Point(248, 139);
            this.cBoxFabricante.Name = "cBoxFabricante";
            this.cBoxFabricante.Size = new System.Drawing.Size(101, 21);
            this.cBoxFabricante.TabIndex = 17;
            this.cBoxFabricante.Text = "Chevrolet";
            // 
            // cBoxCor
            // 
            this.cBoxCor.Enabled = false;
            this.cBoxCor.FormattingEnabled = true;
            this.cBoxCor.Items.AddRange(new object[] {
            "Preto",
            "Branco",
            "Azul",
            "Vermelho",
            "Prata",
            "Verde",
            "Laranja",
            "Chumbo",
            "Marrom"});
            this.cBoxCor.Location = new System.Drawing.Point(131, 140);
            this.cBoxCor.Name = "cBoxCor";
            this.cBoxCor.Size = new System.Drawing.Size(111, 21);
            this.cBoxCor.TabIndex = 16;
            this.cBoxCor.Text = "Preto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "deixe em branco campos que nao deseja alterar";
            // 
            // txtModeloAntigo
            // 
            this.txtModeloAntigo.AutoSize = true;
            this.txtModeloAntigo.Location = new System.Drawing.Point(13, 98);
            this.txtModeloAntigo.Name = "txtModeloAntigo";
            this.txtModeloAntigo.Size = new System.Drawing.Size(0, 13);
            this.txtModeloAntigo.TabIndex = 19;
            // 
            // txtCorAntiga
            // 
            this.txtCorAntiga.AutoSize = true;
            this.txtCorAntiga.Location = new System.Drawing.Point(131, 98);
            this.txtCorAntiga.Name = "txtCorAntiga";
            this.txtCorAntiga.Size = new System.Drawing.Size(0, 13);
            this.txtCorAntiga.TabIndex = 20;
            // 
            // txtFabricanteAntiga
            // 
            this.txtFabricanteAntiga.AutoSize = true;
            this.txtFabricanteAntiga.Location = new System.Drawing.Point(248, 98);
            this.txtFabricanteAntiga.Name = "txtFabricanteAntiga";
            this.txtFabricanteAntiga.Size = new System.Drawing.Size(0, 13);
            this.txtFabricanteAntiga.TabIndex = 21;
            // 
            // txtPlacaAntiga
            // 
            this.txtPlacaAntiga.AutoSize = true;
            this.txtPlacaAntiga.Location = new System.Drawing.Point(355, 98);
            this.txtPlacaAntiga.Name = "txtPlacaAntiga";
            this.txtPlacaAntiga.Size = new System.Drawing.Size(0, 13);
            this.txtPlacaAntiga.TabIndex = 22;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(380, 186);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(380, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 222);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtPlacaAntiga);
            this.Controls.Add(this.txtFabricanteAntiga);
            this.Controls.Add(this.txtCorAntiga);
            this.Controls.Add(this.txtModeloAntigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxFabricante);
            this.Controls.Add(this.cBoxCor);
            this.Controls.Add(this.tBoxPlaca);
            this.Controls.Add(this.tBoxModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxPlacaBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tBoxPlacaBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxModelo;
        private System.Windows.Forms.MaskedTextBox tBoxPlaca;
        private System.Windows.Forms.ComboBox cBoxFabricante;
        private System.Windows.Forms.ComboBox cBoxCor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtModeloAntigo;
        private System.Windows.Forms.Label txtCorAntiga;
        private System.Windows.Forms.Label txtFabricanteAntiga;
        private System.Windows.Forms.Label txtPlacaAntiga;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
    }
}