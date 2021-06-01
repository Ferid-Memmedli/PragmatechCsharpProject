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
            lblCount.Text = _todoService.Count().ToString();
        }

        private void btnSuspended_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Suspended);
            lblCount.Text = _todoService.GetAll(Status.Suspended).Count().ToString();
        }
        private void btnPending_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Pending);
            lblCount.Text = _todoService.GetAll(Status.Pending).Count().ToString();

        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Completed);
            lblCount.Text = _todoService.GetAll(Status.Completed).Count().ToString();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Canceled);
            lblCount.Text = _todoService.GetAll(Status.Canceled).Count().ToString();
        }

        private void btnInCompleted_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.InCompleted);
            lblCount.Text = _todoService.GetAll(Status.InCompleted).Count().ToString();
        }

        private void btnGeneralImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.GeneralImportant);
            lblCount.Text = _todoService.GetAll(ImportanceLevel.GeneralImportant).Count().ToString();
        }

        private void btnLessImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.LessImportant);
            lblCount.Text = _todoService.GetAll(ImportanceLevel.LessImportant).Count().ToString();
        }

        private void btnUnimportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.Unimportant);
            lblCount.Text = _todoService.GetAll(ImportanceLevel.Unimportant).Count().ToString();
        }

        private void btnImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.Important);
            lblCount.Text = _todoService.GetAll(ImportanceLevel.Important).Count().ToString();
        }

        private void btnVeryImportant_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(ImportanceLevel.VeryImportant);
            lblCount.Text = _todoService.GetAll(ImportanceLevel.VeryImportant).Count().ToString();
        }

        #endregion
    }
}
