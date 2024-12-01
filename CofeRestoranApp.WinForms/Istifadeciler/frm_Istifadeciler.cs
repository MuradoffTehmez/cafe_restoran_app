using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Utilities;

namespace CofeRestoranApp.WinForms.Istifadeciler
{
    public partial class Frm_Istifadeci_Giris : DevExpress.XtraEditors.XtraForm
    {
        private  CafeContext context = new CafeContext();

        private bool giris;
        public Frm_Istifadeci_Giris()
        {
            InitializeComponent();
            MelumatGetir();
        }

        void MelumatGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                Txt_Kullanici_Adi.Text = Properties.Settings.Default.KullaniciAdi;
                Txt_Sifre.Text = Properties.Settings.Default.Parola;
                check_Yadda_Saxla.Checked = true;
            }
            else
            {
                Txt_Kullanici_Adi.Text = null;
                Txt_Sifre.Text = null;
                check_Yadda_Saxla.Checked = false;
            }
        }

        void MelumatQeydEt()
        {
            if (check_Yadda_Saxla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = Txt_Kullanici_Adi.Text;
                Properties.Settings.Default.Parola= Txt_Sifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }

        private void frm_Istifadeciler_Load(object sender, EventArgs e)
        {

        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void Frm_Istifadeci_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {
                var user = context.Istifadeciler
                    .FirstOrDefault(i => i.IstifadeciAdi == Txt_Kullanici_Adi.Text && i.Parol == Txt_Sifre.Text);
                if (user != null)
                {
                    giris = true;  
                    MelumatQeydEt();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır.", "Giriş xətası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Logger.LogError(ex.Message, ex);
            }
        }

        private void Btn_Sifre_Deyis_Click(object sender, EventArgs e)
        {
            Frm_Parol_Sirifla frm = new Frm_Parol_Sirifla();
            frm.ShowDialog();
        }

        private void hyper_Qeydiyyat_Click(object sender, EventArgs e)
        {
            Frm_Qeydiyyat frm = new Frm_Qeydiyyat(new CafeRestoranApp.Entities.Models.Istifadeciler());
            frm.ShowDialog();
        }
    }
}