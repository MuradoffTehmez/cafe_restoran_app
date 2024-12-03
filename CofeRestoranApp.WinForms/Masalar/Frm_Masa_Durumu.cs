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
        private CheckButton BtnSender;

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

        public void DurumYenile()
        {
            Btn_Yeni_Sifaris.Enabled= false;
            Btn_Masa_Ac.Enabled= false;
            Btn_Rezev_Et.Enabled= false;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            BtnSender = sender as CheckButton;
            DurumYenile();
            if (BtnSender.Appearance.BackColor==Color.Green)
            {
                Btn_Masa_Ac.Enabled = true;
            } 
            else if (BtnSender.Appearance.BackColor==Color.Red)
            {
                Btn_Masa_Ac.Enabled = true;
                Btn_Rezev_Et.Enabled = true;
            } 
            else if (BtnSender.Appearance.BackColor==Color.Blue)
            {
                Btn_Yeni_Sifaris.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "Xəta: Bu hadisə CheckButton növündə bir obyekt ilə tetiklenmedi.",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}