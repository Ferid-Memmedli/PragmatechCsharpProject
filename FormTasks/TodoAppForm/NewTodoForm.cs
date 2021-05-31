using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TodoAppForm.Bussiness.Abstract;
using TodoAppForm.Bussiness.Concrete;
using TodoAppForm.Constans;
using TodoAppForm.DataAcces.Concrete;
using TodoAppForm.Entities.Concrete;
using TodoAppForm.Enums;
using TodoAppForm.Methods;

namespace TodoAppForm
{
    public partial class NewTodoForm : Form
    {
        #region fields
        private readonly ITodoService _todoService;
        #endregion

        #region ctors
        public NewTodoForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
        }
        #endregion

        #region methods
        private void NewTodoForm_Load(object sender, EventArgs e)
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (!GlobalMethods.TextBoxIsNullOrEmpty(this) && int.TryParse(txtImportance.Text,out int importance))
            {
                result = _todoService.Add(new TodoEntity 
                {
                    Id = Guid.NewGuid(),
                    Title = txtTitle.Text,
                    ShortDescription = txtShort.Text,
                    Description = txtDesc.Text,
                    ImportanceLevel = importance,
                    Status = (Status)cmbStatus.SelectedItem 
                });
            }


            if (result == 1)
            {
                MessageBox.Show(GlobalConstants.AddSuccess, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,MessageBoxIcon.Information);
                DialogResult dialogResult = MessageBox.Show (GlobalConstants.AddOperationAgain,GlobalConstants.CaptionQuestion,MessageBoxButtons.YesNo,MessageBoxIcon.Question );
                if (dialogResult == DialogResult.Yes)
                    GlobalMethods.Clear(this);
                else
                {
                    Form getAllForm = Application.OpenForms["getAllForm"];
                    if (getAllForm == null)
                    {
                        getAllForm = new getAllForm();
                        getAllForm.MdiParent = Application.OpenForms["TodoAppForm"];
                        getAllForm.StartPosition = FormStartPosition.CenterScreen;
                        GroupBox listGroupBox = (GroupBox)getAllForm.Controls["gbList"];
                        DataGridView dataGridView = (DataGridView)listGroupBox.Controls["dataGridView"];
                        dataGridView.DataSource = null;
                        getAllForm.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox listGroupBox = (GroupBox)getAllForm.Controls["gbList"];
                        DataGridView dataGridView = (DataGridView)listGroupBox.Controls["dataGridView"];
                        dataGridView.DataSource = null;
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show(GlobalConstants.AddError, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,MessageBoxIcon.Error);
                GlobalMethods.Clear(this);
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightGray;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }
        #endregion
    }
}
