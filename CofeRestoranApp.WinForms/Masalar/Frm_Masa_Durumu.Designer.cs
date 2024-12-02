namespace CofeRestoranApp.WinForms.Masalar
{
    partial class Frm_Masa_Durumu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Masa_Durumu));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Group_Emeliyyatlar = new DevExpress.XtraEditors.GroupControl();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Duzenle = new DevExpress.XtraEditors.SimpleButton();
            this.brn_Elave_Et = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Rezev = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Durum = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cisix_et = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Group_Hesablamalar = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).BeginInit();
            this.Group_Emeliyyatlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Hesablamalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1596, 43);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Masalar";
            // 
            // Group_Emeliyyatlar
            // 
            this.Group_Emeliyyatlar.Controls.Add(this.btn_Guncelle);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_Duzenle);
            this.Group_Emeliyyatlar.Controls.Add(this.brn_Elave_Et);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_Rezev);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_Durum);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_cisix_et);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_Sil);
            this.Group_Emeliyyatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Emeliyyatlar.Location = new System.Drawing.Point(0, 719);
            this.Group_Emeliyyatlar.Name = "Group_Emeliyyatlar";
            this.Group_Emeliyyatlar.Size = new System.Drawing.Size(1596, 111);
            this.Group_Emeliyyatlar.TabIndex = 4;
            this.Group_Emeliyyatlar.Text = "Əməliyyatlar";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guncelle.Appearance.Options.UseFont = true;
            this.btn_Guncelle.Appearance.Options.UseTextOptions = true;
            this.btn_Guncelle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Guncelle.ImageOptions.SvgImage")));
            this.btn_Guncelle.Location = new System.Drawing.Point(372, 34);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(174, 60);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncəllə";
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Duzenle.Appearance.Options.UseFont = true;
            this.btn_Duzenle.Appearance.Options.UseTextOptions = true;
            this.btn_Duzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Duzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Duzenle.ImageOptions.SvgImage")));
            this.btn_Duzenle.Location = new System.Drawing.Point(192, 34);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(174, 60);
            this.btn_Duzenle.TabIndex = 2;
            this.btn_Duzenle.Text = "Dəyişdir";
            // 
            // brn_Elave_Et
            // 
            this.brn_Elave_Et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Elave_Et.Appearance.Options.UseFont = true;
            this.brn_Elave_Et.Appearance.Options.UseTextOptions = true;
            this.brn_Elave_Et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.brn_Elave_Et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brn_Elave_Et.ImageOptions.SvgImage")));
            this.brn_Elave_Et.Location = new System.Drawing.Point(12, 34);
            this.brn_Elave_Et.Name = "brn_Elave_Et";
            this.brn_Elave_Et.Size = new System.Drawing.Size(174, 60);
            this.brn_Elave_Et.TabIndex = 0;
            this.brn_Elave_Et.Text = "Əlavə et";
            // 
            // btn_Rezev
            // 
            this.btn_Rezev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rezev.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rezev.Appearance.Options.UseFont = true;
            this.btn_Rezev.Appearance.Options.UseTextOptions = true;
            this.btn_Rezev.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Rezev.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Rezev.ImageOptions.SvgImage")));
            this.btn_Rezev.Location = new System.Drawing.Point(1197, 34);
            this.btn_Rezev.Name = "btn_Rezev";
            this.btn_Rezev.Size = new System.Drawing.Size(125, 60);
            this.btn_Rezev.TabIndex = 6;
            this.btn_Rezev.Text = "Rezervasiya\r\nEt";
            // 
            // btn_Durum
            // 
            this.btn_Durum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Durum.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Durum.Appearance.Options.UseFont = true;
            this.btn_Durum.Appearance.Options.UseTextOptions = true;
            this.btn_Durum.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Durum.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Durum.ImageOptions.SvgImage")));
            this.btn_Durum.Location = new System.Drawing.Point(1066, 34);
            this.btn_Durum.Name = "btn_Durum";
            this.btn_Durum.Size = new System.Drawing.Size(125, 60);
            this.btn_Durum.TabIndex = 5;
            this.btn_Durum.Text = "Durum\r\nDəyişdir\r\n";
            // 
            // btn_cisix_et
            // 
            this.btn_cisix_et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cisix_et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cisix_et.Appearance.Options.UseFont = true;
            this.btn_cisix_et.Appearance.Options.UseTextOptions = true;
            this.btn_cisix_et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_cisix_et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cisix_et.ImageOptions.SvgImage")));
            this.btn_cisix_et.Location = new System.Drawing.Point(1459, 34);
            this.btn_cisix_et.Name = "btn_cisix_et";
            this.btn_cisix_et.Size = new System.Drawing.Size(125, 60);
            this.btn_cisix_et.TabIndex = 3;
            this.btn_cisix_et.Text = "Çıxış";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.Appearance.Options.UseFont = true;
            this.btn_Sil.Appearance.Options.UseTextOptions = true;
            this.btn_Sil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sil.ImageOptions.SvgImage")));
            this.btn_Sil.Location = new System.Drawing.Point(1328, 34);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(125, 60);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "Sil";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 43);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.Group_Hesablamalar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1596, 676);
            this.splitContainerControl1.SplitterPosition = 272;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1596, 272);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Group_Hesablamalar
            // 
            this.Group_Hesablamalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Hesablamalar.Location = new System.Drawing.Point(0, 270);
            this.Group_Hesablamalar.Name = "Group_Hesablamalar";
            this.Group_Hesablamalar.Size = new System.Drawing.Size(1596, 124);
            this.Group_Hesablamalar.TabIndex = 0;
            this.Group_Hesablamalar.Text = "Hesablamalar";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1596, 270);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Frm_Masa_Durumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 830);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.Group_Emeliyyatlar);
            this.Controls.Add(this.labelControl1);
            this.Name = "Frm_Masa_Durumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Masa_Durumu";
            this.Load += new System.EventHandler(this.Frm_Masa_Durumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).EndInit();
            this.Group_Emeliyyatlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Hesablamalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl Group_Emeliyyatlar;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Duzenle;
        private DevExpress.XtraEditors.SimpleButton brn_Elave_Et;
        private DevExpress.XtraEditors.SimpleButton btn_Rezev;
        private DevExpress.XtraEditors.SimpleButton btn_Durum;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl Group_Hesablamalar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}