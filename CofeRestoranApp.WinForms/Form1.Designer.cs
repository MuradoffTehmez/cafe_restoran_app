namespace CofeRestoranApp.WinForms
{
    partial class Form1
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
            this.Btn_Meynu = new System.Windows.Forms.Button();
            this.Txt_Meynu_Adi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Meynu
            // 
            this.Btn_Meynu.Location = new System.Drawing.Point(54, 76);
            this.Btn_Meynu.Name = "Btn_Meynu";
            this.Btn_Meynu.Size = new System.Drawing.Size(209, 61);
            this.Btn_Meynu.TabIndex = 0;
            this.Btn_Meynu.Text = "button1";
            this.Btn_Meynu.UseVisualStyleBackColor = true;
            this.Btn_Meynu.Click += new System.EventHandler(this.Btn_Meynu_Click);
            // 
            // Txt_Meynu_Adi
            // 
            this.Txt_Meynu_Adi.Location = new System.Drawing.Point(21, 28);
            this.Txt_Meynu_Adi.Name = "Txt_Meynu_Adi";
            this.Txt_Meynu_Adi.Size = new System.Drawing.Size(283, 20);
            this.Txt_Meynu_Adi.TabIndex = 1;
            this.Txt_Meynu_Adi.TextChanged += new System.EventHandler(this.Txt_Meynu_Adi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 180);
            this.Controls.Add(this.Btn_Meynu);
            this.Controls.Add(this.Txt_Meynu_Adi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Meynu;
        private System.Windows.Forms.TextBox Txt_Meynu_Adi;
    }
}

