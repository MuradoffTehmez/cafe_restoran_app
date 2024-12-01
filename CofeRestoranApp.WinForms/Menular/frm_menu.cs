using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeRestoranApp.Entities.Models;
using System.Runtime.Remoting.Contexts;
using System.IO;
using CafeRestoranApp.Entities.Utilities;

namespace CofeRestoranApp.WinForms.Menular
{
    public partial class Frm_Menu : DevExpress.XtraEditors.XtraForm
    {
        private readonly CafeContext context = new CafeContext();
        private readonly CafeContext _context;
        public Frm_Menu()
        {
            InitializeComponent();
            _context = context;
            _context.Menu.Load();
            gridControl1.DataSource = _context.Menu.Local.ToBindingList();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void SaveSelectedItem()
        {
            if (ShowConfirmation("Seçili olan qeyd olunsun?", "Diqqət") == DialogResult.Yes)
            {
                SaveChanges();
            }
        }

        private void DeleteSelectedItem()
        {
            if (ShowConfirmation("Seçili olan silinsin?", "Diqqət") == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                SaveChanges();
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
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Logger.LogXeta(ex);
            }
        }

        private DialogResult ShowConfirmation(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            SaveSelectedItem();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void SimpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }

        private void Btn_Deyis_Click(object sender, EventArgs e)
        {

        }
    }
}