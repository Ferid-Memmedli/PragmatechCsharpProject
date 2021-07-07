namespace DelegateTask
{
    partial class PersonForm
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
            this.gpbDataAdd = new System.Windows.Forms.GroupBox();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lbFormat = new System.Windows.Forms.ListBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblShowData = new System.Windows.Forms.Label();
            this.lbDataAll = new System.Windows.Forms.ListBox();
            this.gpbDataAdd.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDataAdd
            // 
            this.gpbDataAdd.Controls.Add(this.dtBirthdate);
            this.gpbDataAdd.Controls.Add(this.txtCountry);
            this.gpbDataAdd.Controls.Add(this.txtCity);
            this.gpbDataAdd.Controls.Add(this.btnAdd);
            this.gpbDataAdd.Controls.Add(this.txtSurname);
            this.gpbDataAdd.Controls.Add(this.txtName);
            this.gpbDataAdd.Controls.Add(this.label5);
            this.gpbDataAdd.Controls.Add(this.label4);
            this.gpbDataAdd.Controls.Add(this.label3);
            this.gpbDataAdd.Controls.Add(this.label2);
            this.gpbDataAdd.Controls.Add(this.label1);
            this.gpbDataAdd.Location = new System.Drawing.Point(12, 14);
            this.gpbDataAdd.Name = "gpbDataAdd";
            this.gpbDataAdd.Size = new System.Drawing.Size(269, 203);
            this.gpbDataAdd.TabIndex = 0;
            this.gpbDataAdd.TabStop = false;
            this.gpbDataAdd.Text = "Person Data Add";
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(71, 143);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(192, 23);
            this.dtBirthdate.TabIndex = 9;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(71, 114);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(192, 23);
            this.txtCountry.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(71, 85);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(192, 23);
            this.txtCity.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(188, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(71, 52);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(192, 23);
            this.txtSurname.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 23);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lbFormat);
            this.gpbInfo.Controls.Add(this.btnInfo);
            this.gpbInfo.Controls.Add(this.lblShowData);
            this.gpbInfo.Location = new System.Drawing.Point(12, 223);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(543, 161);
            this.gpbInfo.TabIndex = 1;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Info";
            // 
            // lbFormat
            // 
            this.lbFormat.FormattingEnabled = true;
            this.lbFormat.ItemHeight = 15;
            this.lbFormat.Location = new System.Drawing.Point(6, 22);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(263, 94);
            this.lbFormat.TabIndex = 10;
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Location = new System.Drawing.Point(275, 22);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblShowData
            // 
            this.lblShowData.AutoSize = true;
            this.lblShowData.Location = new System.Drawing.Point(6, 129);
            this.lblShowData.Name = "lblShowData";
            this.lblShowData.Size = new System.Drawing.Size(27, 15);
            this.lblShowData.TabIndex = 5;
            this.lblShowData.Text = "null";
            // 
            // lbDataAll
            // 
            this.lbDataAll.FormattingEnabled = true;
            this.lbDataAll.ItemHeight = 15;
            this.lbDataAll.Location = new System.Drawing.Point(287, 23);
            this.lbDataAll.Name = "lbDataAll";
            this.lbDataAll.Size = new System.Drawing.Size(270, 184);
            this.lbDataAll.TabIndex = 9;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 392);
            this.Controls.Add(this.lbDataAll);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.gpbDataAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.gpbDataAdd.ResumeLayout(false);
            this.gpbDataAdd.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDataAdd;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label lblShowData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ListBox lbDataAll;
        private System.Windows.Forms.ListBox lbFormat;
    }
}

