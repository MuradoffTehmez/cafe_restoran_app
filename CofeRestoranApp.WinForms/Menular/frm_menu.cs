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

namespace CofeRestoranApp.WinForms.Menular
{
    public partial class frm_Menu : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private readonly CafeContext _context;
        public frm_Menu()
        {
            InitializeComponent();
            _context = context;
            _context.Menu.Load();
            gridControl1.DataSource = _context.Menu.Local.ToBindingList();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
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
                string logDirectory = @"C:\Users\murad\LogFiles";
                string logFilePath = Path.Combine(logDirectory, "error_log.txt");
                try
                {
                    
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
        }

        private DialogResult ShowConfirmation(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveSelectedItem();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }

        private void btn_Deyis_Click(object sender, EventArgs e)
        {

        }
    }
}