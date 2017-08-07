namespace WCFTest
{
    partial class TestForm
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
            this.txbWert1 = new System.Windows.Forms.TextBox();
            this.txbWert2 = new System.Windows.Forms.TextBox();
            this.lblWert1 = new System.Windows.Forms.Label();
            this.lblWert2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbWert1
            // 
            this.txbWert1.Location = new System.Drawing.Point(12, 31);
            this.txbWert1.Name = "txbWert1";
            this.txbWert1.Size = new System.Drawing.Size(103, 20);
            this.txbWert1.TabIndex = 0;
            // 
            // txbWert2
            // 
            this.txbWert2.Location = new System.Drawing.Point(121, 31);
            this.txbWert2.Name = "txbWert2";
            this.txbWert2.Size = new System.Drawing.Size(100, 20);
            this.txbWert2.TabIndex = 1;
            // 
            // lblWert1
            // 
            this.lblWert1.AutoSize = true;
            this.lblWert1.Location = new System.Drawing.Point(9, 15);
            this.lblWert1.Name = "lblWert1";
            this.lblWert1.Size = new System.Drawing.Size(42, 13);
            this.lblWert1.TabIndex = 2;
            this.lblWert1.Text = "Wert 1:";
            // 
            // lblWert2
            // 
            this.lblWert2.AutoSize = true;
            this.lblWert2.Location = new System.Drawing.Point(118, 15);
            this.lblWert2.Name = "lblWert2";
            this.lblWert2.Size = new System.Drawing.Size(42, 13);
            this.lblWert2.TabIndex = 3;
            this.lblWert2.Text = "Wert 2:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(121, 57);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(103, 23);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(12, 86);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(103, 23);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(121, 86);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(103, 23);
            this.btndiv.TabIndex = 7;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 112);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Output:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 133);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWert2);
            this.Controls.Add(this.lblWert1);
            this.Controls.Add(this.txbWert2);
            this.Controls.Add(this.txbWert1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbWert1;
        private System.Windows.Forms.TextBox txbWert2;
        private System.Windows.Forms.Label lblWert1;
        private System.Windows.Forms.Label lblWert2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Label lblOutput;
    }
}