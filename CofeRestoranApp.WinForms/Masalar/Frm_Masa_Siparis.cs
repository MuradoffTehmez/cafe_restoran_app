using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Siparis : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDAL musterilerDAL = new MusterilerDAL();
        private int? _masaId = null;
        private string _satiskodu =null;

        public Frm_Masa_Siparis(int? masaId = null, string masaadi = null, string satiskodu = null)
        {
            InitializeComponent();
            _masaId = masaId;
            _satiskodu=satiskodu;
            context.MasaHaraketleri.Where(m => m.SatisKodu == _satiskodu).Load();
            context.OdenisTarixcesi.Where(o => o.SatisKodu == _satiskodu).Load();
            context.Urun.Load();
            context.MasaHaraketleri.Local.ToBindingList();
            context.OdenisTarixcesi.Local.ToBindingList();

            lookUpMusteri.Properties.DataSource = musterilerDAL.GetAll(context);
            if (_masaId != null)
            {
                Lbn_Basliq.Text = masaadi + "  Siparisleri";
            }
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void OdenisSİlGr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}