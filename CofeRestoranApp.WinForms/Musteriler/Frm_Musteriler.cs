using CafeRestoranApp.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeRestoranApp.Entities.Utilities;

namespace CofeRestoranApp.WinForms.Musteriler
{
    public partial class Frm_Musteriler : DevExpress.XtraEditors.XtraForm
    {
        private readonly CafeContext context = new CafeContext();
        public Frm_Musteriler()
        {
            InitializeComponent();
            context.Musteriler.Load();
            gridControl1.DataSource = context.Musteriler.Local.ToBindingList();
        }

        private void brn_Elave_et_Click(object sender, EventArgs e)
        {
            SaveSelectedItem();
            context.SaveChanges();
            gridView1.RefreshData();
        }
        private void SaveSelectedItem()
        {
            if (ShowConfirmation("Seçili olan qeyd olunsun?", "Diqqət") == DialogResult.Yes)
            {
                context.SaveChanges();
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
                context.SaveChanges();
                gridView1.RefreshData();
                XtraMessageBox.Show("Əməliyyat uğurla tamamlandı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
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