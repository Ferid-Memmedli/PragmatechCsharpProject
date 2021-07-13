using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridDelegatePerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSource dataSource = new DataSource();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSource.GetAllOrderByProfession();
            listBoxSiralama.Items.Add("Name");
            listBoxSiralama.Items.Add("Profession");
            listBoxSiralama.Items.Add("Country");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 3)
            {
               // string siralama = listBoxSiralama.SelectedItem.ToString();

                switch (listBoxSiralama.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = dataSource.GetAll(p => p.Name.ToUpper().Contains(txtSearch.Text.ToUpper()));
                        break;
                    case 1:
                        dataGridView1.DataSource = dataSource.GetAll(p => p.Profession.ToUpper().Contains(txtSearch.Text.ToUpper()));

                        break;
                    case 2:
                        dataGridView1.DataSource = dataSource.GetAll(p => p.Country.ToUpper().Contains(txtSearch.Text.ToUpper()));
                        break;
                }
            }
            else
            {
                MessageBox.Show("En az 3 herif daxil edilmelidi", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 
    }
}
