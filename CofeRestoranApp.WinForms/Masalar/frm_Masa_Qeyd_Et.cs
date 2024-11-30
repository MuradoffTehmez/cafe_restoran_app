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

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class frm_Masa_Qeyd_Et : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalarDal = new MasalarDAL();
        private CafeRestoranApp.Entities.Models.Masalar _entity;
        public bool Qeydet = false;

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
            if (masalarDal.AddorUpdate(context,_entity))
            {
                masalarDal.Save(context);
                Qeydet = true;
                this.Hide();
            }
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}