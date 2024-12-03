using CafeRestoranApp.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Durumu : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();

        public Frm_Masa_Durumu()
        {
            InitializeComponent();
            MasaGetir();
        }
        private void Frm_Masa_Durumu_Load(object sender, EventArgs e)
        {

        }
        public void MasaGetir()
        {
            var model = context.Masalar.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].MasaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Height = 150;
                btn.Width = 125;
                flowLayoutPanel1.Controls.Add(btn);
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

        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as CheckButton;
            MessageBox.Show($"Masa Adi: {btn.Text} Masa ID: {btn.Name}");

        }
    }
}