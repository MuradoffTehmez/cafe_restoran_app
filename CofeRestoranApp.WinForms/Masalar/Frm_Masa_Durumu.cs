﻿using CafeRestoranApp.Entities.DAL;
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
        private CheckButton BtnSender = new CheckButton();
        private SatisKodu modelSatisKodu = new SatisKodu();
        private string _SatisKodu;
        private int _masaId;
        private CafeRestoranApp.Entities.Models.Masalar masalar = new CafeRestoranApp.Entities.Models.Masalar();
        MasalarDAL masalarDal = new MasalarDAL();

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
            try
            {
                flowLayoutPanel1.Controls.Clear();
                var model = context.Masalar.ToList();
                context = new CafeContext();
                for (int i = 0; i < model.Count; i++)
                {
                    var btn = new CheckButton();
                    btn.Text = model[i].MasaAdi;
                    btn.Name = model[i].Id.ToString();
                    btn.Height = 150;
                    btn.Width = 125;
                    btn.Tag = model[i].SatisKodu;
                    flowLayoutPanel1.Controls.Add(btn);
                    if (model[i].Rezervasiya && !model[i].Durumu)
                    {
                        btn.Appearance.BackColor = Color.Yellow;
                    }
                    else if (model[i].Durumu)
                    {
                        btn.Appearance.BackColor = Color.Red;
                    }
                    else if (!model[i].Durumu)
                    {
                        btn.Appearance.BackColor = Color.Green;
                    }
                    btn.Click -= Btn_Click;
                    btn.Click += Btn_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DurumYenile()
        {
            try
            {
                Btn_Yeni_Sifaris.Enabled = false;
                Btn_Masa_Ac.Enabled = false;
                Btn_Rezev_Et.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                BtnSender = sender as CheckButton;
                _masaId = Convert.ToInt32(BtnSender.Name);
                _SatisKodu = BtnSender.Tag?.ToString();
                DurumYenile();
                if (BtnSender.Appearance.BackColor == Color.Yellow)
                {
                    Btn_Masa_Ac.Enabled = true;
                }
                else if (BtnSender.Appearance.BackColor == Color.Green)
                {
                    Btn_Masa_Ac.Enabled = true;
                    Btn_Rezev_Et.Enabled = true;
                }
                else if (BtnSender.Appearance.BackColor == Color.Red)
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
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Yeni_Sifaris_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Masa_Siparis frm = new Frm_Masa_Siparis(masaId: _masaId, masaadi: BtnSender.Text, satiskodu: _SatisKodu);
                frm.ShowDialog();
                BtnSender = null;
                DurumYenile();
                MasaGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Masa_Ac_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(BtnSender.Text + "  Acilsin ?", "Melumat", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
                    masalar.SatisKodu = modelSatisKodu.SatisTanimi + modelSatisKodu.Sayi;
                    masalar.Durumu = true;
                    modelSatisKodu.Sayi++;
                    masalarDal.Save(context);
                    BtnSender = null;
                    DurumYenile();
                    MasaGetir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Rezev_Et_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Masa_Rezervasiya frm = new Frm_Masa_Rezervasiya(_masaId);
                frm.ShowDialog();
                DurumYenile();
                if (frm.islemyapildi)
                {
                    MasaGetir();
                }
                BtnSender = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
