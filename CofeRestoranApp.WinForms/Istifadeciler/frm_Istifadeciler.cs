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
                if (context.Istifadeciler.Any(i => i.IstifadeciAdi == Txt_Kullanici_Adi.Text && i.Parol == Txt_Sifre.Text))
                {
                    giris = true;
                    this.Hide();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Logger.LogXeta(ex);
            }
        }
    }
}