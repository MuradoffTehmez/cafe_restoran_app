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
                        this.Hide();
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
                    urunDal.Delete(context, u => u.Id == seciliid);
                    urunDal.Save(context);
                    Listele();
                    MessageBox.Show("Məhsul uğurla silindi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Məhsul silinərkən xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tətbiqdən çıxmaq istəyirsiniz?", "Təsdiq", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                this.Hide();
            }
        }

        private void frm_Urunler_Load(object sender, EventArgs e)
        {
           
        }
    }
}