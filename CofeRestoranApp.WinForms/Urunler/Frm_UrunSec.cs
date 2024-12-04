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

namespace CofeRestoranApp.WinForms.Urunler
{
    public partial class Frm_UrunSec : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UrunDAL urunDal = new UrunDAL();
        public Frm_UrunSec()
        {
            InitializeComponent();
            gridControl1.DataSource = urunDal.GetAll(context);
        }
    }
}