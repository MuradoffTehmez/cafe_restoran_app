﻿using DevExpress.XtraEditors;
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
    public partial class frm_Masalar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDAL masalarDal = new MasalarDAL();


        public frm_Masalar()
        {
            InitializeComponent();
            gridControl1.DataSource = masalarDal.MasaListele(context);
        }

        private void frm_Masalar_Load(object sender, EventArgs e)
        {

        }

        private void brn_Elave_Et_Click(object sender, EventArgs e)
        {

        }
    }
}