namespace CofeRestoranApp.WinForms.AnaMenu
{
    partial class Frm_Ana_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ana_Form));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Masalar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Masa_Haraketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Meynular = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Meynu_Haraketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Urunler = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Urun_Haraketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Kullanicilar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Kullanici_Haraketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Modlar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Vayluta = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Yardim = new DevExpress.XtraBars.BarButtonItem();
            this.btn_haqqinizda = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_Masalar,
            this.btn_Masa_Haraketleri,
            this.btn_Meynular,
            this.btn_Meynu_Haraketleri,
            this.btn_Urunler,
            this.btn_Urun_Haraketleri,
            this.btn_Kullanicilar,
            this.btn_Kullanici_Haraketleri,
            this.barButtonItem1,
            this.btn_Modlar,
            this.btn_Vayluta,
            this.barButtonItem2,
            this.btn_Yardim,
            this.btn_haqqinizda});
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_Masalar
            // 
            resources.ApplyResources(this.btn_Masalar, "btn_Masalar");
            this.btn_Masalar.Id = 1;
            this.btn_Masalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Masalar.ImageOptions.LargeImage")));
            this.btn_Masalar.Name = "btn_Masalar";
            this.btn_Masalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Masalar_ItemClick);
            // 
            // btn_Masa_Haraketleri
            // 
            resources.ApplyResources(this.btn_Masa_Haraketleri, "btn_Masa_Haraketleri");
            this.btn_Masa_Haraketleri.Id = 2;
            this.btn_Masa_Haraketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Masa_Haraketleri.ImageOptions.SvgImage")));
            this.btn_Masa_Haraketleri.Name = "btn_Masa_Haraketleri";
            this.btn_Masa_Haraketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_Meynular
            // 
            resources.ApplyResources(this.btn_Meynular, "btn_Meynular");
            this.btn_Meynular.Id = 4;
            this.btn_Meynular.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Meynular.ImageOptions.SvgImage")));
            this.btn_Meynular.Name = "btn_Meynular";
            this.btn_Meynular.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Meynular_ItemClick);
            // 
            // btn_Meynu_Haraketleri
            // 
            resources.ApplyResources(this.btn_Meynu_Haraketleri, "btn_Meynu_Haraketleri");
            this.btn_Meynu_Haraketleri.Id = 5;
            this.btn_Meynu_Haraketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Meynu_Haraketleri.ImageOptions.SvgImage")));
            this.btn_Meynu_Haraketleri.Name = "btn_Meynu_Haraketleri";
            // 
            // btn_Urunler
            // 
            resources.ApplyResources(this.btn_Urunler, "btn_Urunler");
            this.btn_Urunler.Id = 6;
            this.btn_Urunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Urunler.ImageOptions.SvgImage")));
            this.btn_Urunler.Name = "btn_Urunler";
            this.btn_Urunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Urunler_ItemClick);
            // 
            // btn_Urun_Haraketleri
            // 
            resources.ApplyResources(this.btn_Urun_Haraketleri, "btn_Urun_Haraketleri");
            this.btn_Urun_Haraketleri.Id = 7;
            this.btn_Urun_Haraketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Urun_Haraketleri.ImageOptions.SvgImage")));
            this.btn_Urun_Haraketleri.Name = "btn_Urun_Haraketleri";
            // 
            // btn_Kullanicilar
            // 
            resources.ApplyResources(this.btn_Kullanicilar, "btn_Kullanicilar");
            this.btn_Kullanicilar.Id = 8;
            this.btn_Kullanicilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Kullanicilar.ImageOptions.LargeImage")));
            this.btn_Kullanicilar.Name = "btn_Kullanicilar";
            // 
            // btn_Kullanici_Haraketleri
            // 
            resources.ApplyResources(this.btn_Kullanici_Haraketleri, "btn_Kullanici_Haraketleri");
            this.btn_Kullanici_Haraketleri.Id = 9;
            this.btn_Kullanici_Haraketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Kullanici_Haraketleri.ImageOptions.LargeImage")));
            this.btn_Kullanici_Haraketleri.Name = "btn_Kullanici_Haraketleri";
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_Modlar
            // 
            resources.ApplyResources(this.btn_Modlar, "btn_Modlar");
            this.btn_Modlar.Id = 11;
            this.btn_Modlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Modlar.ImageOptions.SvgImage")));
            this.btn_Modlar.Name = "btn_Modlar";
            // 
            // btn_Vayluta
            // 
            resources.ApplyResources(this.btn_Vayluta, "btn_Vayluta");
            this.btn_Vayluta.Id = 12;
            this.btn_Vayluta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Vayluta.ImageOptions.SvgImage")));
            this.btn_Vayluta.Name = "btn_Vayluta";
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_Yardim
            // 
            resources.ApplyResources(this.btn_Yardim, "btn_Yardim");
            this.btn_Yardim.Id = 14;
            this.btn_Yardim.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Yardim.ImageOptions.SvgImage")));
            this.btn_Yardim.Name = "btn_Yardim";
            // 
            // btn_haqqinizda
            // 
            resources.ApplyResources(this.btn_haqqinizda, "btn_haqqinizda");
            this.btn_haqqinizda.Id = 15;
            this.btn_haqqinizda.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_haqqinizda.ImageOptions.LargeImage")));
            this.btn_haqqinizda.Name = "btn_haqqinizda";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            resources.ApplyResources(this.ribbonPage2, "ribbonPage2");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Masalar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Masa_Haraketleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Tag = "";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup3.ImageOptions.Image")));
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Meynular);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Meynu_Haraketleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_Urunler);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_Urun_Haraketleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Kullanicilar);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Kullanici_Haraketleri);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Modlar);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            resources.ApplyResources(this.ribbonPageGroup5, "ribbonPageGroup5");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Vayluta);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_Yardim);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            resources.ApplyResources(this.ribbonPageGroup6, "ribbonPageGroup6");
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_haqqinizda);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            resources.ApplyResources(this.ribbonPageGroup7, "ribbonPageGroup7");
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Frm_Ana_Form
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lime;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Frm_Ana_Form.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "Frm_Ana_Form";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Ana_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btn_Masalar;
        private DevExpress.XtraBars.BarButtonItem btn_Masa_Haraketleri;
        private DevExpress.XtraBars.BarButtonItem btn_Meynular;
        private DevExpress.XtraBars.BarButtonItem btn_Meynu_Haraketleri;
        private DevExpress.XtraBars.BarButtonItem btn_Urunler;
        private DevExpress.XtraBars.BarButtonItem btn_Urun_Haraketleri;
        private DevExpress.XtraBars.BarButtonItem btn_Kullanicilar;
        private DevExpress.XtraBars.BarButtonItem btn_Kullanici_Haraketleri;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_Modlar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_Vayluta;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_Yardim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btn_haqqinizda;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}