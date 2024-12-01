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
using System.IO;
using CafeRestoranApp.Entities.Utilities;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masalar : DevExpress.XtraEditors.XtraForm
    {
        private readonly CafeContext context = new CafeContext();
        private readonly MasalarDAL masalarDal = new MasalarDAL();


        public Frm_Masalar()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = masalarDal.MasaListele(context);
        }

        private void Frm_Masalar_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue("Id") is int seciliId)
                {
                    var seciliMasa = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                    Frm_Masa_Qeyd_Et frm = new Frm_Masa_Qeyd_Et(seciliMasa);
                    frm.ShowDialog();
                    if (frm.Qeydet)
                    {
                        masalarDal.Save(context);
                        Listele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Logger.LogXeta(ex);
            }
            finally
            {
                Listele();
            }
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Logger.LogXeta(ex);
            }
            finally
            {
                Listele();
            }
        }

        private void Btn_Durum_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount > 0)
                {
                    int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    var seciliMasa = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                    if (seciliMasa.Durumu)
                    {
                        seciliMasa.Durumu = false;
                    }
                    else if (!seciliMasa.Durumu)
                    {
                        seciliMasa.Durumu = true;
                    }
                    masalarDal.Save(context);
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Logger.LogXeta(ex);
            }
            finally
            {
                Listele();
            }
        }

        private void Btn_Rezev_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount > 0)
                {
                    int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    var seciliMasa = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                    if (seciliMasa.Rezervasiya)
                    {
                        seciliMasa.Rezervasiya = false;
                    }
                    else if (!seciliMasa.Rezervasiya)
                    {
                        seciliMasa.Rezervasiya = true;
                    }
                    masalarDal.Save(context);
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Logger.LogXeta(ex);
            }
            finally
            {
                Listele();
            }
        }

        private void Btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void brn_Elave_Et_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniMasa = new CafeRestoranApp.Entities.Models.Masalar();
                Frm_Masa_Qeyd_Et frm = new Frm_Masa_Qeyd_Et(yeniMasa);
                frm.ShowDialog();
                if (frm.Qeydet)
                {
                    masalarDal.AddOrUpdate(context, yeniMasa);
                    masalarDal.Save(context);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Logger.LogXeta(ex);
            }

            finally
            {
                Listele();
            }
        }
    }
}