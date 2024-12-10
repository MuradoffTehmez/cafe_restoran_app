namespace CofeRestoranApp.WinForms.Odenisler
{
    public partial class Frm_Odeme : DevExpress.XtraEditors.XtraForm
    {
        private string _satisKodu;
        private string _odemeTuru;

        public Frm_Odeme(string odemeTuru,string satisKodu)
        {
            InitializeComponent();
            _satisKodu = satisKodu;
            _odemeTuru = odemeTuru;

            if (_odemeTuru== "Nagd Satis")
            {
                Lbn_Basliq.Text = "Nagd Satis";
            }
            else if (_odemeTuru == "Kart ile Satis")
            {
                Lbn_Basliq.Text = "Kart ile Satis";
            }
        }
    }
}