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
            this.Btn_Yeni_Sifaris = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cisix_et = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kayd_Et = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Rezervli_Masa = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Bos_Masa = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Dolu_Masa = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiqdari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQiymeti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Group_Hesablamalar = new DevExpress.XtraEditors.GroupControl();
            this.Calc_Odeden = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Calc_Qalan = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Calc_Endirim_Toplam = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Calc_Endirim = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Calc_Umumi_Qiymet = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Calc_Endirimli_Qiymet = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).BeginInit();
            this.Group_Emeliyyatlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Hesablamalar)).BeginInit();
            this.Group_Hesablamalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Odeden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Qalan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Endirim_Toplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Endirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Umumi_Qiymet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Endirimli_Qiymet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1596, 43);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Masalar Haqqinda Melumat";
            // 
            // Group_Emeliyyatlar
            // 
            this.Group_Emeliyyatlar.Controls.Add(this.btn_Guncelle);
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Yeni_Sifaris);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_cisix_et);
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Kayd_Et);
            this.Group_Emeliyyatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Emeliyyatlar.Location = new System.Drawing.Point(0, 749);
            this.Group_Emeliyyatlar.Name = "Group_Emeliyyatlar";
            this.Group_Emeliyyatlar.Size = new System.Drawing.Size(1596, 81);
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
            this.btn_Guncelle.Location = new System.Drawing.Point(144, 26);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(125, 46);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncəllə";
            // 
            // Btn_Yeni_Sifaris
            // 
            this.Btn_Yeni_Sifaris.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Yeni_Sifaris.Appearance.Options.UseFont = true;
            this.Btn_Yeni_Sifaris.Appearance.Options.UseTextOptions = true;
            this.Btn_Yeni_Sifaris.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Yeni_Sifaris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Yeni_Sifaris.ImageOptions.SvgImage")));
            this.Btn_Yeni_Sifaris.Location = new System.Drawing.Point(13, 26);
            this.Btn_Yeni_Sifaris.Name = "Btn_Yeni_Sifaris";
            this.Btn_Yeni_Sifaris.Size = new System.Drawing.Size(125, 46);
            this.Btn_Yeni_Sifaris.TabIndex = 0;
            this.Btn_Yeni_Sifaris.Text = "Sifaris \r\nelave et";
            // 
            // btn_cisix_et
            // 
            this.btn_cisix_et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cisix_et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cisix_et.Appearance.Options.UseFont = true;
            this.btn_cisix_et.Appearance.Options.UseTextOptions = true;
            this.btn_cisix_et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_cisix_et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cisix_et.ImageOptions.SvgImage")));
            this.btn_cisix_et.Location = new System.Drawing.Point(1467, 26);
            this.btn_cisix_et.Name = "btn_cisix_et";
            this.btn_cisix_et.Size = new System.Drawing.Size(125, 46);
            this.btn_cisix_et.TabIndex = 3;
            this.btn_cisix_et.Text = "Çıxış";
            // 
            // Btn_Kayd_Et
            // 
            this.Btn_Kayd_Et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Kayd_Et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Kayd_Et.Appearance.Options.UseFont = true;
            this.Btn_Kayd_Et.Appearance.Options.UseTextOptions = true;
            this.Btn_Kayd_Et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Kayd_Et.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kayd_Et.ImageOptions.Image")));
            this.Btn_Kayd_Et.Location = new System.Drawing.Point(1336, 26);
            this.Btn_Kayd_Et.Name = "Btn_Kayd_Et";
            this.Btn_Kayd_Et.Size = new System.Drawing.Size(125, 46);
            this.Btn_Kayd_Et.TabIndex = 1;
            this.Btn_Kayd_Et.Text = "Qeyd et";
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
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.Group_Hesablamalar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1596, 706);
            this.splitContainerControl1.SplitterPosition = 319;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1596, 271);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Btn_Rezervli_Masa);
            this.panelControl1.Controls.Add(this.Btn_Bos_Masa);
            this.panelControl1.Controls.Add(this.Btn_Dolu_Masa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 271);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1596, 48);
            this.panelControl1.TabIndex = 1;
            // 
            // Btn_Rezervli_Masa
            // 
            this.Btn_Rezervli_Masa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.Btn_Rezervli_Masa.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Btn_Rezervli_Masa.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rezervli_Masa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_Rezervli_Masa.Appearance.Options.UseBackColor = true;
            this.Btn_Rezervli_Masa.Appearance.Options.UseBorderColor = true;
            this.Btn_Rezervli_Masa.Appearance.Options.UseFont = true;
            this.Btn_Rezervli_Masa.Appearance.Options.UseForeColor = true;
            this.Btn_Rezervli_Masa.Location = new System.Drawing.Point(384, 5);
            this.Btn_Rezervli_Masa.Name = "Btn_Rezervli_Masa";
            this.Btn_Rezervli_Masa.Size = new System.Drawing.Size(180, 37);
            this.Btn_Rezervli_Masa.TabIndex = 2;
            this.Btn_Rezervli_Masa.Text = "Rezervasiya";
            // 
            // Btn_Bos_Masa
            // 
            this.Btn_Bos_Masa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.Btn_Bos_Masa.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Btn_Bos_Masa.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Bos_Masa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_Bos_Masa.Appearance.Options.UseBackColor = true;
            this.Btn_Bos_Masa.Appearance.Options.UseBorderColor = true;
            this.Btn_Bos_Masa.Appearance.Options.UseFont = true;
            this.Btn_Bos_Masa.Appearance.Options.UseForeColor = true;
            this.Btn_Bos_Masa.Location = new System.Drawing.Point(198, 5);
            this.Btn_Bos_Masa.Name = "Btn_Bos_Masa";
            this.Btn_Bos_Masa.Size = new System.Drawing.Size(180, 37);
            this.Btn_Bos_Masa.TabIndex = 1;
            this.Btn_Bos_Masa.Text = "Bos Masa";
            // 
            // Btn_Dolu_Masa
            // 
            this.Btn_Dolu_Masa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.Btn_Dolu_Masa.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Btn_Dolu_Masa.Appearance.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dolu_Masa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_Dolu_Masa.Appearance.Options.UseBackColor = true;
            this.Btn_Dolu_Masa.Appearance.Options.UseBorderColor = true;
            this.Btn_Dolu_Masa.Appearance.Options.UseFont = true;
            this.Btn_Dolu_Masa.Appearance.Options.UseForeColor = true;
            this.Btn_Dolu_Masa.Location = new System.Drawing.Point(12, 6);
            this.Btn_Dolu_Masa.Name = "Btn_Dolu_Masa";
            this.Btn_Dolu_Masa.Size = new System.Drawing.Size(180, 37);
            this.Btn_Dolu_Masa.TabIndex = 0;
            this.Btn_Dolu_Masa.Text = "Dolu Masa";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1596, 274);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.colMasaId,
            this.colMenuId,
            this.colUrunId,
            this.colMiqdari,
            this.colQiymeti,
            this.colAciklama,
            this.colTarix,
            this.colMasalar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            // 
            // colMasaId
            // 
            this.colMasaId.FieldName = "MasaId";
            this.colMasaId.Name = "colMasaId";
            this.colMasaId.Visible = true;
            this.colMasaId.VisibleIndex = 2;
            // 
            // colMenuId
            // 
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.Name = "colMenuId";
            this.colMenuId.Visible = true;
            this.colMenuId.VisibleIndex = 3;
            // 
            // colUrunId
            // 
            this.colUrunId.FieldName = "UrunId";
            this.colUrunId.Name = "colUrunId";
            this.colUrunId.Visible = true;
            this.colUrunId.VisibleIndex = 4;
            // 
            // colMiqdari
            // 
            this.colMiqdari.FieldName = "Miqdari";
            this.colMiqdari.Name = "colMiqdari";
            this.colMiqdari.Visible = true;
            this.colMiqdari.VisibleIndex = 5;
            // 
            // colQiymeti
            // 
            this.colQiymeti.FieldName = "Qiymeti";
            this.colQiymeti.Name = "colQiymeti";
            this.colQiymeti.Visible = true;
            this.colQiymeti.VisibleIndex = 6;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            // 
            // colTarix
            // 
            this.colTarix.FieldName = "Tarix";
            this.colTarix.Name = "colTarix";
            this.colTarix.Visible = true;
            this.colTarix.VisibleIndex = 8;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.Name = "colMasalar";
            this.colMasalar.Visible = true;
            this.colMasalar.VisibleIndex = 9;
            // 
            // Group_Hesablamalar
            // 
            this.Group_Hesablamalar.Controls.Add(this.Calc_Endirimli_Qiymet);
            this.Group_Hesablamalar.Controls.Add(this.labelControl7);
            this.Group_Hesablamalar.Controls.Add(this.Calc_Umumi_Qiymet);
            this.Group_Hesablamalar.Controls.Add(this.labelControl6);
            this.Group_Hesablamalar.Controls.Add(this.Calc_Endirim);
            this.Group_Hesablamalar.Controls.Add(this.Calc_Qalan);
            this.Group_Hesablamalar.Controls.Add(this.labelControl5);
            this.Group_Hesablamalar.Controls.Add(this.labelControl3);
            this.Group_Hesablamalar.Controls.Add(this.Calc_Endirim_Toplam);
            this.Group_Hesablamalar.Controls.Add(this.labelControl4);
            this.Group_Hesablamalar.Controls.Add(this.Calc_Odeden);
            this.Group_Hesablamalar.Controls.Add(this.labelControl2);
            this.Group_Hesablamalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Hesablamalar.Location = new System.Drawing.Point(0, 274);
            this.Group_Hesablamalar.Name = "Group_Hesablamalar";
            this.Group_Hesablamalar.Size = new System.Drawing.Size(1596, 103);
            this.Group_Hesablamalar.TabIndex = 0;
            this.Group_Hesablamalar.Text = "Hesablamalar";
            // 
            // Calc_Odeden
            // 
            this.Calc_Odeden.Location = new System.Drawing.Point(184, 33);
            this.Calc_Odeden.Name = "Calc_Odeden";
            this.Calc_Odeden.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Calc_Odeden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Odeden.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Calc_Odeden.Properties.Appearance.Options.UseBackColor = true;
            this.Calc_Odeden.Properties.Appearance.Options.UseFont = true;
            this.Calc_Odeden.Properties.Appearance.Options.UseForeColor = true;
            this.Calc_Odeden.Properties.Appearance.Options.UseTextOptions = true;
            this.Calc_Odeden.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Calc_Odeden.Properties.MaskSettings.Set("mask", "c");
            this.Calc_Odeden.Properties.NullText = "0,00  ₼";
            this.Calc_Odeden.Properties.NullValuePrompt = "0,00  ₼";
            this.Calc_Odeden.Properties.ShowCloseButton = true;
            this.Calc_Odeden.Size = new System.Drawing.Size(248, 26);
            this.Calc_Odeden.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(28, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(150, 26);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Odenis :";
            // 
            // Calc_Qalan
            // 
            this.Calc_Qalan.Location = new System.Drawing.Point(184, 67);
            this.Calc_Qalan.Name = "Calc_Qalan";
            this.Calc_Qalan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Calc_Qalan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Qalan.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Calc_Qalan.Properties.Appearance.Options.UseBackColor = true;
            this.Calc_Qalan.Properties.Appearance.Options.UseFont = true;
            this.Calc_Qalan.Properties.Appearance.Options.UseForeColor = true;
            this.Calc_Qalan.Properties.Appearance.Options.UseTextOptions = true;
            this.Calc_Qalan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Calc_Qalan.Properties.MaskSettings.Set("mask", "c");
            this.Calc_Qalan.Properties.NullText = "0,00  ₼";
            this.Calc_Qalan.Properties.NullValuePrompt = "0,00  ₼";
            this.Calc_Qalan.Properties.ShowCloseButton = true;
            this.Calc_Qalan.Size = new System.Drawing.Size(248, 26);
            this.Calc_Qalan.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(28, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 26);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Qalan :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(598, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(150, 26);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Endirim Toplam :";
            // 
            // Calc_Endirim_Toplam
            // 
            this.Calc_Endirim_Toplam.Location = new System.Drawing.Point(754, 33);
            this.Calc_Endirim_Toplam.Name = "Calc_Endirim_Toplam";
            this.Calc_Endirim_Toplam.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Calc_Endirim_Toplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Endirim_Toplam.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Calc_Endirim_Toplam.Properties.Appearance.Options.UseBackColor = true;
            this.Calc_Endirim_Toplam.Properties.Appearance.Options.UseFont = true;
            this.Calc_Endirim_Toplam.Properties.Appearance.Options.UseForeColor = true;
            this.Calc_Endirim_Toplam.Properties.Appearance.Options.UseTextOptions = true;
            this.Calc_Endirim_Toplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Calc_Endirim_Toplam.Properties.MaskSettings.Set("mask", "c");
            this.Calc_Endirim_Toplam.Properties.NullText = "0,00  ₼";
            this.Calc_Endirim_Toplam.Properties.NullValuePrompt = "0,00  ₼";
            this.Calc_Endirim_Toplam.Properties.ShowCloseButton = true;
            this.Calc_Endirim_Toplam.Size = new System.Drawing.Size(248, 26);
            this.Calc_Endirim_Toplam.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(598, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(150, 26);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Endirim % -i :";
            // 
            // Calc_Endirim
            // 
            this.Calc_Endirim.Location = new System.Drawing.Point(755, 67);
            this.Calc_Endirim.Name = "Calc_Endirim";
            this.Calc_Endirim.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Calc_Endirim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Endirim.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Calc_Endirim.Properties.Appearance.Options.UseBackColor = true;
            this.Calc_Endirim.Properties.Appearance.Options.UseFont = true;
            this.Calc_Endirim.Properties.Appearance.Options.UseForeColor = true;
            this.Calc_Endirim.Properties.Appearance.Options.UseTextOptions = true;
            this.Calc_Endirim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Calc_Endirim.Properties.MaskSettings.Set("mask", "P");
            this.Calc_Endirim.Properties.NullText = "% 0,00  ";
            this.Calc_Endirim.Properties.NullValuePrompt = "% 0,00  ";
            this.Calc_Endirim.Properties.ShowCloseButton = true;
            this.Calc_Endirim.Size = new System.Drawing.Size(248, 26);
            this.Calc_Endirim.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(1160, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(150, 26);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Ümumi Qiymət :";
            // 
            // Calc_Umumi_Qiymet
            // 
            this.Calc_Umumi_Qiymet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calc_Umumi_Qiymet.Location = new System.Drawing.Point(1316, 32);
            this.Calc_Umumi_Qiymet.Name = "Calc_Umumi_Qiymet";
            this.Calc_Umumi_Qiymet.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Calc_Umumi_Qiymet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Umumi_Qiymet.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Calc_Umumi_Qiymet.Properties.Appearance.Options.UseBackColor = true;
            this.Calc_Umumi_Qiymet.Properties.Appearance.Options.UseFont = true;
            this.Calc_Umumi_Qiymet.Properties.Appearance.Options.UseForeColor = true;
            this.Calc_Umumi_Qiymet.Properties.Appearance.Options.UseTextOptions = true;
            this.Calc_Umumi_Qiymet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Calc_Umumi_Qiymet.Properties.MaskSettings.Set("mask", "c");
            this.Calc_Umumi_Qiymet.Properties.NullText = "0,00  ₼";
            this.Calc_Umumi_Qiymet.Properties.NullValuePrompt = "0,00  ₼";
            this.Calc_Umumi_Qiymet.Properties.ShowCloseButton = true;
            this.Calc_Umumi_Qiymet.Size = new System.Drawing.Size(248, 26);
            this.Calc_Umumi_Qiymet.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(1161, 66);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(150, 26);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Endirimli Qiymət :";
            // 
            // Calc_Endirimli_Qiymet
            // 
            this.Calc_Endirimli_Qiymet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calc_Endirimli_Qiymet.Location = new System.Drawing.Point(1317, 66);
            this.Calc_Endirimli_Qiymet.Name = "Calc_Endirimli_Qiymet";
            this.Calc_Endirimli_Qiymet.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Calc_Endirimli_Qiymet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Endirimli_Qiymet.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Calc_Endirimli_Qiymet.Properties.Appearance.Options.UseBackColor = true;
            this.Calc_Endirimli_Qiymet.Properties.Appearance.Options.UseFont = true;
            this.Calc_Endirimli_Qiymet.Properties.Appearance.Options.UseForeColor = true;
            this.Calc_Endirimli_Qiymet.Properties.Appearance.Options.UseTextOptions = true;
            this.Calc_Endirimli_Qiymet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Calc_Endirimli_Qiymet.Properties.MaskSettings.Set("mask", "c");
            this.Calc_Endirimli_Qiymet.Properties.NullText = "0,00  ₼";
            this.Calc_Endirimli_Qiymet.Properties.NullValuePrompt = "0,00  ₼";
            this.Calc_Endirimli_Qiymet.Properties.ShowCloseButton = true;
            this.Calc_Endirimli_Qiymet.Size = new System.Drawing.Size(248, 26);
            this.Calc_Endirimli_Qiymet.TabIndex = 1;
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Masa_Durumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).EndInit();
            this.Group_Emeliyyatlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Hesablamalar)).EndInit();
            this.Group_Hesablamalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Odeden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Qalan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Endirim_Toplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Endirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Umumi_Qiymet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_Endirimli_Qiymet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl Group_Emeliyyatlar;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Yeni_Sifaris;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
        private DevExpress.XtraEditors.SimpleButton Btn_Kayd_Et;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl Group_Hesablamalar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Dolu_Masa;
        private DevExpress.XtraEditors.SimpleButton Btn_Rezervli_Masa;
        private DevExpress.XtraEditors.SimpleButton Btn_Bos_Masa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit Calc_Odeden;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiqdari;
        private DevExpress.XtraGrid.Columns.GridColumn colQiymeti;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarix;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
        private DevExpress.XtraEditors.CalcEdit Calc_Qalan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit Calc_Endirimli_Qiymet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit Calc_Umumi_Qiymet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CalcEdit Calc_Endirim;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CalcEdit Calc_Endirim_Toplam;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}