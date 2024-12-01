using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CofeRestoranApp.WinForms.Istifadeciler;
using CofeRestoranApp.WinForms.Masalar;
using CofeRestoranApp.WinForms.Menular;
using CofeRestoranApp.WinForms.Urunler;
using DevExpress.XtraEditors;

namespace CofeRestoranApp.WinForms.AnaMenu
{
    public partial class Frm_Ana_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public Frm_Ana_Form()
        {
            InitializeComponent();
            Frm_Istifadeci_Giris frm = new Frm_Istifadeci_Giris();
            frm.ShowDialog();
        }

        private void Frm_Ana_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Meynular_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Menu frm = new Frm_Menu();
            
            frm.ShowDialog();
        }

        private void btn_Urunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Urunler frm = new frm_Urunler();
            FormGetir(frm);
        }

        private void btn_Masalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Masalar frm = new Frm_Masalar();
            FormGetir(frm);
        }
    }
}