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
        private void Form1_Load(object sender, EventArgs e)
        {
            DataSource dataSource = new DataSource();
            dataGridView1.DataSource = dataSource.GetAll().OrderBy(p => p.Profession).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
