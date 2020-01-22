namespace tictactoe
{
    partial class Form1
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
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.Rbutton = new System.Windows.Forms.Button();
            this.Ebuttom = new System.Windows.Forms.Button();
            this.Xwins = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.Owins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(34, 21);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(100, 100);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(140, 21);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(100, 100);
            this.A01.TabIndex = 1;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(246, 21);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(100, 100);
            this.A02.TabIndex = 2;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(246, 127);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(100, 100);
            this.A12.TabIndex = 5;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(140, 127);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(100, 100);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(34, 127);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(100, 100);
            this.A10.TabIndex = 3;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(246, 233);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(100, 100);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(140, 233);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(100, 100);
            this.A21.TabIndex = 7;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(34, 233);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(100, 100);
            this.A20.TabIndex = 6;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(34, 395);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(117, 43);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "Nowa gra";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // Rbutton
            // 
            this.Rbutton.Location = new System.Drawing.Point(157, 395);
            this.Rbutton.Name = "Rbutton";
            this.Rbutton.Size = new System.Drawing.Size(117, 43);
            this.Rbutton.TabIndex = 10;
            this.Rbutton.Text = "Restart";
            this.Rbutton.UseVisualStyleBackColor = true;
            this.Rbutton.Click += new System.EventHandler(this.Rbutton_Click);
            // 
            // Ebuttom
            // 
            this.Ebuttom.Location = new System.Drawing.Point(402, 395);
            this.Ebuttom.Name = "Ebuttom";
            this.Ebuttom.Size = new System.Drawing.Size(117, 43);
            this.Ebuttom.TabIndex = 11;
            this.Ebuttom.Text = "Exit";
            this.Ebuttom.UseVisualStyleBackColor = true;
            this.Ebuttom.Click += new System.EventHandler(this.Ebuttom_Click);
            // 
            // Xwins
            // 
            this.Xwins.AutoSize = true;
            this.Xwins.Location = new System.Drawing.Point(425, 65);
            this.Xwins.Name = "Xwins";
            this.Xwins.Size = new System.Drawing.Size(0, 13);
            this.Xwins.TabIndex = 12;
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(425, 171);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(0, 13);
            this.Draws.TabIndex = 13;
            // 
            // Owins
            // 
            this.Owins.AutoSize = true;
            this.Owins.Location = new System.Drawing.Point(425, 277);
            this.Owins.Name = "Owins";
            this.Owins.Size = new System.Drawing.Size(0, 13);
            this.Owins.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 446);
            this.Controls.Add(this.Owins);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.Xwins);
            this.Controls.Add(this.Ebuttom);
            this.Controls.Add(this.Rbutton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button Rbutton;
        private System.Windows.Forms.Button Ebuttom;
        private System.Windows.Forms.Label Xwins;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Label Owins;
    }
}

