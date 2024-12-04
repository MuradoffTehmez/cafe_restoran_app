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

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Rezervasiya : DevExpress.XtraEditors.XtraForm
    {
        private int _masaId;
        public bool islemyapildi;
        private CafeRestoranApp.Entities.Models.Masalar masalar;
        private MasalarDAL masalarDal = new MasalarDAL();
        CafeContext context = new CafeContext();

        public Frm_Masa_Rezervasiya(int masaId)
        {
            InitializeComponent();
            _masaId = masaId;
        }

        private void Btn_Tesdiqle_Click(object sender, EventArgs e)
        {
            masalar = masalarDal.GetByFilter(context,m=>m.Id==_masaId);
            masalar.Islem = txtR_Proses.Text;
            masalar.SonIslemTarixi = Convert.ToDateTime(dateTarix.EditValue);
        }
    }
}