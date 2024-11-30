using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeRestoranApp;
using CafeRestoranApp.Entities;
using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class frm_Masalar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalarDal = new MasalarDAL();


        public frm_Masalar()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = masalarDal.MasaListele(context);
        }

        private void frm_Masalar_Load(object sender, EventArgs e)
        {

        }

        private void brn_Elave_Et_Click(object sender, EventArgs e)
        {
            frm_Masa_Qeyd_Et frm = new frm_Masa_Qeyd_Et(new CafeRestoranApp.Entities.Models.Masalar());
            frm.ShowDialog();
            if (frm.Qeydet)
            {
                Listele();
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            int seciliID = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliID); 
            frm_Masa_Qeyd_Et frm = new frm_Masa_Qeyd_Et(masalar);
            frm.ShowDialog();
            if (frm.Qeydet)
            {
                Listele();
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}