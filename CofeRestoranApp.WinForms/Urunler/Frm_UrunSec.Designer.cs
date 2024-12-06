namespace CofeRestoranApp.WinForms.Urunler
{
    partial class Frm_UrunSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UrunSec));
            this.Lbn_Basliq = new DevExpress.XtraEditors.LabelControl();
            this.Group_Emeliyyatlar = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Sec = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cisix_et = new DevExpress.XtraEditors.SimpleButton();
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
            this.Menuadi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).BeginInit();
            this.Group_Emeliyyatlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbn_Basliq
            // 
            this.Lbn_Basliq.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbn_Basliq.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbn_Basliq.Appearance.Options.UseFont = true;
            this.Lbn_Basliq.Appearance.Options.UseForeColor = true;
            this.Lbn_Basliq.Appearance.Options.UseTextOptions = true;
            this.Lbn_Basliq.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbn_Basliq.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbn_Basliq.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbn_Basliq.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbn_Basliq.Location = new System.Drawing.Point(0, 0);
            this.Lbn_Basliq.Name = "Lbn_Basliq";
            this.Lbn_Basliq.Size = new System.Drawing.Size(1462, 43);
            this.Lbn_Basliq.TabIndex = 8;
            this.Lbn_Basliq.Text = "Mehsul Sec";
            // 
            // Group_Emeliyyatlar
            // 
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Sec);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_cisix_et);
            this.Group_Emeliyyatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Emeliyyatlar.Location = new System.Drawing.Point(0, 693);
            this.Group_Emeliyyatlar.Name = "Group_Emeliyyatlar";
            this.Group_Emeliyyatlar.Size = new System.Drawing.Size(1462, 81);
            this.Group_Emeliyyatlar.TabIndex = 9;
            this.Group_Emeliyyatlar.Text = "Əməliyyatlar";
            // 
            // Btn_Sec
            // 
            this.Btn_Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Sec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sec.Appearance.Options.UseFont = true;
            this.Btn_Sec.Appearance.Options.UseTextOptions = true;
            this.Btn_Sec.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Sec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sec.ImageOptions.Image")));
            this.Btn_Sec.Location = new System.Drawing.Point(1202, 26);
            this.Btn_Sec.Name = "Btn_Sec";
            this.Btn_Sec.Size = new System.Drawing.Size(125, 46);
            this.Btn_Sec.TabIndex = 3;
            this.Btn_Sec.Text = "Sec";
            this.Btn_Sec.Click += new System.EventHandler(this.Btn_Sec_Click);
            // 
            // btn_cisix_et
            // 
            this.btn_cisix_et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cisix_et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cisix_et.Appearance.Options.UseFont = true;
            this.btn_cisix_et.Appearance.Options.UseTextOptions = true;
            this.btn_cisix_et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_cisix_et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cisix_et.ImageOptions.SvgImage")));
            this.btn_cisix_et.Location = new System.Drawing.Point(1333, 26);
            this.btn_cisix_et.Name = "btn_cisix_et";
            this.btn_cisix_et.Size = new System.Drawing.Size(125, 46);
            this.btn_cisix_et.TabIndex = 3;
            this.btn_cisix_et.Text = "Çıxış";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1462, 650);
            this.gridControl1.TabIndex = 10;
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
            this.colMenu,
            this.Menuadi});
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
            this.colId.Width = 92;
            // 
            // colMeynuID
            // 
            this.colMeynuID.Caption = "Meynu";
            this.colMeynuID.FieldName = "Menu";
            this.colMeynuID.Name = "colMeynuID";
            this.colMeynuID.Width = 73;
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 2;
            this.colUrunKodu.Width = 82;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 3;
            this.colUrunAdi.Width = 85;
            // 
            // colQiymet1
            // 
            this.colQiymet1.FieldName = "Qiymet1";
            this.colQiymet1.Name = "colQiymet1";
            this.colQiymet1.Visible = true;
            this.colQiymet1.VisibleIndex = 4;
            this.colQiymet1.Width = 79;
            // 
            // colQiymet2
            // 
            this.colQiymet2.FieldName = "Qiymet2";
            this.colQiymet2.Name = "colQiymet2";
            this.colQiymet2.Visible = true;
            this.colQiymet2.VisibleIndex = 5;
            this.colQiymet2.Width = 85;
            // 
            // colQiymet3
            // 
            this.colQiymet3.FieldName = "Qiymet3";
            this.colQiymet3.Name = "colQiymet3";
            this.colQiymet3.Visible = true;
            this.colQiymet3.VisibleIndex = 6;
            this.colQiymet3.Width = 83;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 578;
            // 
            // colTarix
            // 
            this.colTarix.FieldName = "Tarix";
            this.colTarix.Name = "colTarix";
            this.colTarix.Visible = true;
            this.colTarix.VisibleIndex = 8;
            this.colTarix.Width = 280;
            // 
            // colSekil
            // 
            this.colSekil.FieldName = "Sekil";
            this.colSekil.Name = "colSekil";
            this.colSekil.Width = 342;
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "MenuAdi";
            this.colMenu.Name = "colMenu";
            // 
            // Menuadi
            // 
            this.Menuadi.Caption = "Menu";
            this.Menuadi.FieldName = "Menu.MenuAdi";
            this.Menuadi.Name = "Menuadi";
            this.Menuadi.Visible = true;
            this.Menuadi.VisibleIndex = 1;
            // 
            // Frm_UrunSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 774);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.Group_Emeliyyatlar);
            this.Controls.Add(this.Lbn_Basliq);
            this.Name = "Frm_UrunSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mehsul Sec";
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).EndInit();
            this.Group_Emeliyyatlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Lbn_Basliq;
        private DevExpress.XtraEditors.GroupControl Group_Emeliyyatlar;
        private DevExpress.XtraEditors.SimpleButton Btn_Sec;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
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
        private DevExpress.XtraGrid.Columns.GridColumn Menuadi;
    }
}