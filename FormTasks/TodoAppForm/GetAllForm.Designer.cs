
namespace TodoAppForm
{
    partial class getAllForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.btnInCompleted = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbOperation.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbOperation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 411);
            this.panel1.TabIndex = 0;
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.btnInCompleted);
            this.gbOperation.Controls.Add(this.btnCanceled);
            this.gbOperation.Controls.Add(this.btnCompleted);
            this.gbOperation.Controls.Add(this.btnPending);
            this.gbOperation.Controls.Add(this.btnAll);
            this.gbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperation.Location = new System.Drawing.Point(0, 0);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(139, 411);
            this.gbOperation.TabIndex = 0;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Operation";
            // 
            // btnInCompleted
            // 
            this.btnInCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInCompleted.Location = new System.Drawing.Point(3, 111);
            this.btnInCompleted.Name = "btnInCompleted";
            this.btnInCompleted.Size = new System.Drawing.Size(133, 23);
            this.btnInCompleted.TabIndex = 5;
            this.btnInCompleted.Text = "In Completed";
            this.btnInCompleted.UseVisualStyleBackColor = true;
            this.btnInCompleted.Click += new System.EventHandler(this.btnInCompleted_Click);
            // 
            // btnCanceled
            // 
            this.btnCanceled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanceled.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanceled.Location = new System.Drawing.Point(3, 88);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(133, 23);
            this.btnCanceled.TabIndex = 4;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.UseVisualStyleBackColor = true;
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompleted.Location = new System.Drawing.Point(3, 65);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(133, 23);
            this.btnCompleted.TabIndex = 3;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnPending
            // 
            this.btnPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPending.Location = new System.Drawing.Point(3, 42);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(133, 23);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.Location = new System.Drawing.Point(3, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(133, 23);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Get All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dataGridView);
            this.gbList.Location = new System.Drawing.Point(146, 0);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(713, 399);
            this.gbList.TabIndex = 1;
            this.gbList.TabStop = false;
            this.gbList.Text = "List";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(707, 377);
            this.dataGridView.TabIndex = 0;
            // 
            // getAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 411);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "getAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get All Form";
            this.Load += new System.EventHandler(this.getAllForm_Load);
            this.panel1.ResumeLayout(false);
            this.gbOperation.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.Button btnCanceled;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnInCompleted;
    }
}