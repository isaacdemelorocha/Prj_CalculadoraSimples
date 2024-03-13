namespace Prj_CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtVal1 = new TextBox();
            txtVal2 = new TextBox();
            label2 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(259, 31);
            label1.TabIndex = 0;
            label1.Text = "Digite o primeiro valor";
            // 
            // txtVal1
            // 
            txtVal1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVal1.Location = new Point(29, 63);
            txtVal1.Name = "txtVal1";
            txtVal1.Size = new Size(259, 38);
            txtVal1.TabIndex = 1;
            // 
            // txtVal2
            // 
            txtVal2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVal2.Location = new Point(29, 166);
            txtVal2.Name = "txtVal2";
            txtVal2.Size = new Size(259, 38);
            txtVal2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 120);
            label2.Name = "label2";
            label2.Size = new Size(258, 31);
            label2.TabIndex = 2;
            label2.Text = "Digite o segundo valor";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(29, 288);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(259, 38);
            txtTotal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 245);
            label3.Name = "label3";
            label3.Size = new Size(128, 31);
            label3.TabIndex = 4;
            label3.Text = "Valor Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(txtVal2);
            Controls.Add(label2);
            Controls.Add(txtVal1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVal1;
        private TextBox txtVal2;
        private Label label2;
        private TextBox txtTotal;
        private Label label3;
    }
}
