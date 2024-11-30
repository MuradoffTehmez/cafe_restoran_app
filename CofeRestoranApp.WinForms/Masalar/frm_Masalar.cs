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
using CafeRestoranApp.Entities.Mapping;

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

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                object focusedRow = gridView1.GetFocusedRowCellValue(colId);
                if (focusedRow == null)
                {
                    MessageBox.Show("Zəhmət olmasa silmək üçün bir məhsul seçin.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int seciliid = Convert.ToInt32(focusedRow);

                if (MessageBox.Show("Məlumat bazadan silinəcək! Razısınız?", "Diqqət!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    masalarDal.Delete(context, m => m.Id == seciliid);
                    masalarDal.Save(context);
                    Listele();
                    MessageBox.Show("Məhsul uğurla silindi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Məhsul silinərkən xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}