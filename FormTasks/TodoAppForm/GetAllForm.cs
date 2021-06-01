using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TodoAppForm.Bussiness.Abstract;
using TodoAppForm.Bussiness.Concrete;
using TodoAppForm.DataAcces.Concrete;
using TodoAppForm.Enums;

namespace TodoAppForm
{
    public partial class getAllForm : Form
    {
        #region fields
        private readonly ITodoService _todoService;
        #endregion

        #region ctor
        public getAllForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
        }
        #endregion

        #region methods
        private void getAllForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll();
            dataGridView.Columns["Id"].Visible = false;
            lblCount.Text = _todoService.Count().ToString();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll();
        }


        private void btnSuspended_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Suspended);
        }
        private void btnPending_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Pending);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Completed);
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Canceled);
        }

        private void btnInCompleted_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.InCompleted);
        }

        private void btnGeneralImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.GeneralImportant);
        }

        private void btnLessImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.LessImportant);
        }

        private void btnUnimportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.Unimportant);
        }

        private void btnImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.Important);
        }

        private void btnVeryImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.VeryImportant);
        }

        #endregion
    }
}
