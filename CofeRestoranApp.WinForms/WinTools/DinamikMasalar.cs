using System;
using System.Collections.Generic;
using System.Drawing;
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
        public static void MasaGetir(CafeContext context, FlowLayoutPanel pnl)
        {
            var model = context.Masalar.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Height = 150;
                btn.Width = 125;
                pnl.Controls.Add(btn);
                if (model[i].Rezervasiya && !model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Green;
                }
                else if (model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!model[i].Durumu)
                {
                    btn.Appearance.BackColor = Color.Blue;
                }
                btn.Click += Btn_Click;

            }
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as CheckButton;
            MessageBox.Show($"Masa Adi: {btn.Text} Masa ID: {btn.Name}");

        }
    }
}