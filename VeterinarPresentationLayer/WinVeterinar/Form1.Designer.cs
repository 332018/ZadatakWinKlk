namespace WinVeterinar
{
    partial class FormVeterinar
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
            this.listBoxIspis = new System.Windows.Forms.ListBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelSpecijalnost = new System.Windows.Forms.Label();
            this.labelGod = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxSpecijalnost = new System.Windows.Forms.TextBox();
            this.textBoxGod = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIspis
            // 
            this.listBoxIspis.FormattingEnabled = true;
            this.listBoxIspis.ItemHeight = 20;
            this.listBoxIspis.Location = new System.Drawing.Point(13, 174);
            this.listBoxIspis.Name = "listBoxIspis";
            this.listBoxIspis.Size = new System.Drawing.Size(563, 224);
            this.listBoxIspis.TabIndex = 0;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(13, 13);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(36, 20);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime";
            // 
            // labelSpecijalnost
            // 
            this.labelSpecijalnost.AutoSize = true;
            this.labelSpecijalnost.Location = new System.Drawing.Point(17, 56);
            this.labelSpecijalnost.Name = "labelSpecijalnost";
            this.labelSpecijalnost.Size = new System.Drawing.Size(95, 20);
            this.labelSpecijalnost.TabIndex = 2;
            this.labelSpecijalnost.Text = "Specijalnost";
            // 
            // labelGod
            // 
            this.labelGod.AutoSize = true;
            this.labelGod.Location = new System.Drawing.Point(17, 102);
            this.labelGod.Name = "labelGod";
            this.labelGod.Size = new System.Drawing.Size(40, 20);
            this.labelGod.TabIndex = 3;
            this.labelGod.Text = "God";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(162, 13);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 26);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxSpecijalnost
            // 
            this.textBoxSpecijalnost.Location = new System.Drawing.Point(162, 56);
            this.textBoxSpecijalnost.Name = "textBoxSpecijalnost";
            this.textBoxSpecijalnost.Size = new System.Drawing.Size(100, 26);
            this.textBoxSpecijalnost.TabIndex = 5;
            // 
            // textBoxGod
            // 
            this.textBoxGod.Location = new System.Drawing.Point(162, 95);
            this.textBoxGod.Name = "textBoxGod";
            this.textBoxGod.Size = new System.Drawing.Size(100, 26);
            this.textBoxGod.TabIndex = 6;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(399, 56);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(88, 39);
            this.buttonDodaj.TabIndex = 7;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // FormVeterinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxGod);
            this.Controls.Add(this.textBoxSpecijalnost);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelGod);
            this.Controls.Add(this.labelSpecijalnost);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.listBoxIspis);
            this.Name = "FormVeterinar";
            this.Text = "FormIspis";
            this.Load += new System.EventHandler(this.FormVeterinar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIspis;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelSpecijalnost;
        private System.Windows.Forms.Label labelGod;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxSpecijalnost;
        private System.Windows.Forms.TextBox textBoxGod;
        private System.Windows.Forms.Button buttonDodaj;
    }
}

