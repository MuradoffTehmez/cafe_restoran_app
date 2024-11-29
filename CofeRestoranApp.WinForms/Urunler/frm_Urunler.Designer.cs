namespace CofeRestoranApp.WinForms.Urunler
{
    partial class frm_Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Urunler));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cisix_et = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Duzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.brn_Elave_Et = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeynuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQiymet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQiymet2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQiymet3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSekil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.labelControl1.Size = new System.Drawing.Size(1316, 43);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Məhsullar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btn_cisix_et);
            this.groupControl1.Controls.Add(this.btn_Duzenle);
            this.groupControl1.Controls.Add(this.btn_Sil);
            this.groupControl1.Controls.Add(this.brn_Elave_Et);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 598);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1316, 149);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Əməliyyatlar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(356, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(166, 103);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Güncəllə \r\nvə \r\nListələ";
            // 
            // btn_cisix_et
            // 
            this.btn_cisix_et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cisix_et.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cisix_et.Appearance.Options.UseFont = true;
            this.btn_cisix_et.Appearance.Options.UseTextOptions = true;
            this.btn_cisix_et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_cisix_et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cisix_et.ImageOptions.SvgImage")));
            this.btn_cisix_et.Location = new System.Drawing.Point(1185, 34);
            this.btn_cisix_et.Name = "btn_cisix_et";
            this.btn_cisix_et.Size = new System.Drawing.Size(119, 103);
            this.btn_cisix_et.TabIndex = 3;
            this.btn_cisix_et.Text = "Çıxış";
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Duzenle.Appearance.Options.UseFont = true;
            this.btn_Duzenle.Appearance.Options.UseTextOptions = true;
            this.btn_Duzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Duzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Duzenle.ImageOptions.SvgImage")));
            this.btn_Duzenle.Location = new System.Drawing.Point(184, 34);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(166, 103);
            this.btn_Duzenle.TabIndex = 2;
            this.btn_Duzenle.Text = "Dəyişdir";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.Appearance.Options.UseFont = true;
            this.btn_Sil.Appearance.Options.UseTextOptions = true;
            this.btn_Sil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sil.ImageOptions.SvgImage")));
            this.btn_Sil.Location = new System.Drawing.Point(1013, 34);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(166, 103);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "Sil";
            // 
            // brn_Elave_Et
            // 
            this.brn_Elave_Et.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Elave_Et.Appearance.Options.UseFont = true;
            this.brn_Elave_Et.Appearance.Options.UseTextOptions = true;
            this.brn_Elave_Et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.brn_Elave_Et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brn_Elave_Et.ImageOptions.SvgImage")));
            this.brn_Elave_Et.Location = new System.Drawing.Point(12, 34);
            this.brn_Elave_Et.Name = "brn_Elave_Et";
            this.brn_Elave_Et.Size = new System.Drawing.Size(166, 103);
            this.brn_Elave_Et.TabIndex = 0;
            this.brn_Elave_Et.Text = "Əlavə et";
            this.brn_Elave_Et.Click += new System.EventHandler(this.brn_Elave_Et_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1316, 555);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMeynuID,
            this.colUrunKodu,
            this.colUrunAdi,
            this.colQiymet1,
            this.colQiymet2,
            this.colQiymet3,
            this.colAciklama,
            this.colTarix,
            this.colSekil,
            this.colMenu});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1304, 647, 259, 272);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 69;
            // 
            // colMeynuID
            // 
            this.colMeynuID.Caption = "Meynu";
            this.colMeynuID.FieldName = "Menu";
            this.colMeynuID.Name = "colMeynuID";
            this.colMeynuID.Visible = true;
            this.colMeynuID.VisibleIndex = 1;
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 2;
            this.colUrunKodu.Width = 101;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 3;
            this.colUrunAdi.Width = 119;
            // 
            // colQiymet1
            // 
            this.colQiymet1.FieldName = "Qiymet1";
            this.colQiymet1.Name = "colQiymet1";
            this.colQiymet1.Visible = true;
            this.colQiymet1.VisibleIndex = 4;
            this.colQiymet1.Width = 95;
            // 
            // colQiymet2
            // 
            this.colQiymet2.FieldName = "Qiymet2";
            this.colQiymet2.Name = "colQiymet2";
            this.colQiymet2.Visible = true;
            this.colQiymet2.VisibleIndex = 5;
            this.colQiymet2.Width = 99;
            // 
            // colQiymet3
            // 
            this.colQiymet3.FieldName = "Qiymet3";
            this.colQiymet3.Name = "colQiymet3";
            this.colQiymet3.Visible = true;
            this.colQiymet3.VisibleIndex = 6;
            this.colQiymet3.Width = 103;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 501;
            // 
            // colTarix
            // 
            this.colTarix.FieldName = "Tarix";
            this.colTarix.Name = "colTarix";
            this.colTarix.Visible = true;
            this.colTarix.VisibleIndex = 8;
            this.colTarix.Width = 204;
            // 
            // colSekil
            // 
            this.colSekil.FieldName = "Sekil";
            this.colSekil.Name = "colSekil";
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            // 
            // frm_Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 747);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Urunler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
        private DevExpress.XtraEditors.SimpleButton btn_Duzenle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton brn_Elave_Et;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMeynuID;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colQiymet1;
        private DevExpress.XtraGrid.Columns.GridColumn colQiymet2;
        private DevExpress.XtraGrid.Columns.GridColumn colQiymet3;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarix;
        private DevExpress.XtraGrid.Columns.GridColumn colSekil;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
    }
}