namespace CofeRestoranApp.WinForms.Masalar
{
    partial class Frm_Masa_Rezervasiya
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
            this.Lbn_Basliq = new DevExpress.XtraEditors.LabelControl();
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
            this.Lbn_Basliq.Size = new System.Drawing.Size(762, 43);
            this.Lbn_Basliq.TabIndex = 9;
            this.Lbn_Basliq.Text = "Masa Melumati";
            // 
            // Frm_Masa_Rezervasiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 577);
            this.Controls.Add(this.Lbn_Basliq);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Masa_Rezervasiya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasiya";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Lbn_Basliq;
    }
}