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
        }
    }
}