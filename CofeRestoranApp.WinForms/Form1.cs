using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Mapping;
using CafeRestoranApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms
{
    public partial class Form1 : Form
    {
        CafeContext Context = new CafeContext();    
        IstifadeciHereketleriDAL IstifadeciHereketleriDal = new IstifadeciHereketleriDAL();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
