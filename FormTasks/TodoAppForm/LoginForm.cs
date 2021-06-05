using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoAppForm.Bussiness.Abstract;
using TodoAppForm.Bussiness.Concrete;
using TodoAppForm.Constans;
using TodoAppForm.DataAcces.Concrete;
using TodoAppForm.Methods;


namespace TodoAppForm
{
    public partial class LoginForm : Form
    {
        #region Ctors
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {
                IUserService userService = new UserService(new InMemoryUserDal());
                var user = userService.GetUser(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    Form todoListForm = Application.OpenForms[GlobalConstants.TodoAppForm];
                    Panel leftSideBarPanel = (Panel)todoListForm.Controls["panel1"];
                    GroupBox grpBox = (GroupBox)leftSideBarPanel.Controls["gbOperation"];
                    GlobalMethods.OperationBtnEnabled(grpBox,true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(GlobalConstants.InvalidAttempt, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalMethods.Clear(this);
                }
            }
            else
            {
                MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalMethods.Clear(this);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightGray;
        }

        #endregion
    }
}
