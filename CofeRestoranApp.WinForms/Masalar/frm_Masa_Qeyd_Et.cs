using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using DurableTask.Core.Common;
using CafeRestoranApp;
using System.IO;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class frm_Masa_Qeyd_Et : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalarDal = new MasalarDAL();
        private CafeRestoranApp.Entities.Models.Masalar _entity;
        public bool Qeydet { get; private set; }

        public frm_Masa_Qeyd_Et(CafeRestoranApp.Entities.Models.Masalar entity) 
        {
            InitializeComponent();
            _entity = entity;
            txt_Urun_Adi.DataBindings.Add("Text", _entity, "MasaAdi");
            txtR_Aciklama.DataBindings.Add("Text", _entity, "Aciklama");

        }
        private void frm_Masa_Qeyd_Et_Load(object sender, EventArgs e)
        {

        }

        private void brn_Qeyd_Er_Click(object sender, EventArgs e)
        {
            try
            {
                if (_entity.Id == 0) 
                {
                    _entity.Durumu = false;
                    _entity.Rezervasiya = false;
                    _entity.ElaveOlmaTarixi = DateTime.Now;
                    _entity.SonIslemTarixi = DateTime.Now;
                    _entity.Islem = "Yeni masa əlavə edildi";
                }
                else if (_entity.Id != 0) 
                {
                    _entity.SonIslemTarixi = DateTime.Now;
                    _entity.Islem = "Masa yeniləndi";
                }

                if (masalarDal.AddOrUpdate(context, _entity))
                {
                    masalarDal.Save(context);
                    Qeydet = true;
                    this.Close();
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


        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            Qeydet = false;
            this.Close();
        }

        /*
           _entity.Durumu = false;
           _entity.Rezervasiya = false;
           _entity.ElaveOlmaTarixi = DateTime.Now;
           _entity.SonIslemTarixi = DateTime.Now;
           _entity.Islem = "Yeni masa elave edildi";

            if (_entity.Id == 0) // Yeni kayıt
           {

               masalarDal.AddOrUpdate(context, _entity);
           }
           else // Güncelleme
           {
               masalarDal.Update(context, _entity);
           }

           masalarDal.AddOrUpdate(context, _entity);
           Qeydet = true;
           this.Close();         
         
         */
    }
}