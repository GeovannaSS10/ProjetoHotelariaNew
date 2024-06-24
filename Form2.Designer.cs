namespace HotelariaSistem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1Form2 = new System.Windows.Forms.Label();
            this.labelQuartosDisponíveis = new System.Windows.Forms.Label();
            this.labelDisponibilidade = new System.Windows.Forms.Label();
            this.buttonReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1Form2
            // 
            this.label1Form2.AutoSize = true;
            this.label1Form2.Location = new System.Drawing.Point(276, 75);
            this.label1Form2.Name = "label1Form2";
            this.label1Form2.Size = new System.Drawing.Size(0, 13);
            this.label1Form2.TabIndex = 0;
            // 
            // labelQuartosDisponíveis
            // 
            this.labelQuartosDisponíveis.AutoSize = true;
            this.labelQuartosDisponíveis.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuartosDisponíveis.Location = new System.Drawing.Point(101, 126);
            this.labelQuartosDisponíveis.Name = "labelQuartosDisponíveis";
            this.labelQuartosDisponíveis.Size = new System.Drawing.Size(154, 29);
            this.labelQuartosDisponíveis.TabIndex = 1;
            this.labelQuartosDisponíveis.Text = "Quartos disponíveis:";
            // 
            // labelDisponibilidade
            // 
            this.labelDisponibilidade.AutoSize = true;
            this.labelDisponibilidade.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponibilidade.Location = new System.Drawing.Point(101, 69);
            this.labelDisponibilidade.Name = "labelDisponibilidade";
            this.labelDisponibilidade.Size = new System.Drawing.Size(128, 29);
            this.labelDisponibilidade.TabIndex = 2;
            this.labelDisponibilidade.Text = "Total de quartos:";
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(137, 193);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Size = new System.Drawing.Size(149, 41);
            this.buttonReservar.TabIndex = 3;
            this.buttonReservar.Text = "Reservar ";
            this.buttonReservar.UseVisualStyleBackColor = true;
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(438, 330);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.labelDisponibilidade);
            this.Controls.Add(this.labelQuartosDisponíveis);
            this.Controls.Add(this.label1Form2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "HotelariaSistem";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Form2;
        private System.Windows.Forms.Label labelQuartosDisponíveis;
        private System.Windows.Forms.Label labelDisponibilidade;
        private System.Windows.Forms.Button buttonReservar;
    }
}