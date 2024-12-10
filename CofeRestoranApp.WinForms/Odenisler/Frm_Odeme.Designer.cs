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
            this.Btn_Onay = new DevExpress.XtraEditors.SimpleButton();
            this.Calc_OdenecekTutar = new DevExpress.XtraEditors.CalcEdit();
            this.txtR_Aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dateTarix = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).BeginInit();
            this.Group_Emeliyyatlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_OdenecekTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtR_Aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties.CalendarTimeProperties)).BeginInit();
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
            this.Lbn_Basliq.Size = new System.Drawing.Size(521, 43);
            this.Lbn_Basliq.TabIndex = 8;
            this.Lbn_Basliq.Text = "Odenisler";
            // 
            // Group_Emeliyyatlar
            // 
            this.Group_Emeliyyatlar.Controls.Add(this.btn_cisix_et);
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Onay);
            this.Group_Emeliyyatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Emeliyyatlar.Location = new System.Drawing.Point(0, 214);
            this.Group_Emeliyyatlar.Name = "Group_Emeliyyatlar";
            this.Group_Emeliyyatlar.Size = new System.Drawing.Size(521, 81);
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
            this.btn_cisix_et.Location = new System.Drawing.Point(392, 26);
            this.btn_cisix_et.Name = "btn_cisix_et";
            this.btn_cisix_et.Size = new System.Drawing.Size(125, 46);
            this.btn_cisix_et.TabIndex = 3;
            this.btn_cisix_et.Text = "Çıxış";
            // 
            // Btn_Onay
            // 
            this.Btn_Onay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Onay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Onay.Appearance.Options.UseFont = true;
            this.Btn_Onay.Appearance.Options.UseTextOptions = true;
            this.Btn_Onay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Onay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kayd_Et.ImageOptions.Image")));
            this.Btn_Onay.Location = new System.Drawing.Point(261, 26);
            this.Btn_Onay.Name = "Btn_Onay";
            this.Btn_Onay.Size = new System.Drawing.Size(125, 46);
            this.Btn_Onay.TabIndex = 1;
            this.Btn_Onay.Text = "Təstiqlə";
            // 
            // Calc_OdenecekTutar
            // 
            this.Calc_OdenecekTutar.Location = new System.Drawing.Point(212, 57);
            this.Calc_OdenecekTutar.Name = "Calc_OdenecekTutar";
            this.Calc_OdenecekTutar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Calc_OdenecekTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_OdenecekTutar.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Calc_OdenecekTutar.Properties.Appearance.Options.UseBackColor = true;
            this.Calc_OdenecekTutar.Properties.Appearance.Options.UseFont = true;
            this.Calc_OdenecekTutar.Properties.Appearance.Options.UseForeColor = true;
            this.Calc_OdenecekTutar.Properties.Appearance.Options.UseTextOptions = true;
            this.Calc_OdenecekTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Calc_OdenecekTutar.Properties.MaskSettings.Set("mask", "c");
            this.Calc_OdenecekTutar.Properties.NullText = "0,00  ₼";
            this.Calc_OdenecekTutar.Properties.NullValuePrompt = "0,00  ₼";
            this.Calc_OdenecekTutar.Properties.ShowCloseButton = true;
            this.Calc_OdenecekTutar.Properties.UseMaskAsDisplayFormat = true;
            this.Calc_OdenecekTutar.Size = new System.Drawing.Size(297, 26);
            this.Calc_OdenecekTutar.TabIndex = 10;
            // 
            // txtR_Aciklama
            // 
            this.txtR_Aciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtR_Aciklama.Location = new System.Drawing.Point(212, 89);
            this.txtR_Aciklama.Name = "txtR_Aciklama";
            this.txtR_Aciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR_Aciklama.Properties.Appearance.Options.UseFont = true;
            this.txtR_Aciklama.Size = new System.Drawing.Size(297, 83);
            this.txtR_Aciklama.TabIndex = 33;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BackColor = System.Drawing.Color.Red;
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Options.UseBackColor = true;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(12, 89);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(176, 83);
            this.labelControl10.TabIndex = 32;
            this.labelControl10.Text = "Melumat :  ";
            // 
            // dateTarix
            // 
            this.dateTarix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTarix.EditValue = null;
            this.dateTarix.Location = new System.Drawing.Point(212, 178);
            this.dateTarix.Name = "dateTarix";
            this.dateTarix.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dateTarix.Properties.Appearance.Options.UseFont = true;
            this.dateTarix.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarix.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarix.Size = new System.Drawing.Size(297, 26);
            this.dateTarix.TabIndex = 35;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(12, 178);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(176, 26);
            this.labelControl9.TabIndex = 34;
            this.labelControl9.Text = "Tarix :  ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(12, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 26);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Ödənəcək  Qiymət : ";
            // 
            // Frm_Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 295);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateTarix);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtR_Aciklama);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.Calc_OdenecekTutar);
            this.Controls.Add(this.Group_Emeliyyatlar);
            this.Controls.Add(this.Lbn_Basliq);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odenis";
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).EndInit();
            this.Group_Emeliyyatlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Calc_OdenecekTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtR_Aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Lbn_Basliq;
        private DevExpress.XtraEditors.GroupControl Group_Emeliyyatlar;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
        private DevExpress.XtraEditors.SimpleButton Btn_Onay;
        private DevExpress.XtraEditors.CalcEdit Calc_OdenecekTutar;
        private DevExpress.XtraEditors.MemoEdit txtR_Aciklama;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dateTarix;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}