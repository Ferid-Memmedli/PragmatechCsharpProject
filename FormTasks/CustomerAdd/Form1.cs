﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAdd
{
    //1. new customer addition form:
    //- Adi , soyadi, email ve nomresi olan musterini virtual dbya elave etmelisiz, save button-nuna klik olunan zaman
    //- qarsi terefden yeni musteri elave edib etmeyeceyini sorusun, cavab yes oldugu teqdirde,
    //- windowsda notification gorsedilecek Information xarakterli bu notificationda hazirda cari musteri sayi gosterilecek,
    //- ve textbox deyerleri silinmelidir ki adam yeni melumatlari daxil ede bilsin , cavab NO olarsada textbox deyerleri silinmelidir ve hemen ardindan
    //- formda olan listBox-da musterinin adi soyadi gosterilir.dizayn isteyinize gore seliqeli sekilde sadece ola biler.
    public partial class Form1 : Form
    {
        public static readonly List<Musteri> musteriler = new List<Musteri>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMusteriSave_Click(object sender, EventArgs e)
        {
            var uzunluq = musteriler.Count;
            DialogResult cavab = MessageBox.Show("Yeni Musteri Elave Edilsinmi?", "Xebardarliq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cavab == DialogResult.Yes)
            {
                Musteri musteri = new Musteri()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Email = txtEmail.Text,
                    Nomre = txtNomre.Text
                };
                musteriler.Add(musteri);
            }
            //lstboxDbShow.DataSource = musteriler;
            lstboxDbShow.Items.Clear();
            foreach (var item in musteriler)
                lstboxDbShow.Items.Add(item);
            #region notify
            notifyIcon = new NotifyIcon()
            {
                BalloonTipText = $"Musteri sayi : {uzunluq + 1}",
                BalloonTipTitle = "Information",
                Icon = SystemIcons.Information,
                Visible = true
            };
            notifyIcon.ShowBalloonTip(1500);
            #endregion
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtNomre.Clear();
        }
    }
}
