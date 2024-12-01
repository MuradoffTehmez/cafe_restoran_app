using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
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

namespace CofeRestoranApp.WinForms.Istifadeciler
{
    public partial class Frm_Parol_Sirifla : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private IstifadecilerDAL istifadecilerDal = new IstifadecilerDAL();
        // Verilənlər bazası konteksti üçün salt oxunan sahə
        private readonly CafeContext _context;

        // İstifadəçilər üçün DAL (Data Access Layer) sahəsi
        private readonly IstifadecilerDAL _istifadecilerDal;

        // Form konstruktoru

        public Frm_Parol_Sirifla()
        {
            InitializeComponent();
            _context = new CafeContext();
            _istifadecilerDal = new IstifadecilerDAL();
        }

        private void Frm_Parol_Sirifla_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Qeyd_Et_Click(object sender, EventArgs e)
        {
            var entity = istifadecilerDal.GetByFilter(context,
                T => T.IstifadeciAdi == Txt_Istifadeci_Adi.Text || T.Email == Txt_Istifadeci_Adi.Text);
            if (entity!=null)
            {
                if (entity.HatirlamaSuali==Txt_Sual.Text && entity.Cavab==Txt_Cavab.Text)
                {
                    if (Txt_Parol.Text==Txt_Parol_Tekrar.Text)
                    {
                        entity.Parol = Txt_Parol.Text;
                        if (istifadecilerDal.AddOrUpdate(context,entity))
                        {
                            istifadecilerDal.Save(context);
                            MessageBox.Show("Porol Deyisdirildi");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Porol deyisdirilen zaman xeta bas verdi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Porol duzgun yazilmayib");
                    }
                }
                else
                {
                    MessageBox.Show("Sual veya Cavab Dogru deyil");
                }
            }
            else
            {
                MessageBox.Show("Bele bir istifadeci yoxdur");
            }
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}