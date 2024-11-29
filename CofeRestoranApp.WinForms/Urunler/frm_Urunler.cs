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
        private CafeContext context = new CafeContext();
        private UrunDAL urunDal = new UrunDAL();
        private BindingSource bindingSource1 = new BindingSource();


        // private UrunDAL urunDal = new UrunDAL();
        public frm_Urunler()
        {
            InitializeComponent();
            gridControl1.DataSource = urunDal.UrunListele(context);
            /*
            var urunListesi = urunDal.UrunListele(context);

            if (urunListesi != null && urunListesi.Count > 0)
            {
                bindingSource1.DataSource = urunListesi;
                gridControl1.DataSource = bindingSource1;
            }
            else
            {
                MessageBox.Show("Bazada melumat yoxdu");
            }
              */

            //    bindingSource1.DataSource = urunDal.GetAll(context);
            //    gridControl1.DataSource = bindingSource1;
        }

        private void brn_Elave_Et_Click(object sender, EventArgs e)
        {

        }
    }
}