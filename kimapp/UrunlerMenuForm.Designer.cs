namespace kimapp
{
    partial class UrunlerMenuForm
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
            this.btnUrunler = new ns1.BunifuFlatButton();
            this.btnUrunEkle = new ns1.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUrunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnUrunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunler.BorderRadius = 5;
            this.btnUrunler.ButtonText = "Ürünler";
            this.btnUrunler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunler.DisabledColor = System.Drawing.Color.Gray;
            this.btnUrunler.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUrunler.Iconimage = null;
            this.btnUrunler.Iconimage_right = null;
            this.btnUrunler.Iconimage_right_Selected = null;
            this.btnUrunler.Iconimage_Selected = null;
            this.btnUrunler.IconMarginLeft = 0;
            this.btnUrunler.IconMarginRight = 0;
            this.btnUrunler.IconRightVisible = true;
            this.btnUrunler.IconRightZoom = 0D;
            this.btnUrunler.IconVisible = true;
            this.btnUrunler.IconZoom = 90D;
            this.btnUrunler.IsTab = false;
            this.btnUrunler.Location = new System.Drawing.Point(12, 29);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnUrunler.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUrunler.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUrunler.selected = false;
            this.btnUrunler.Size = new System.Drawing.Size(174, 39);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunler.Textcolor = System.Drawing.Color.White;
            this.btnUrunler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrunEkle.BorderRadius = 5;
            this.btnUrunEkle.ButtonText = "Ürün Ekle";
            this.btnUrunEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnUrunEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUrunEkle.Iconimage = null;
            this.btnUrunEkle.Iconimage_right = null;
            this.btnUrunEkle.Iconimage_right_Selected = null;
            this.btnUrunEkle.Iconimage_Selected = null;
            this.btnUrunEkle.IconMarginLeft = 0;
            this.btnUrunEkle.IconMarginRight = 0;
            this.btnUrunEkle.IconRightVisible = true;
            this.btnUrunEkle.IconRightZoom = 0D;
            this.btnUrunEkle.IconVisible = true;
            this.btnUrunEkle.IconZoom = 90D;
            this.btnUrunEkle.IsTab = false;
            this.btnUrunEkle.Location = new System.Drawing.Point(12, 74);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.btnUrunEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUrunEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUrunEkle.selected = false;
            this.btnUrunEkle.Size = new System.Drawing.Size(174, 39);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunEkle.Textcolor = System.Drawing.Color.White;
            this.btnUrunEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UrunlerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(198, 800);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunlerMenuForm";
            this.Text = "UrunlerForm";
            this.Load += new System.EventHandler(this.UrunlerMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuFlatButton btnUrunler;
        private ns1.BunifuFlatButton btnUrunEkle;
    }
}