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
            try
            {
                var yeniMasa = new CafeRestoranApp.Entities.Models.Masalar();
                frm_Masa_Qeyd_Et frm = new frm_Masa_Qeyd_Et(yeniMasa);
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
                string logDirectory = @"C:\Users\murad\LogFiles";
                string logFilePath = Path.Combine(logDirectory, "error_log.txt");
                try
                {
                    // Qovluq mövcud deyilsə, yarat
                    if (!Directory.Exists(logDirectory))
                    {
                        Directory.CreateDirectory(logDirectory);
                    }

                    string logMesaj = $"Tarix: {DateTime.Now}\nXəta mesajı: {ex.Message}\nSətir məlumatı:\n{ex.StackTrace}\n\n";
                    File.AppendAllText(logFilePath, logMesaj);
                }
                catch (Exception logEx)
                {
                    MessageBox.Show($"Xətanı log faylına yazarkən problem baş verdi:\n{logEx.Message}", "Log Xətası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            finally
            {
                Listele();
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string logDirectory = @"C:\Users\murad\LogFiles";
                string logFilePath = Path.Combine(logDirectory, "error_log.txt");
                try
                {
                    // Qovluq mövcud deyilsə, yarat
                    if (!Directory.Exists(logDirectory))
                    {
                        Directory.CreateDirectory(logDirectory);
                    }

                    string logMesaj = $"Tarix: {DateTime.Now}\nXəta mesajı: {ex.Message}\nSətir məlumatı:\n{ex.StackTrace}\n\n";
                    File.AppendAllText(logFilePath, logMesaj);
                }
                catch (Exception logEx)
                {
                    MessageBox.Show($"Xətanı log faylına yazarkən problem baş verdi:\n{logEx.Message}", "Log Xətası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Listele();
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
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string logDirectory = @"C:\Users\murad\LogFiles";
                string logFilePath = Path.Combine(logDirectory, "error_log.txt");
                try
                {
                    // Qovluq mövcud deyilsə, yarat
                    if (!Directory.Exists(logDirectory))
                    {
                        Directory.CreateDirectory(logDirectory);
                    }

                    string logMesaj = $"Tarix: {DateTime.Now}\nXəta mesajı: {ex.Message}\nSətir məlumatı:\n{ex.StackTrace}\n\n";
                    File.AppendAllText(logFilePath, logMesaj);
                }
                catch (Exception logEx)
                {
                    MessageBox.Show($"Xətanı log faylına yazarkən problem baş verdi:\n{logEx.Message}", "Log Xətası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Listele();
            }
        }

        private void btn_Durum_Click(object sender, EventArgs e)
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
                string logDirectory = @"C:\Users\murad\LogFiles";
                string logFilePath = Path.Combine(logDirectory, "error_log.txt");
                try
                {
                    // Qovluq mövcud deyilsə, yarat
                    if (!Directory.Exists(logDirectory))
                    {
                        Directory.CreateDirectory(logDirectory);
                    }

                    string logMesaj = $"Tarix: {DateTime.Now}\nXəta mesajı: {ex.Message}\nSətir məlumatı:\n{ex.StackTrace}\n\n";
                    File.AppendAllText(logFilePath, logMesaj);
                }
                catch (Exception logEx)
                {
                    MessageBox.Show($"Xətanı log faylına yazarkən problem baş verdi:\n{logEx.Message}", "Log Xətası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Listele();
            }
        }

        private void btn_Rezev_Click(object sender, EventArgs e)
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
                string logDirectory = @"C:\Users\murad\LogFiles";
                string logFilePath = Path.Combine(logDirectory, "error_log.txt");
                try
                {
                    // Qovluq mövcud deyilsə, yarat
                    if (!Directory.Exists(logDirectory))
                    {
                        Directory.CreateDirectory(logDirectory);
                    }

                    string logMesaj = $"Tarix: {DateTime.Now}\nXəta mesajı: {ex.Message}\nSətir məlumatı:\n{ex.StackTrace}\n\n";
                    File.AppendAllText(logFilePath, logMesaj);
                }
                catch (Exception logEx)
                {
                    MessageBox.Show($"Xətanı log faylına yazarkən problem baş verdi:\n{logEx.Message}", "Log Xətası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                Listele();
            }
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}