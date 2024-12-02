using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using System;
using System.Windows.Forms;

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
            Txt_Meynu_Adi.DataBindings.Add("Text", Entity, "MenuAdi");
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
