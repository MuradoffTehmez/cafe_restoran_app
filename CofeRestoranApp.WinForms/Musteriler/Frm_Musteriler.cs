using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Utilities;
using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Musteriler
{
    public partial class Frm_Musteriler : DevExpress.XtraEditors.XtraForm
    {
        private readonly CafeContext context = new CafeContext();
        private readonly CafeContext _context;
        public Frm_Musteriler()
        {
            InitializeComponent();
            _context = context;
            _context.Musteriler.Load();
            gridControl1.DataSource = _context.Musteriler.Local.ToBindingList();
        }

        private void brn_Elave_et_Click(object sender, EventArgs e)
        {
            SaveSelectedItem();
            _context.SaveChanges();
            gridView1.RefreshData();
        }
        private void SaveSelectedItem()
        {
            if (ShowConfirmation("Seçili olan qeyd olunsun?", "Diqqət") == DialogResult.Yes)
            {
                _context.SaveChanges();
                gridView1.RefreshData();
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }
        private void DeleteSelectedItem()
        {
            if (ShowConfirmation("Seçili olan silinsin?", "Diqqət") == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                SaveChanges();
                gridView1.RefreshData();
            }
        }
        private void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                gridView1.RefreshData();
                XtraMessageBox.Show("Əməliyyat uğurla tamamlandı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException?.InnerException?.Message;
                MessageBox.Show($"Veritabanı güncelleme hatası:\n{innerException}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogXeta(dbEx);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogXeta(ex);
            }
        }

        private DialogResult ShowConfirmation(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}