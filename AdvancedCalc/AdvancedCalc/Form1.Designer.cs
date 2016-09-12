namespace AdvancedCalc
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btndvide = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnByitself = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(16, 61);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(170, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(16, 100);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(170, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(58, 209);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(84, 28);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(28, 137);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(42, 23);
            this.btnplus.TabIndex = 5;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(81, 137);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(42, 23);
            this.btnminus.TabIndex = 6;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btndvide
            // 
            this.btndvide.Location = new System.Drawing.Point(28, 166);
            this.btndvide.Name = "btndvide";
            this.btndvide.Size = new System.Drawing.Size(42, 23);
            this.btndvide.TabIndex = 7;
            this.btndvide.Text = "/";
            this.btndvide.UseVisualStyleBackColor = true;
            this.btndvide.Click += new System.EventHandler(this.btndvide_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(129, 137);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(42, 23);
            this.btnmult.TabIndex = 8;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnByitself
            // 
            this.btnByitself.Location = new System.Drawing.Point(129, 166);
            this.btnByitself.Name = "btnByitself";
            this.btnByitself.Size = new System.Drawing.Size(42, 23);
            this.btnByitself.TabIndex = 9;
            this.btnByitself.Text = "^";
            this.btnByitself.UseVisualStyleBackColor = true;
            this.btnByitself.Click += new System.EventHandler(this.btnByitself_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "The sum is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 249);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnByitself);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btndvide);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btndvide;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnByitself;
        private System.Windows.Forms.TextBox textBox1;
    }
}

