namespace CofeRestoranApp.WinForms.Odenisler
{
    partial class Frm_Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Odeme));
            this.Lbn_Basliq = new DevExpress.XtraEditors.LabelControl();
            this.Group_Emeliyyatlar = new DevExpress.XtraEditors.GroupControl();
            this.btn_cisix_et = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kayd_Et = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).BeginInit();
            this.Group_Emeliyyatlar.SuspendLayout();
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
            this.Lbn_Basliq.Size = new System.Drawing.Size(522, 43);
            this.Lbn_Basliq.TabIndex = 8;
            this.Lbn_Basliq.Text = "Odenisler";
            // 
            // Group_Emeliyyatlar
            // 
            this.Group_Emeliyyatlar.Controls.Add(this.btn_cisix_et);
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Kayd_Et);
            this.Group_Emeliyyatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Emeliyyatlar.Location = new System.Drawing.Point(0, 317);
            this.Group_Emeliyyatlar.Name = "Group_Emeliyyatlar";
            this.Group_Emeliyyatlar.Size = new System.Drawing.Size(522, 81);
            this.Group_Emeliyyatlar.TabIndex = 9;
            this.Group_Emeliyyatlar.Text = "Əməliyyatlar";
            // 
            // btn_cisix_et
            // 
            this.btn_cisix_et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cisix_et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cisix_et.Appearance.Options.UseFont = true;
            this.btn_cisix_et.Appearance.Options.UseTextOptions = true;
            this.btn_cisix_et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_cisix_et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cisix_et.ImageOptions.SvgImage")));
            this.btn_cisix_et.Location = new System.Drawing.Point(393, 26);
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
            this.Btn_Kayd_Et.Location = new System.Drawing.Point(262, 26);
            this.Btn_Kayd_Et.Name = "Btn_Kayd_Et";
            this.Btn_Kayd_Et.Size = new System.Drawing.Size(125, 46);
            this.Btn_Kayd_Et.TabIndex = 1;
            this.Btn_Kayd_Et.Text = "Qeyd et";
            // 
            // Frm_Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 398);
            this.Controls.Add(this.Group_Emeliyyatlar);
            this.Controls.Add(this.Lbn_Basliq);
            this.Name = "Frm_Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odenis";
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).EndInit();
            this.Group_Emeliyyatlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Lbn_Basliq;
        private DevExpress.XtraEditors.GroupControl Group_Emeliyyatlar;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
        private DevExpress.XtraEditors.SimpleButton Btn_Kayd_Et;
    }
}