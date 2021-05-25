namespace PoolCalculation
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
            this.hovuz = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHecm = new System.Windows.Forms.TextBox();
            this.btnHovuz = new System.Windows.Forms.Button();
            this.nudUzunluk = new System.Windows.Forms.NumericUpDown();
            this.nudEn = new System.Windows.Forms.NumericUpDown();
            this.nudDerinlik = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vaxt = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVaxt = new System.Windows.Forms.TextBox();
            this.btnVaxt = new System.Windows.Forms.Button();
            this.nud2Kiran = new System.Windows.Forms.NumericUpDown();
            this.nud1Kiran = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hovuz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDerinlik)).BeginInit();
            this.vaxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2Kiran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Kiran)).BeginInit();
            this.SuspendLayout();
            // 
            // hovuz
            // 
            this.hovuz.Controls.Add(this.label11);
            this.hovuz.Controls.Add(this.label10);
            this.hovuz.Controls.Add(this.label9);
            this.hovuz.Controls.Add(this.txtHecm);
            this.hovuz.Controls.Add(this.btnHovuz);
            this.hovuz.Controls.Add(this.nudUzunluk);
            this.hovuz.Controls.Add(this.nudEn);
            this.hovuz.Controls.Add(this.nudDerinlik);
            this.hovuz.Controls.Add(this.label3);
            this.hovuz.Controls.Add(this.label2);
            this.hovuz.Controls.Add(this.label1);
            this.hovuz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hovuz.Location = new System.Drawing.Point(12, 12);
            this.hovuz.Name = "hovuz";
            this.hovuz.Size = new System.Drawing.Size(185, 168);
            this.hovuz.TabIndex = 0;
            this.hovuz.TabStop = false;
            this.hovuz.Text = "Hovuzun Hecmi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(147, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "metr";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(147, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "metr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(147, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "metr";
            // 
            // txtHecm
            // 
            this.txtHecm.Location = new System.Drawing.Point(7, 137);
            this.txtHecm.Name = "txtHecm";
            this.txtHecm.ReadOnly = true;
            this.txtHecm.Size = new System.Drawing.Size(172, 23);
            this.txtHecm.TabIndex = 10;
            // 
            // btnHovuz
            // 
            this.btnHovuz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHovuz.Location = new System.Drawing.Point(41, 108);
            this.btnHovuz.Name = "btnHovuz";
            this.btnHovuz.Size = new System.Drawing.Size(103, 23);
            this.btnHovuz.TabIndex = 1;
            this.btnHovuz.Text = "Hecmi Hesapla";
            this.btnHovuz.UseVisualStyleBackColor = true;
            this.btnHovuz.Click += new System.EventHandler(this.btnHovuz_Click);
            // 
            // nudUzunluk
            // 
            this.nudUzunluk.Location = new System.Drawing.Point(59, 79);
            this.nudUzunluk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUzunluk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUzunluk.Name = "nudUzunluk";
            this.nudUzunluk.Size = new System.Drawing.Size(85, 23);
            this.nudUzunluk.TabIndex = 9;
            this.nudUzunluk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEn
            // 
            this.nudEn.Location = new System.Drawing.Point(59, 51);
            this.nudEn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEn.Name = "nudEn";
            this.nudEn.Size = new System.Drawing.Size(85, 23);
            this.nudEn.TabIndex = 8;
            this.nudEn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDerinlik
            // 
            this.nudDerinlik.Location = new System.Drawing.Point(59, 21);
            this.nudDerinlik.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDerinlik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDerinlik.Name = "nudDerinlik";
            this.nudDerinlik.Size = new System.Drawing.Size(85, 23);
            this.nudDerinlik.TabIndex = 7;
            this.nudDerinlik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uzunluk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "En";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derinlik";
            // 
            // vaxt
            // 
            this.vaxt.Controls.Add(this.label8);
            this.vaxt.Controls.Add(this.label7);
            this.vaxt.Controls.Add(this.label4);
            this.vaxt.Controls.Add(this.txtVaxt);
            this.vaxt.Controls.Add(this.btnVaxt);
            this.vaxt.Controls.Add(this.nud2Kiran);
            this.vaxt.Controls.Add(this.nud1Kiran);
            this.vaxt.Controls.Add(this.label5);
            this.vaxt.Controls.Add(this.label6);
            this.vaxt.Enabled = false;
            this.vaxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vaxt.Location = new System.Drawing.Point(209, 13);
            this.vaxt.Name = "vaxt";
            this.vaxt.Size = new System.Drawing.Size(185, 168);
            this.vaxt.TabIndex = 1;
            this.vaxt.TabStop = false;
            this.vaxt.Text = "Doldurma Vaxti";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Deqiqede Kub Dolumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(150, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "kub";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(150, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "kub";
            // 
            // txtVaxt
            // 
            this.txtVaxt.Location = new System.Drawing.Point(7, 137);
            this.txtVaxt.Name = "txtVaxt";
            this.txtVaxt.ReadOnly = true;
            this.txtVaxt.Size = new System.Drawing.Size(172, 23);
            this.txtVaxt.TabIndex = 10;
            // 
            // btnVaxt
            // 
            this.btnVaxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaxt.Location = new System.Drawing.Point(41, 109);
            this.btnVaxt.Name = "btnVaxt";
            this.btnVaxt.Size = new System.Drawing.Size(103, 23);
            this.btnVaxt.TabIndex = 1;
            this.btnVaxt.Text = "Vaxti Hesapla";
            this.btnVaxt.UseVisualStyleBackColor = true;
            this.btnVaxt.Click += new System.EventHandler(this.btnVaxt_Click);
            // 
            // nud2Kiran
            // 
            this.nud2Kiran.Location = new System.Drawing.Point(59, 80);
            this.nud2Kiran.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2Kiran.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud2Kiran.Name = "nud2Kiran";
            this.nud2Kiran.Size = new System.Drawing.Size(85, 23);
            this.nud2Kiran.TabIndex = 8;
            this.nud2Kiran.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud1Kiran
            // 
            this.nud1Kiran.Location = new System.Drawing.Point(59, 50);
            this.nud1Kiran.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud1Kiran.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1Kiran.Name = "nud1Kiran";
            this.nud1Kiran.Size = new System.Drawing.Size(85, 23);
            this.nud1Kiran.TabIndex = 7;
            this.nud1Kiran.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "2. Kiran";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "1. Kiran";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 194);
            this.Controls.Add(this.vaxt);
            this.Controls.Add(this.hovuz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pool Calculation";
            this.hovuz.ResumeLayout(false);
            this.hovuz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDerinlik)).EndInit();
            this.vaxt.ResumeLayout(false);
            this.vaxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2Kiran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Kiran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudUzunluk;
        private System.Windows.Forms.NumericUpDown nudEn;
        private System.Windows.Forms.NumericUpDown nudDerinlik;
        private System.Windows.Forms.Button btnHovuz;
        private System.Windows.Forms.TextBox txtHecm;
        private System.Windows.Forms.GroupBox vaxt;
        private System.Windows.Forms.TextBox txtVaxt;
        private System.Windows.Forms.Button btnVaxt;
        private System.Windows.Forms.NumericUpDown nud2Kiran;
        private System.Windows.Forms.NumericUpDown nud1Kiran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox hovuz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

