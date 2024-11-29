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
    public partial class frm_Urunler : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context1 = new CafeContext();
        private UrunDAL urunDal1 = new UrunDAL();
        private BindingSource bindingSource1 = new BindingSource();
        public frm_Urunler()
        {
            InitializeComponent();
            bindingSource1.DataSource = urunDal1.GetAll(context1);
            gridControl1.DataSource = bindingSource1;
        }

        private void brn_Elave_Et_Click(object sender, EventArgs e)
        {

        }
    }
}