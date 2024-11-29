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
using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using DevExpress.Office.Utils;

namespace CofeRestoranApp.WinForms.Urunler
{
    public partial class frm_Urunler : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UrunDAL urunDal = new UrunDAL();
        private BindingSource bindingSource1 = new BindingSource();
        
        public frm_Urunler()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            try
            {
                var urunListesi = urunDal.UrunListele(context);

                if (urunListesi != null && urunListesi.Any()) 
                {
                    bindingSource1.DataSource = urunListesi;  
                    gridControl1.DataSource = bindingSource1; 
                }
                else
                {
                    MessageBox.Show("Bazada məlumat tapılmadı.");  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Məhsul siyahısı yüklənərkən xəta baş verdi: " + ex.Message);
            }
        }

        private void brn_Elave_Et_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Urun_Qeydiyat frm = new frm_Urun_Qeydiyat(new Urun());
                frm.ShowDialog();

                if (frm.Qeydet) 
                {
                    Listele(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Məhsul əlavə edilərkən xəta baş verdi: " + ex.Message);
            }

        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

                if (seciliid > 1) 
                {
                    frm_Urun_Qeydiyat frm = new frm_Urun_Qeydiyat(urunDal.GetByFilter(context, u => u.Id == seciliid));
                    frm.ShowDialog();

                    if (frm.Qeydet)  
                    {
                        Listele();  
                    }
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa redaktə etmək üçün bir məhsul seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Məhsul redaktə edilərkən xəta baş verdi: " + ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}