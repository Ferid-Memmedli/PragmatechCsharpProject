namespace TodoAppForm
{
    partial class TodoAppForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.altPanel = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gbOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.altPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbOperation);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 466);
            this.panel1.TabIndex = 0;
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.btnExit);
            this.gbOperation.Controls.Add(this.btnGetAll);
            this.gbOperation.Controls.Add(this.btnNew);
            this.gbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperation.Location = new System.Drawing.Point(0, 137);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(147, 329);
            this.gbOperation.TabIndex = 1;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Operation";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Location = new System.Drawing.Point(3, 65);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetAll.Location = new System.Drawing.Point(3, 42);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(141, 23);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(3, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(141, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::TodoAppForm.Properties.Resources.Todoo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // altPanel
            // 
            this.altPanel.Controls.Add(this.lblDateTime);
            this.altPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.altPanel.Location = new System.Drawing.Point(147, 431);
            this.altPanel.Name = "altPanel";
            this.altPanel.Size = new System.Drawing.Size(887, 35);
            this.altPanel.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateTime.Location = new System.Drawing.Point(750, 11);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(34, 15);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Tarix";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // TodoAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 466);
            this.Controls.Add(this.altPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "TodoAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoAppForm";
            this.Load += new System.EventHandler(this.TodoAppForm_Load);
            this.panel1.ResumeLayout(false);
            this.gbOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.altPanel.ResumeLayout(false);
            this.altPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel altPanel;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
    }
}

