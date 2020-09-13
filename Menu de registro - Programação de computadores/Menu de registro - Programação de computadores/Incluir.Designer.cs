namespace Menu_de_registro___Programação_de_computadores
{
    partial class Incluir
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxCor = new System.Windows.Forms.ComboBox();
            this.cBoxFabricante = new System.Windows.Forms.ComboBox();
            this.tBoxModelo = new System.Windows.Forms.TextBox();
            this.tBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prencha os campos para incluir um veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fabricante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placa";
            // 
            // cBoxCor
            // 
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
            this.cBoxCor.Location = new System.Drawing.Point(45, 96);
            this.cBoxCor.Name = "cBoxCor";
            this.cBoxCor.Size = new System.Drawing.Size(180, 21);
            this.cBoxCor.TabIndex = 5;
            this.cBoxCor.Text = "Preto";
            // 
            // cBoxFabricante
            // 
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
            this.cBoxFabricante.Location = new System.Drawing.Point(85, 141);
            this.cBoxFabricante.Name = "cBoxFabricante";
            this.cBoxFabricante.Size = new System.Drawing.Size(140, 21);
            this.cBoxFabricante.TabIndex = 6;
            this.cBoxFabricante.Text = "Chevrolet";
            // 
            // tBoxModelo
            // 
            this.tBoxModelo.Location = new System.Drawing.Point(67, 49);
            this.tBoxModelo.Name = "tBoxModelo";
            this.tBoxModelo.Size = new System.Drawing.Size(157, 20);
            this.tBoxModelo.TabIndex = 7;
            // 
            // tBoxPlaca
            // 
            this.tBoxPlaca.Location = new System.Drawing.Point(124, 191);
            this.tBoxPlaca.Mask = "AAA-0000";
            this.tBoxPlaca.Name = "tBoxPlaca";
            this.tBoxPlaca.Size = new System.Drawing.Size(100, 20);
            this.tBoxPlaca.TabIndex = 8;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(148, 261);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // Incluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 296);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.tBoxPlaca);
            this.Controls.Add(this.tBoxModelo);
            this.Controls.Add(this.cBoxFabricante);
            this.Controls.Add(this.cBoxCor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Incluir";
            this.Text = "Incluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxCor;
        private System.Windows.Forms.ComboBox cBoxFabricante;
        private System.Windows.Forms.TextBox tBoxModelo;
        private System.Windows.Forms.MaskedTextBox tBoxPlaca;
        private System.Windows.Forms.Button btnIncluir;
    }
}