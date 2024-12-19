using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using CofeRestoranApp.WinForms.Odenisler;
using CofeRestoranApp.WinForms.Urunler;
using DevExpress.XtraEditors;
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
        private OdenisTarixcesiDAL odenisHaraketleriDAl = new OdenisTarixcesiDAL();

        public Frm_Masa_Siparis(int? masaId = null, string masaadi = null, string satiskodu = null)
        {
            InitializeComponent();
            _masaId = masaId;
            _satiskodu = satiskodu;

            try
            {
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
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata oluştu: " + ex.Message, "Hata", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        void hesabla()
        {
            try
            {
                Calc_EndirimToplam.Value = Convert.ToDecimal(colEndirimQiymeti.SummaryItem.SummaryValue);
                Calc_EndirimliToplam.Value = Convert.ToDecimal(ColmnTutar.SummaryItem.SummaryValue);
                CalcOdeden.Value = Convert.ToDecimal(colOdenis.SummaryItem.SummaryValue);
                Calc_Toplam.Value = Calc_EndirimToplam.Value + Calc_EndirimliToplam.Value;
                CalcKalan.Value = Calc_EndirimliToplam.Value - Calc_Toplam.Value;
                /************************************************************************************/
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
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hesablama xətası: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //hesabla();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void OdenisSİlGr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //hesabla();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Btn_Yeni_Sifaris_Click(object sender, EventArgs e)
        {
            try
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
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Yeni sifarişdə xətalar baş verdi: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Çıxışda xəta baş verdi: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void gridViewSiparisler_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //hesabla();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void gridViewSiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                hesabla();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //Güncəlləmə ilə bağlı əməliyyatlar
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Güncəlləmə xətası: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Btn_Kayd_Et_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Saxlama xətası: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Btn_Sonuclandir_Click(object sender, EventArgs e)
        {
            try
            {
                //Əməliyyatları nəticələndirmək
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Nəticələndirmə xətası: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Odenisler_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as SimpleButton;
                Frm_Odeme frm = new Frm_Odeme(btn.Text, _satiskodu);
                frm.ShowDialog();
                if (frm.kayedildi)
                {
                    if (odenisHaraketleriDAl.AddOrUpdate(context, frm.OdemeHaraketleri))
                    {
                        gridViewOdenisler.RefreshData();
                        hesabla();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ödəniş xətası: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void gridViewOdenisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                hesabla();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Brn_Musteri_Resetle_Click(object sender, EventArgs e)
        {
`
        }
    }
}
