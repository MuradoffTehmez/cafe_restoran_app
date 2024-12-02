using CafeRestoranApp.Entities.Models;
using CofeRestoranApp.WinForms.WinTools;
using System;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Durumu : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();

        public Frm_Masa_Durumu()
        {
            InitializeComponent();
            DinamikMasalar.MasaGetir(context, flowLayoutPanel1);
        }

        private void Frm_Masa_Durumu_Load(object sender, EventArgs e)
        {

        }
    }
}