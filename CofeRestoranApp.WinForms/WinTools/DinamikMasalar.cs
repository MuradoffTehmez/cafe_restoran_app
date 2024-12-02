using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeRestoranApp.Entities.Models;
using DevExpress.XtraBars.Customization.Helpers;

namespace CofeRestoranApp.WinForms.WinTools
{
    public class DinamikMasalar
    {
        public void MasaGetir(CafeContext context,FlowLayoutPanel pnl)
        {
            var model = context.Masalar.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Text = model[i].Id.ToString();
                btn.Height = 100;

            }
        }
    }
}
