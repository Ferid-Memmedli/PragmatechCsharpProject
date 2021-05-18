using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal cavab = 0;
        string emeliyyat;
        string old;
        bool optDurum = false;
        bool gosterisDurum = false;
        private void button13_Click_1(object sender, EventArgs e)
        {
            optDurum = true;
            emeliyyat = ((Button)sender).Text;
            decimal eded = decimal.Parse(textBox1.Text);
            switch (old)
            {                
                case "+":
                    textBox1.Text = (cavab + eded).ToString(); break;
                case "-":
                    textBox1.Text = (cavab - eded).ToString(); break;
                case "*":
                    textBox1.Text = (cavab * eded).ToString(); break;
                case "/":
                    textBox1.Text = eded == 0 ? "Error" : (cavab / eded).ToString(); break;
            }
            if (textBox1.Text == "Error")
                cavab = 0;
            else
            {
                cavab = decimal.Parse(textBox1.Text);
                textBox1.Text = cavab.ToString();
            }
            old = emeliyyat;
            if (gosterisDurum == true)
            {
                lblGoster.Text = "";
                lblGoster.Text += $"{eded} {emeliyyat} ";
                gosterisDurum = false;
            }
            else
                lblGoster.Text += $"{eded} {emeliyyat} ";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            optDurum = true;
            decimal eded = decimal.Parse(textBox1.Text);
            switch (old)
            {
                case "+":
                    textBox1.Text = (cavab + eded).ToString(); break;
                case "-":
                    textBox1.Text = (cavab - eded).ToString(); break;
                case "*":
                    textBox1.Text = (cavab * eded).ToString(); break;
                case "/":
                    textBox1.Text = eded == 0 ? "Error" : (cavab / eded).ToString(); break;
            }
            old = "";
            if (textBox1.Text == "Error")
                cavab = 0;
            else
            {
                cavab = decimal.Parse(textBox1.Text);
                textBox1.Text = cavab.ToString();
            }
            lblGoster.Text = $"{cavab}";
            gosterisDurum = true;
        }
        #region Reqemler
        private void iEdedler(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || optDurum)
                textBox1.Clear();
            else if (textBox1.Text == "Error")
                textBox1.Clear();
            optDurum = false;
            textBox1.Text += ((Button)sender).Text;
        }
        #endregion
        #region Klavye Key Oxuma
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
                button11.PerformClick();
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                button1.PerformClick();
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                button4.PerformClick();
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                button7.PerformClick();
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                button2.PerformClick();
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
                button5.PerformClick();
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
                button8.PerformClick();
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
                button3.PerformClick();
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
                button6.PerformClick();
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                button10.PerformClick();
            else if (e.KeyCode == Keys.Back)
                button17.PerformClick();
            else if (e.KeyCode == Keys.Delete)
                buttonc.PerformClick();
            else if (e.KeyCode == Keys.OemMinus)
                button16.PerformClick();
            else if (e.KeyCode == Keys.Oemplus)
                button15.PerformClick();
            else if (e.KeyCode == Keys.Divide)
                button13.PerformClick();
            else if (e.KeyCode == Keys.OemPeriod)
                button9.PerformClick();
        }
        #endregion
        #region Silme Islemleri
        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            cavab = 0;
            optDurum = false;
            lblGosteris.Text = "";
        }
        private void buttonsil_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                optDurum = false;
                textBox1.Text = "0";
                cavab = 0;
                lblGoster.Text = "";
            }
        }

        #endregion
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(".") < 1)
                textBox1.Text += ".";
        }
    }
}
