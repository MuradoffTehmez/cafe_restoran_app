using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Urunler
{
    public partial class frm_Urun_Qeydiyat : DevExpress.XtraEditors.XtraForm
    {
        private MenuDAL MenuDAL = new MenuDAL();
        private CafeContext Context = new CafeContext();

        public frm_Urun_Qeydiyat()
        {
            InitializeComponent();
            Combo_Meynu_Secimi.Properties.DataSource = MenuDAL.GetAll(Context);
        }

        private void frm_Urun_Qeydiyat_Load(object sender, EventArgs e)
        {

        }

        private void brn_Mehsul_Elave_Et_Click(object sender, EventArgs e)
        {

        }
    }
}