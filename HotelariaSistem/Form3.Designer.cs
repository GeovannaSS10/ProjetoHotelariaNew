namespace HotelariaSistem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBox1NomeHospede = new System.Windows.Forms.TextBox();
            this.textBox2TelefoneHospede = new System.Windows.Forms.TextBox();
            this.monthCalendarForm3 = new System.Windows.Forms.MonthCalendar();
            this.label1Form3 = new System.Windows.Forms.Label();
            this.label2Form3 = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.labelDataTermino = new System.Windows.Forms.Label();
            this.labelNoites = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(174, 459);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(93, 31);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBox1NomeHospede
            // 
            this.textBox1NomeHospede.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1NomeHospede.Location = new System.Drawing.Point(122, 72);
            this.textBox1NomeHospede.Name = "textBox1NomeHospede";
            this.textBox1NomeHospede.Size = new System.Drawing.Size(189, 28);
            this.textBox1NomeHospede.TabIndex = 1;
            this.textBox1NomeHospede.Text = "Digite o nome do hóspede:";
            this.textBox1NomeHospede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1NomeHospede.TextChanged += new System.EventHandler(this.textBox1NomeHospede_TextChanged);
            // 
            // textBox2TelefoneHospede
            // 
            this.textBox2TelefoneHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2TelefoneHospede.Location = new System.Drawing.Point(122, 126);
            this.textBox2TelefoneHospede.Name = "textBox2TelefoneHospede";
            this.textBox2TelefoneHospede.Size = new System.Drawing.Size(189, 21);
            this.textBox2TelefoneHospede.TabIndex = 2;
            this.textBox2TelefoneHospede.Text = "Nº de celular: ( ) __ _ ____-____";
            this.textBox2TelefoneHospede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2TelefoneHospede.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // monthCalendarForm3
            // 
            this.monthCalendarForm3.Location = new System.Drawing.Point(108, 206);
            this.monthCalendarForm3.MaxSelectionCount = 31;
            this.monthCalendarForm3.MinDate = new System.DateTime(2024, 6, 17, 0, 0, 0, 0);
            this.monthCalendarForm3.Name = "monthCalendarForm3";
            this.monthCalendarForm3.TabIndex = 4;
            this.monthCalendarForm3.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarForm3_DateChanged);
            // 
            // label1Form3
            // 
            this.label1Form3.AutoSize = true;
            this.label1Form3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Form3.Location = new System.Drawing.Point(94, 24);
            this.label1Form3.Name = "label1Form3";
            this.label1Form3.Size = new System.Drawing.Size(262, 27);
            this.label1Form3.TabIndex = 5;
            this.label1Form3.Text = "Formulário de cadastro de hóspede:";
            // 
            // label2Form3
            // 
            this.label2Form3.AutoSize = true;
            this.label2Form3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Form3.Location = new System.Drawing.Point(118, 174);
            this.label2Form3.Name = "label2Form3";
            this.label2Form3.Size = new System.Drawing.Size(196, 23);
            this.label2Form3.TabIndex = 6;
            this.label2Form3.Text = "Selecione o período da estadia:";
            this.label2Form3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2Form3.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(80, 377);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(77, 13);
            this.labelDataInicio.TabIndex = 7;
            this.labelDataInicio.Text = "Data de início:";
            // 
            // labelDataTermino
            // 
            this.labelDataTermino.AutoSize = true;
            this.labelDataTermino.Location = new System.Drawing.Point(273, 377);
            this.labelDataTermino.Name = "labelDataTermino";
            this.labelDataTermino.Size = new System.Drawing.Size(83, 13);
            this.labelDataTermino.TabIndex = 8;
            this.labelDataTermino.Text = "data de término:";
            // 
            // labelNoites
            // 
            this.labelNoites.AutoSize = true;
            this.labelNoites.Location = new System.Drawing.Point(80, 403);
            this.labelNoites.Name = "labelNoites";
            this.labelNoites.Size = new System.Drawing.Size(68, 13);
            this.labelNoites.TabIndex = 9;
            this.labelNoites.Text = "Nº de noites:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(276, 403);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 13);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Total: ";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(444, 502);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelNoites);
            this.Controls.Add(this.labelDataTermino);
            this.Controls.Add(this.labelDataInicio);
            this.Controls.Add(this.label2Form3);
            this.Controls.Add(this.label1Form3);
            this.Controls.Add(this.monthCalendarForm3);
            this.Controls.Add(this.textBox2TelefoneHospede);
            this.Controls.Add(this.textBox1NomeHospede);
            this.Controls.Add(this.buttonSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "HotelariaSistem";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBox1NomeHospede;
        private System.Windows.Forms.TextBox textBox2TelefoneHospede;
        private System.Windows.Forms.MonthCalendar monthCalendarForm3;
        public System.Windows.Forms.Label label1Form3;
        public System.Windows.Forms.Label label2Form3;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.Label labelDataTermino;
        private System.Windows.Forms.Label labelNoites;
        private System.Windows.Forms.Label labelTotal;
    }
}