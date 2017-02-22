namespace kimapp
{
    partial class AlertMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertMessageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessagetitle = new System.Windows.Forms.Label();
            this.lblAlertMessage = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblMessagetitle
            // 
            this.lblMessagetitle.AutoSize = true;
            this.lblMessagetitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessagetitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.lblMessagetitle.Location = new System.Drawing.Point(77, 7);
            this.lblMessagetitle.Name = "lblMessagetitle";
            this.lblMessagetitle.Size = new System.Drawing.Size(52, 20);
            this.lblMessagetitle.TabIndex = 1;
            this.lblMessagetitle.Text = "Başarılı";
            // 
            // lblAlertMessage
            // 
            this.lblAlertMessage.AutoSize = true;
            this.lblAlertMessage.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlertMessage.Location = new System.Drawing.Point(78, 34);
            this.lblAlertMessage.Name = "lblAlertMessage";
            this.lblAlertMessage.Size = new System.Drawing.Size(172, 16);
            this.lblAlertMessage.TabIndex = 2;
            this.lblAlertMessage.Text = "Ürün başarılı bir şekilde eklenmiştir.";
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(181)))), ((int)(((byte)(95)))));
            this.pnl2.Location = new System.Drawing.Point(367, -1);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(10, 60);
            this.pnl2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AlertMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 60);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.lblAlertMessage);
            this.Controls.Add(this.lblMessagetitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertMessageForm";
            this.Load += new System.EventHandler(this.AlertMessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessagetitle;
        private System.Windows.Forms.Label lblAlertMessage;
        private System.Windows.Forms.FlowLayoutPanel pnl2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}