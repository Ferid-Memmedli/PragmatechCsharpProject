using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TodoAppForm.Bussiness.Abstract;
using TodoAppForm.Bussiness.Concrete;
using TodoAppForm.Constans;
using TodoAppForm.DataAcces.Concrete;
using TodoAppForm.Methods;

namespace TodoAppForm
{
    public partial class TodoAppForm : Form
    {
        #region fields
        private Form _form;
        private readonly ITodoService _todoService;
        #endregion

        #region ctors
        public TodoAppForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
        }
        #endregion

        #region methods
        private void TodoAppForm_Load(object sender, EventArgs e)
        {
            GlobalMethods.GetDateTime(timerDateTime, timerDateTime_Tick);  //Tarix
            GlobalMethods.OperationBtnEnabled(gbOperation,false);  //Operationdaki Buttonlarin False olunmasi
            LoginForm loginForm = new LoginForm
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            loginForm.Show();  //Login Formun Ekrana Getirilmesi
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewTodoForm"] != null)
            {
                _form = Application.OpenForms["NewTodoForm"];
                _form.Focus();
            }
            else
            {
                if (Application.OpenForms["getAllForm"] != null)
                    Application.OpenForms["getAllForm"].Close();

                NewTodoForm form = new NewTodoForm();
                form.MdiParent = this;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["getAllForm"] != null)
            {
                _form = Application.OpenForms["getAllForm"];
                _form.Focus();
            }
            else
            {
                if (_todoService.Count() > 0)
                {
                    if (Application.OpenForms["NewTodoForm"] != null)
                        Application.OpenForms["NewTodoForm"].Close();
                    getAllForm form = new getAllForm();
                    form.MdiParent = Application.OpenForms["TodoAppForm"];
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                }
                else
                    MessageBox.Show(GlobalConstants.EmptyList, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  //Esas Appdan Exit edilmesi
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("g");
        }

        #endregion
    }
}
