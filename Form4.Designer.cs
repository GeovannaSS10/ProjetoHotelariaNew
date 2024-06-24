namespace HotelariaSistem
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelNomeRegistro = new System.Windows.Forms.Label();
            this.labelQuarto = new System.Windows.Forms.Label();
            this.labelNoites = new System.Windows.Forms.Label();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(77, 249);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 32);
            this.buttonVoltar.TabIndex = 0;
            this.buttonVoltar.Text = "Voltar para reserva";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(96, 297);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(90, 23);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de hospedagem";
            // 
            // LabelNomeRegistro
            // 
            this.LabelNomeRegistro.AutoSize = true;
            this.LabelNomeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeRegistro.Location = new System.Drawing.Point(12, 67);
            this.LabelNomeRegistro.Name = "LabelNomeRegistro";
            this.LabelNomeRegistro.Size = new System.Drawing.Size(114, 15);
            this.LabelNomeRegistro.TabIndex = 3;
            this.LabelNomeRegistro.Text = "Nome do Hóspede:";
            // 
            // labelQuarto
            // 
            this.labelQuarto.AutoSize = true;
            this.labelQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuarto.Location = new System.Drawing.Point(24, 107);
            this.labelQuarto.Name = "labelQuarto";
            this.labelQuarto.Size = new System.Drawing.Size(61, 15);
            this.labelQuarto.TabIndex = 4;
            this.labelQuarto.Text = "Nº quarto:";
            this.labelQuarto.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelNoites
            // 
            this.labelNoites.AutoSize = true;
            this.labelNoites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoites.Location = new System.Drawing.Point(24, 153);
            this.labelNoites.Name = "labelNoites";
            this.labelNoites.Size = new System.Drawing.Size(76, 15);
            this.labelNoites.TabIndex = 5;
            this.labelNoites.Text = "Nº de noites:";
            this.labelNoites.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Location = new System.Drawing.Point(24, 197);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(132, 13);
            this.labelValorFinal.TabIndex = 6;
            this.labelValorFinal.Text = "Valor total estadia + taxa =";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(298, 353);
            this.Controls.Add(this.labelValorFinal);
            this.Controls.Add(this.labelNoites);
            this.Controls.Add(this.labelQuarto);
            this.Controls.Add(this.LabelNomeRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "HotelariaSistem";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNomeRegistro;
        private System.Windows.Forms.Label labelQuarto;
        private System.Windows.Forms.Label labelNoites;
        private System.Windows.Forms.Label labelValorFinal;
    }
}