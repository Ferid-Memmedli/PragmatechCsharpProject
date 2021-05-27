namespace OdenisHesaplama
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
            this.txtQiymet = new System.Windows.Forms.TextBox();
            this.btnHesaplama = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.rbtnHecbiri = new System.Windows.Forms.RadioButton();
            this.rbtnTelebeEndirimi = new System.Windows.Forms.RadioButton();
            this.rbtnPensiyanerEndirimi = new System.Windows.Forms.RadioButton();
            this.txtTotalQiymet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQiymet
            // 
            this.txtQiymet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtQiymet.Location = new System.Drawing.Point(58, 60);
            this.txtQiymet.MaxLength = 10;
            this.txtQiymet.Name = "txtQiymet";
            this.txtQiymet.Size = new System.Drawing.Size(108, 23);
            this.txtQiymet.TabIndex = 7;
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesaplama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHesaplama.Location = new System.Drawing.Point(366, 84);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(75, 23);
            this.btnHesaplama.TabIndex = 0;
            this.btnHesaplama.Text = "Hesaplama";
            this.btnHesaplama.UseVisualStyleBackColor = true;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTemizle.Location = new System.Drawing.Point(447, 84);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qiymet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQiymet);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 136);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Add";
            // 
            // txtAd
            // 
            this.txtAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAd.Location = new System.Drawing.Point(58, 22);
            this.txtAd.MaxLength = 10;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(108, 23);
            this.txtAd.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(105, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 15;
            this.lstProduct.Location = new System.Drawing.Point(189, 9);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(171, 139);
            this.lstProduct.TabIndex = 2;
            // 
            // rbtnHecbiri
            // 
            this.rbtnHecbiri.AutoSize = true;
            this.rbtnHecbiri.Checked = true;
            this.rbtnHecbiri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnHecbiri.Location = new System.Drawing.Point(366, 12);
            this.rbtnHecbiri.Name = "rbtnHecbiri";
            this.rbtnHecbiri.Size = new System.Drawing.Size(63, 19);
            this.rbtnHecbiri.TabIndex = 8;
            this.rbtnHecbiri.TabStop = true;
            this.rbtnHecbiri.Text = "Hecbiri";
            this.rbtnHecbiri.UseVisualStyleBackColor = true;
            // 
            // rbtnTelebeEndirimi
            // 
            this.rbtnTelebeEndirimi.AutoSize = true;
            this.rbtnTelebeEndirimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTelebeEndirimi.Location = new System.Drawing.Point(366, 34);
            this.rbtnTelebeEndirimi.Name = "rbtnTelebeEndirimi";
            this.rbtnTelebeEndirimi.Size = new System.Drawing.Size(105, 19);
            this.rbtnTelebeEndirimi.TabIndex = 9;
            this.rbtnTelebeEndirimi.Text = "Telebe Endirimi";
            this.rbtnTelebeEndirimi.UseVisualStyleBackColor = true;
            // 
            // rbtnPensiyanerEndirimi
            // 
            this.rbtnPensiyanerEndirimi.AutoSize = true;
            this.rbtnPensiyanerEndirimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPensiyanerEndirimi.Location = new System.Drawing.Point(366, 59);
            this.rbtnPensiyanerEndirimi.Name = "rbtnPensiyanerEndirimi";
            this.rbtnPensiyanerEndirimi.Size = new System.Drawing.Size(129, 19);
            this.rbtnPensiyanerEndirimi.TabIndex = 10;
            this.rbtnPensiyanerEndirimi.Text = "Pensiyaner Endirimi";
            this.rbtnPensiyanerEndirimi.UseVisualStyleBackColor = true;
            // 
            // txtTotalQiymet
            // 
            this.txtTotalQiymet.Location = new System.Drawing.Point(366, 125);
            this.txtTotalQiymet.Name = "txtTotalQiymet";
            this.txtTotalQiymet.ReadOnly = true;
            this.txtTotalQiymet.Size = new System.Drawing.Size(231, 23);
            this.txtTotalQiymet.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 156);
            this.Controls.Add(this.txtTotalQiymet);
            this.Controls.Add(this.rbtnPensiyanerEndirimi);
            this.Controls.Add(this.rbtnTelebeEndirimi);
            this.Controls.Add(this.rbtnHecbiri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesaplama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odenis Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesaplama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQiymet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.RadioButton rbtnHecbiri;
        private System.Windows.Forms.RadioButton rbtnTelebeEndirimi;
        private System.Windows.Forms.RadioButton rbtnPensiyanerEndirimi;
        private System.Windows.Forms.TextBox txtTotalQiymet;
    }
}

