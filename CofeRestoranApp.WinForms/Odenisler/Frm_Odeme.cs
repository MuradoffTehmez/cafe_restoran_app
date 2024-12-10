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

            if (_odemeTuru=="Nakit")
            {
                Lbn_Basliq.Text = "Nakit Odeme";
            }
            else if (_odemeTuru == "Keredi Karti")
            {
                Lbn_Basliq.Text = "Kredi karti ile Odeme";
            }
        }
    }
}