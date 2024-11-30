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
            var yeniMasa = new CafeRestoranApp.Entities.Models.Masalar();
            frm_Masa_Qeyd_Et frm = new frm_Masa_Qeyd_Et(yeniMasa);
            frm.ShowDialog();
            if (frm.Qeydet)
            {
                masalarDal.AddOrUpdate(context, yeniMasa);
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Id") is int seciliId)
            {
                var seciliMasa = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                frm_Masa_Qeyd_Et frm = new frm_Masa_Qeyd_Et(seciliMasa);
                frm.ShowDialog();
                if (frm.Qeydet)
                {
                    masalarDal.Save(context);
                    Listele();
                }
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}