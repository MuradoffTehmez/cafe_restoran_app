using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Mapping;
using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities;
using DurableTask.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = CafeRestoranApp.Entities.Models.Menu;
using System.Runtime.Remoting.Contexts;

namespace CofeRestoranApp.WinForms
{
    
    public partial class Form1 : Form
    {
        CafeContext Context = new CafeContext();
        MenuDAL MenuDAL = new MenuDAL();

        CafeRestoranApp.Entities.Models.Menu Entity;
        public Form1()
        {
            InitializeComponent();
            Entity = new CafeRestoranApp.Entities.Models.Menu();
            Txt_Meynu_Adi.DataBindings.Add("Text",Entity, "MenuAdi");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Meynu_Adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Meynu_Click(object sender, EventArgs e)
        {
            if (MenuDAL.AddOrUpdate(Context, Entity))
            {
                MenuDAL.Save(Context);

            }
        }
    }
}
