namespace kimapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFormuller = new ns1.BunifuTileButton();
            this.btnUrunler = new ns1.BunifuTileButton();
            this.btnAnasayfaForm = new ns1.BunifuTileButton();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnExit = new ns1.BunifuImageButton();
            this.btnMinimize = new ns1.BunifuImageButton();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.btnFormuller);
            this.panel1.Controls.Add(this.btnUrunler);
            this.panel1.Controls.Add(this.btnAnasayfaForm);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 800);
            this.panel1.TabIndex = 0;
            // 
            // btnFormuller
            // 
            this.btnFormuller.BackColor = System.Drawing.Color.Transparent;
            this.btnFormuller.color = System.Drawing.Color.Transparent;
            this.btnFormuller.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnFormuller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormuller.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuller.ForeColor = System.Drawing.Color.White;
            this.btnFormuller.Image = ((System.Drawing.Image)(resources.GetObject("btnFormuller.Image")));
            this.btnFormuller.ImagePosition = 15;
            this.btnFormuller.ImageZoom = 50;
            this.btnFormuller.LabelPosition = 25;
            this.btnFormuller.LabelText = "Formüller";
            this.btnFormuller.Location = new System.Drawing.Point(0, 198);
            this.btnFormuller.Margin = new System.Windows.Forms.Padding(5);
            this.btnFormuller.Name = "btnFormuller";
            this.btnFormuller.Size = new System.Drawing.Size(100, 100);
            this.btnFormuller.TabIndex = 0;
            this.btnFormuller.Click += new System.EventHandler(this.btnFormuller_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunler.color = System.Drawing.Color.Transparent;
            this.btnUrunler.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnUrunler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrunler.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ForeColor = System.Drawing.Color.White;
            this.btnUrunler.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.Image")));
            this.btnUrunler.ImagePosition = 15;
            this.btnUrunler.ImageZoom = 50;
            this.btnUrunler.LabelPosition = 25;
            this.btnUrunler.LabelText = "Ürünler";
            this.btnUrunler.Location = new System.Drawing.Point(0, 98);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(5);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(100, 100);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnAnasayfaForm
            // 
            this.btnAnasayfaForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAnasayfaForm.color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAnasayfaForm.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAnasayfaForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnasayfaForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfaForm.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfaForm.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfaForm.Image")));
            this.btnAnasayfaForm.ImagePosition = 15;
            this.btnAnasayfaForm.ImageZoom = 50;
            this.btnAnasayfaForm.LabelPosition = 25;
            this.btnAnasayfaForm.LabelText = "Anasayfa";
            this.btnAnasayfaForm.Location = new System.Drawing.Point(0, 0);
            this.btnAnasayfaForm.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnasayfaForm.Name = "btnAnasayfaForm";
            this.btnAnasayfaForm.Size = new System.Drawing.Size(100, 100);
            this.btnAnasayfaForm.TabIndex = 0;
            this.btnAnasayfaForm.Click += new System.EventHandler(this.btnAnasayfaForm_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlSubMenu.Location = new System.Drawing.Point(96, 0);
            this.pnlSubMenu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(198, 800);
            this.pnlSubMenu.TabIndex = 1;
            this.pnlSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSubMenu_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1214, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1160, 29);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlMove.Location = new System.Drawing.Point(96, 0);
            this.pnlMove.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(1185, 10);
            this.pnlMove.TabIndex = 4;
            this.pnlMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            this.pnlMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseMove);
            this.pnlMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSubMenu;
        private ns1.BunifuTileButton btnAnasayfaForm;
        private ns1.BunifuTileButton btnFormuller;
        private ns1.BunifuTileButton btnUrunler;
        private ns1.BunifuImageButton btnExit;
        private ns1.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button button1;
    }
}

