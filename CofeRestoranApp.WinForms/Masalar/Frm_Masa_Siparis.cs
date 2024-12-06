using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using CofeRestoranApp.WinForms.Urunler;
using System;
using System.Data.Entity;
using System.Linq;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Siparis : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDAL musterilerDAL = new MusterilerDAL();
        private MasaHerekleriDAL masaHerekleriDAL = new MasaHerekleriDAL();
        private int? _masaId = null;
        private string _satiskodu = null;

        public Frm_Masa_Siparis(int? masaId = null, string masaadi = null, string satiskodu = null)
        {
            InitializeComponent();

            _masaId = masaId;
            _satiskodu = satiskodu;
            context.MasaHaraketleri.Where(m => m.SatisKodu == _satiskodu).Load();
            context.OdenisTarixcesi.Where(o => o.SatisKodu == _satiskodu).Load();
            context.Urun.Load();
            gridControlSiparisler.DataSource = context.MasaHaraketleri.Local.ToBindingList();
            gridControlOdenisler.DataSource = context.OdenisTarixcesi.Local.ToBindingList();

            lookUpMusteri.Properties.DataSource = musterilerDAL.GetAll(context);
            if (_masaId != null)
            {
                Lbn_Basliq.Text = masaadi + "  Siparisleri";
            }
        }

        void hesabla()
        {
            Calc_EndirimToplam.Value = Convert.ToDecimal(colEndirimQiymeti.SummaryItem.SummaryValue);
            Calc_EndirimliToplam.Value = Convert.ToDecimal(ColmnTutar.SummaryItem.SummaryValue);
            CalcOdeden.Value = Convert.ToDecimal(colOdenis.SummaryItem.SummaryValue);
            Calc_Toplam.Value = Calc_EndirimToplam.Value + Calc_EndirimliToplam.Value;
            CalcKalan.Value = Calc_EndirimliToplam.Value - Calc_Toplam.Value;
            /*************************************************************************************/
            /// Endirim Orani
            if (Calc_Toplam.Value != 0)
            {
                //Calc_Endirim_Orani.Value = 100 * Calc_EndirimToplam.Value / Calc_Toplam.Value;

                Calc_Endirim_Orani.Value = 100 * Convert.ToDecimal(colEndirimQiymeti.SummaryItem.SummaryValue) /
                                            (Convert.ToDecimal(ColmnTutar.SummaryItem.SummaryValue) +
                                             Convert.ToDecimal(colEndirimQiymeti.SummaryItem.SummaryValue));
            }
            else if (Calc_Toplam.Value == 0)
            {
                Calc_Endirim_Orani.Value = 0;
            }

        }
        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //hesabla();
        }

        private void OdenisSİlGr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //hesabla();
        }

        private void Btn_Yeni_Sifaris_Click(object sender, EventArgs e)
        {
            Frm_UrunSec frm = new Frm_UrunSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                MasaHaraketleri entity = new MasaHaraketleri
                {
                    SatisKodu = _satiskodu,
                    MasaId = Convert.ToInt32(_masaId),
                    UrunId = frm.urunModel.Id,
                    Miqdari = 1,
                    Qiymeti = frm.urunModel.Qiymet1,
                    EndirimQiymeti = 0,
                    Aciklama = "",
                    Tarix = DateTime.Now
                };
                masaHerekleriDAL.AddOrUpdate(context, entity);
            }
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewSiparisler_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //hesabla();
        }

        private void gridViewSiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            hesabla();
        }
    }
}