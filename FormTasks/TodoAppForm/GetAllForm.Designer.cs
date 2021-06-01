
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
            this.gbLevelFilter = new System.Windows.Forms.GroupBox();
            this.btnVeryImportant = new System.Windows.Forms.Button();
            this.btnImportant = new System.Windows.Forms.Button();
            this.btnUnimportant = new System.Windows.Forms.Button();
            this.btnLessImportant = new System.Windows.Forms.Button();
            this.btnGeneralImportant = new System.Windows.Forms.Button();
            this.gbStatusFilter = new System.Windows.Forms.GroupBox();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnInCompleted = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblListCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnSuspended = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbOperation.SuspendLayout();
            this.gbLevelFilter.SuspendLayout();
            this.gbStatusFilter.SuspendLayout();
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
            this.gbOperation.Controls.Add(this.gbLevelFilter);
            this.gbOperation.Controls.Add(this.gbStatusFilter);
            this.gbOperation.Controls.Add(this.btnAll);
            this.gbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperation.Location = new System.Drawing.Point(0, 0);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(139, 411);
            this.gbOperation.TabIndex = 0;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Operation";
            // 
            // gbLevelFilter
            // 
            this.gbLevelFilter.Controls.Add(this.btnVeryImportant);
            this.gbLevelFilter.Controls.Add(this.btnImportant);
            this.gbLevelFilter.Controls.Add(this.btnUnimportant);
            this.gbLevelFilter.Controls.Add(this.btnLessImportant);
            this.gbLevelFilter.Controls.Add(this.btnGeneralImportant);
            this.gbLevelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLevelFilter.Location = new System.Drawing.Point(3, 182);
            this.gbLevelFilter.Name = "gbLevelFilter";
            this.gbLevelFilter.Size = new System.Drawing.Size(133, 143);
            this.gbLevelFilter.TabIndex = 12;
            this.gbLevelFilter.TabStop = false;
            this.gbLevelFilter.Text = "Level Filter";
            // 
            // btnVeryImportant
            // 
            this.btnVeryImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeryImportant.Location = new System.Drawing.Point(3, 111);
            this.btnVeryImportant.Name = "btnVeryImportant";
            this.btnVeryImportant.Size = new System.Drawing.Size(127, 23);
            this.btnVeryImportant.TabIndex = 6;
            this.btnVeryImportant.Text = "Very Important";
            this.btnVeryImportant.UseVisualStyleBackColor = true;
            this.btnVeryImportant.Click += new System.EventHandler(this.btnVeryImportant_Click);
            // 
            // btnImportant
            // 
            this.btnImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportant.Location = new System.Drawing.Point(3, 88);
            this.btnImportant.Name = "btnImportant";
            this.btnImportant.Size = new System.Drawing.Size(127, 23);
            this.btnImportant.TabIndex = 7;
            this.btnImportant.Text = "Important";
            this.btnImportant.UseVisualStyleBackColor = true;
            this.btnImportant.Click += new System.EventHandler(this.btnImportant_Click);
            // 
            // btnUnimportant
            // 
            this.btnUnimportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnimportant.Location = new System.Drawing.Point(3, 65);
            this.btnUnimportant.Name = "btnUnimportant";
            this.btnUnimportant.Size = new System.Drawing.Size(127, 23);
            this.btnUnimportant.TabIndex = 10;
            this.btnUnimportant.Text = "Unimportant";
            this.btnUnimportant.UseVisualStyleBackColor = true;
            this.btnUnimportant.Click += new System.EventHandler(this.btnUnimportant_Click);
            // 
            // btnLessImportant
            // 
            this.btnLessImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLessImportant.Location = new System.Drawing.Point(3, 42);
            this.btnLessImportant.Name = "btnLessImportant";
            this.btnLessImportant.Size = new System.Drawing.Size(127, 23);
            this.btnLessImportant.TabIndex = 8;
            this.btnLessImportant.Text = "Less Important";
            this.btnLessImportant.UseVisualStyleBackColor = true;
            this.btnLessImportant.Click += new System.EventHandler(this.btnLessImportant_Click);
            // 
            // btnGeneralImportant
            // 
            this.btnGeneralImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneralImportant.Location = new System.Drawing.Point(3, 19);
            this.btnGeneralImportant.Name = "btnGeneralImportant";
            this.btnGeneralImportant.Size = new System.Drawing.Size(127, 23);
            this.btnGeneralImportant.TabIndex = 9;
            this.btnGeneralImportant.Text = "General Important";
            this.btnGeneralImportant.UseVisualStyleBackColor = true;
            this.btnGeneralImportant.Click += new System.EventHandler(this.btnGeneralImportant_Click);
            // 
            // gbStatusFilter
            // 
            this.gbStatusFilter.Controls.Add(this.btnSuspended);
            this.gbStatusFilter.Controls.Add(this.btnPending);
            this.gbStatusFilter.Controls.Add(this.btnCompleted);
            this.gbStatusFilter.Controls.Add(this.btnInCompleted);
            this.gbStatusFilter.Controls.Add(this.btnCanceled);
            this.gbStatusFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbStatusFilter.Location = new System.Drawing.Point(3, 42);
            this.gbStatusFilter.Name = "gbStatusFilter";
            this.gbStatusFilter.Size = new System.Drawing.Size(133, 140);
            this.gbStatusFilter.TabIndex = 11;
            this.gbStatusFilter.TabStop = false;
            this.gbStatusFilter.Text = "Status Filter";
            // 
            // btnPending
            // 
            this.btnPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPending.Location = new System.Drawing.Point(3, 88);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(127, 23);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompleted.Location = new System.Drawing.Point(3, 65);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(127, 23);
            this.btnCompleted.TabIndex = 3;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnInCompleted
            // 
            this.btnInCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInCompleted.Location = new System.Drawing.Point(3, 42);
            this.btnInCompleted.Name = "btnInCompleted";
            this.btnInCompleted.Size = new System.Drawing.Size(127, 23);
            this.btnInCompleted.TabIndex = 5;
            this.btnInCompleted.Text = "InCompleted";
            this.btnInCompleted.UseVisualStyleBackColor = true;
            this.btnInCompleted.Click += new System.EventHandler(this.btnInCompleted_Click);
            // 
            // btnCanceled
            // 
            this.btnCanceled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanceled.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanceled.Location = new System.Drawing.Point(3, 19);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(127, 23);
            this.btnCanceled.TabIndex = 4;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.UseVisualStyleBackColor = true;
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
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
            this.gbList.Size = new System.Drawing.Size(713, 384);
            this.gbList.TabIndex = 1;
            this.gbList.TabStop = false;
            this.gbList.Text = "List";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(707, 362);
            this.dataGridView.TabIndex = 0;
            // 
            // lblListCount
            // 
            this.lblListCount.AutoSize = true;
            this.lblListCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListCount.Location = new System.Drawing.Point(737, 387);
            this.lblListCount.Name = "lblListCount";
            this.lblListCount.Size = new System.Drawing.Size(68, 15);
            this.lblListCount.TabIndex = 2;
            this.lblListCount.Text = "List Count :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(811, 387);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 15);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "0";
            // 
            // btnSuspended
            // 
            this.btnSuspended.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuspended.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuspended.Location = new System.Drawing.Point(3, 111);
            this.btnSuspended.Name = "btnSuspended";
            this.btnSuspended.Size = new System.Drawing.Size(127, 23);
            this.btnSuspended.TabIndex = 6;
            this.btnSuspended.Text = "Suspended";
            this.btnSuspended.UseVisualStyleBackColor = true;
            this.btnSuspended.Click += new System.EventHandler(this.btnSuspended_Click);
            // 
            // getAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 411);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblListCount);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "getAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get All Form";
            this.Load += new System.EventHandler(this.getAllForm_Load);
            this.panel1.ResumeLayout(false);
            this.gbOperation.ResumeLayout(false);
            this.gbLevelFilter.ResumeLayout(false);
            this.gbStatusFilter.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblListCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnVeryImportant;
        private System.Windows.Forms.Button btnUnimportant;
        private System.Windows.Forms.Button btnGeneralImportant;
        private System.Windows.Forms.Button btnLessImportant;
        private System.Windows.Forms.Button btnImportant;
        private System.Windows.Forms.GroupBox gbLevelFilter;
        private System.Windows.Forms.GroupBox gbStatusFilter;
        private System.Windows.Forms.Button btnSuspended;
    }
}