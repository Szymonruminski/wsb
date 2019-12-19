namespace WindowsFormsApp1
{
    partial class Kwadrat
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBok = new System.Windows.Forms.TextBox();
            this.textObwod = new System.Windows.Forms.TextBox();
            this.textPole = new System.Windows.Forms.TextBox();
            this.lblBok = new System.Windows.Forms.Label();
            this.lblObwod = new System.Windows.Forms.Label();
            this.lblPole = new System.Windows.Forms.Label();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.bynWyczysc = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBok
            // 
            this.textBok.Location = new System.Drawing.Point(126, 48);
            this.textBok.Name = "textBok";
            this.textBok.Size = new System.Drawing.Size(127, 20);
            this.textBok.TabIndex = 0;
            this.textBok.Click += new System.EventHandler(this.textBok_TextChanged);
            this.textBok.TextChanged += new System.EventHandler(this.textBok_TextChanged);
            // 
            // textObwod
            // 
            this.textObwod.Enabled = false;
            this.textObwod.Location = new System.Drawing.Point(125, 109);
            this.textObwod.Name = "textObwod";
            this.textObwod.Size = new System.Drawing.Size(127, 20);
            this.textObwod.TabIndex = 1;
            this.textObwod.Click += new System.EventHandler(this.textBok_TextChanged);
            this.textObwod.TextChanged += new System.EventHandler(this.textBok_TextChanged);
            // 
            // textPole
            // 
            this.textPole.Enabled = false;
            this.textPole.Location = new System.Drawing.Point(125, 175);
            this.textPole.Name = "textPole";
            this.textPole.Size = new System.Drawing.Size(127, 20);
            this.textPole.TabIndex = 2;
            // 
            // lblBok
            // 
            this.lblBok.AutoSize = true;
            this.lblBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblBok.Location = new System.Drawing.Point(65, 48);
            this.lblBok.Name = "lblBok";
            this.lblBok.Size = new System.Drawing.Size(41, 22);
            this.lblBok.TabIndex = 3;
            this.lblBok.Text = "Bok";
            this.lblBok.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblObwod
            // 
            this.lblObwod.AutoSize = true;
            this.lblObwod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblObwod.Location = new System.Drawing.Point(44, 109);
            this.lblObwod.Name = "lblObwod";
            this.lblObwod.Size = new System.Drawing.Size(67, 22);
            this.lblObwod.TabIndex = 4;
            this.lblObwod.Text = "Obwód";
            this.lblObwod.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPole
            // 
            this.lblPole.AutoSize = true;
            this.lblPole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblPole.Location = new System.Drawing.Point(65, 175);
            this.lblPole.Name = "lblPole";
            this.lblPole.Size = new System.Drawing.Size(46, 22);
            this.lblPole.TabIndex = 5;
            this.lblPole.Text = "Pole";
            // 
            // lblKomunikat
            // 
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblKomunikat.ForeColor = System.Drawing.Color.Red;
            this.lblKomunikat.Location = new System.Drawing.Point(259, 51);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(0, 17);
            this.lblKomunikat.TabIndex = 6;
            this.lblKomunikat.Click += new System.EventHandler(this.label1_Click);
            // 
            // bynWyczysc
            // 
            this.bynWyczysc.Location = new System.Drawing.Point(57, 241);
            this.bynWyczysc.Name = "bynWyczysc";
            this.bynWyczysc.Size = new System.Drawing.Size(85, 32);
            this.bynWyczysc.TabIndex = 7;
            this.bynWyczysc.Text = "Wyczyść";
            this.bynWyczysc.UseVisualStyleBackColor = true;
            this.bynWyczysc.Click += new System.EventHandler(this.bynWyczysc_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(222, 241);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(82, 32);
            this.btnZamknij.TabIndex = 8;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // Kwadrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 305);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.bynWyczysc);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.lblPole);
            this.Controls.Add(this.lblObwod);
            this.Controls.Add(this.lblBok);
            this.Controls.Add(this.textPole);
            this.Controls.Add(this.textObwod);
            this.Controls.Add(this.textBok);
            this.Name = "Kwadrat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwadrat";
            this.Load += new System.EventHandler(this.Kwadrat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBok;
        private System.Windows.Forms.TextBox textObwod;
        private System.Windows.Forms.TextBox textPole;
        private System.Windows.Forms.Label lblBok;
        private System.Windows.Forms.Label lblObwod;
        private System.Windows.Forms.Label lblPole;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.Button bynWyczysc;
        private System.Windows.Forms.Button btnZamknij;
    }
}

