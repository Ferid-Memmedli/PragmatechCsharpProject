using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTask
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }
        DataSource db;
        private void PersonForm_Load(object sender, EventArgs e)
        {
            db = new DataSource();
            lbDataAll.DataSource = db.GetAll();
            lbFormat.Items.Add("Name Surname");
            lbFormat.Items.Add("Name Surname, Country");
            lbFormat.Items.Add("Name Surname, Country, City");
            lbFormat.Items.Add("Name Surname, Country, City, Birthdate");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.Add
                (                
                new Person()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    BirthDate = dtBirthdate.Value
                });
            lbDataAll.DataSource = db.GetAll();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Person person = (Person)lbDataAll.SelectedItem;

            switch (lbFormat.SelectedIndex)
            {
                case 0:
                    FormatAdd(person, FormatNS);
                    break;
                case 1:
                    FormatAdd(person,FormatNSC);
                    break;
                case 2:
                    FormatAdd(person,FormatNSCC);
                    break;
                case 3:
                    FormatAdd(person,FormatNSCCB);
                    break;
            }
        }
        private void FormatAdd( Person person, Action<Person> addObjHandler)
        {
            addObjHandler.Invoke(person);
        }
        private void FormatNS(Person person)
        {
            lblShowData.Text = $"{person.Name} {person.Surname}";
        }
        private void FormatNSC(Person person)
        {
            lblShowData.Text = $"{person.Name} {person.Surname},Country: {person.Country}";
        }
        private void FormatNSCC(Person person)
        {
            lblShowData.Text = $"{person.Name} {person.Surname},Country: {person.Country},City: {person.City}";
        }
        private void FormatNSCCB(Person person)
        {
            lblShowData.Text = $"{person.Name} {person.Surname},Country: {person.Country},City: {person.City},Birthdate: {person.BirthDate.ToShortDateString()}";
        }
    }
}
