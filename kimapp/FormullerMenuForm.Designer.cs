namespace kimapp
{
    partial class FormullerMenuForm
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
            this.btnFormuller = new ns1.BunifuFlatButton();
            this.btnFormulEkle = new ns1.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnFormuller
            // 
            this.btnFormuller.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFormuller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnFormuller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormuller.BorderRadius = 5;
            this.btnFormuller.ButtonText = "Formüller";
            this.btnFormuller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormuller.DisabledColor = System.Drawing.Color.Gray;
            this.btnFormuller.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFormuller.Iconimage = null;
            this.btnFormuller.Iconimage_right = null;
            this.btnFormuller.Iconimage_right_Selected = null;
            this.btnFormuller.Iconimage_Selected = null;
            this.btnFormuller.IconMarginLeft = 0;
            this.btnFormuller.IconMarginRight = 0;
            this.btnFormuller.IconRightVisible = true;
            this.btnFormuller.IconRightZoom = 0D;
            this.btnFormuller.IconVisible = true;
            this.btnFormuller.IconZoom = 90D;
            this.btnFormuller.IsTab = false;
            this.btnFormuller.Location = new System.Drawing.Point(12, 29);
            this.btnFormuller.Name = "btnFormuller";
            this.btnFormuller.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnFormuller.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFormuller.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFormuller.selected = false;
            this.btnFormuller.Size = new System.Drawing.Size(174, 39);
            this.btnFormuller.TabIndex = 1;
            this.btnFormuller.Text = "Formüller";
            this.btnFormuller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormuller.Textcolor = System.Drawing.Color.White;
            this.btnFormuller.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnFormulEkle
            // 
            this.btnFormulEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFormulEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnFormulEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormulEkle.BorderRadius = 5;
            this.btnFormulEkle.ButtonText = "Formül Ekle";
            this.btnFormulEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormulEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnFormulEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFormulEkle.Iconimage = null;
            this.btnFormulEkle.Iconimage_right = null;
            this.btnFormulEkle.Iconimage_right_Selected = null;
            this.btnFormulEkle.Iconimage_Selected = null;
            this.btnFormulEkle.IconMarginLeft = 0;
            this.btnFormulEkle.IconMarginRight = 0;
            this.btnFormulEkle.IconRightVisible = true;
            this.btnFormulEkle.IconRightZoom = 0D;
            this.btnFormulEkle.IconVisible = true;
            this.btnFormulEkle.IconZoom = 90D;
            this.btnFormulEkle.IsTab = false;
            this.btnFormulEkle.Location = new System.Drawing.Point(12, 74);
            this.btnFormulEkle.Name = "btnFormulEkle";
            this.btnFormulEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnFormulEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFormulEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFormulEkle.selected = false;
            this.btnFormulEkle.Size = new System.Drawing.Size(174, 39);
            this.btnFormulEkle.TabIndex = 1;
            this.btnFormulEkle.Text = "Formül Ekle";
            this.btnFormulEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormulEkle.Textcolor = System.Drawing.Color.White;
            this.btnFormulEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormullerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(198, 800);
            this.Controls.Add(this.btnFormulEkle);
            this.Controls.Add(this.btnFormuller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormullerMenuForm";
            this.Text = "FormullerMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuFlatButton btnFormuller;
        private ns1.BunifuFlatButton btnFormulEkle;
    }
}