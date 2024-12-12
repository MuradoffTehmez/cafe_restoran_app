using CafeRestoranApp.Entities.Models;
using System;

namespace CofeRestoranApp.WinForms.Odenisler
{
    public partial class Frm_Odeme : DevExpress.XtraEditors.XtraForm
    {
        private string _satisKodu;
        private string _odemeTuru;
        public OdenisTarixcesi OdemeHaraketleri;
        public bool kayedildi;

        public Frm_Odeme(string odemeTuru, string satisKodu)
        {
            InitializeComponent();
            _satisKodu = satisKodu;
            _odemeTuru = odemeTuru;

            if (_odemeTuru == "Nagd Satis")
            {
                Lbn_Basliq.Text = "Nagd Satis";
            }
            else if (_odemeTuru == "Kart ile Satis")
            {
                Lbn_Basliq.Text = "Kart ile Satis";
            }
        }
        private void Btn_Onay_Click(object sender, System.EventArgs e)
        {
            OdemeHaraketleri = new OdenisTarixcesi
            {
                SatisKodu = _satisKodu,
                OdemeTuru = _odemeTuru,
                Odenis = Calc_OdenecekTutar.Value,
                Aciklama = txtR_Aciklama.Text,
                Tarix = Convert.ToDateTime(dateTarix.Text)
            };
            kayedildi = true;
            this.Close();
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}