namespace ClientTestForm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOutput = new System.Windows.Forms.Label();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblWert2 = new System.Windows.Forms.Label();
            this.lblWert1 = new System.Windows.Forms.Label();
            this.txbWert2 = new System.Windows.Forms.TextBox();
            this.txbWert1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(15, 106);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 17;
            this.lblOutput.Text = "Output:";
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(124, 80);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(103, 23);
            this.btndiv.TabIndex = 16;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(15, 80);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(103, 23);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(124, 51);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(103, 23);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblWert2
            // 
            this.lblWert2.AutoSize = true;
            this.lblWert2.Location = new System.Drawing.Point(121, 9);
            this.lblWert2.Name = "lblWert2";
            this.lblWert2.Size = new System.Drawing.Size(42, 13);
            this.lblWert2.TabIndex = 12;
            this.lblWert2.Text = "Wert 2:";
            // 
            // lblWert1
            // 
            this.lblWert1.AutoSize = true;
            this.lblWert1.Location = new System.Drawing.Point(12, 9);
            this.lblWert1.Name = "lblWert1";
            this.lblWert1.Size = new System.Drawing.Size(42, 13);
            this.lblWert1.TabIndex = 11;
            this.lblWert1.Text = "Wert 1:";
            // 
            // txbWert2
            // 
            this.txbWert2.Location = new System.Drawing.Point(124, 25);
            this.txbWert2.Name = "txbWert2";
            this.txbWert2.Size = new System.Drawing.Size(100, 20);
            this.txbWert2.TabIndex = 10;
            // 
            // txbWert1
            // 
            this.txbWert1.Location = new System.Drawing.Point(15, 25);
            this.txbWert1.Name = "txbWert1";
            this.txbWert1.Size = new System.Drawing.Size(103, 20);
            this.txbWert1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 129);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWert2);
            this.Controls.Add(this.lblWert1);
            this.Controls.Add(this.txbWert2);
            this.Controls.Add(this.txbWert1);
            this.Name = "Form1";
            this.Text = "ClientTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblWert2;
        private System.Windows.Forms.Label lblWert1;
        private System.Windows.Forms.TextBox txbWert2;
        private System.Windows.Forms.TextBox txbWert1;
    }
}

