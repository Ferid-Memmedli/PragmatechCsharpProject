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
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll();
            dataGridView.Columns["Id"].Visible = false;
        }
        private void btnPending_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Pending);
            dataGridView.Columns["Id"].Visible = false;
        }
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Completed);
            dataGridView.Columns["Id"].Visible = false;
        }
        private void btnCanceled_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.Canceled);
            dataGridView.Columns["Id"].Visible = false;
        }
        private void btnInCompleted_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _todoService.GetAll(Status.InCompleted);
            dataGridView.Columns["Id"].Visible = false;
        }
        #endregion
    }
}
