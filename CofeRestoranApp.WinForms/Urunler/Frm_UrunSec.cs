using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using System;

namespace CofeRestoranApp.WinForms.Urunler
{
    public partial class Frm_UrunSec : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UrunDAL urunDal = new UrunDAL();
        public Urun urunModel;
        public bool secildi;

        public Frm_UrunSec()
        {
            InitializeComponent();
            gridControl1.DataSource = urunDal.GetAll(context);
        }

        private void Btn_Sec_Click(object sender, System.EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int urunId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                urunModel = urunDal.GetByFilter(context, u => u.Id == urunId);
                secildi = true;
                this.Close();
            }
        }
    }
}