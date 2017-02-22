using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimapp
{
    public partial class Form1 : Form
    {
        public AlertMessageForm alertmsc = new AlertMessageForm();
        int TogMove, MValX, MValY;
        public Form1()
        {
            InitializeComponent();
            pnlSubMenu.Visible = false;
        }

        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1; MValX = e.X; MValY = e.Y;
        }

        private void pnlMove_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;

        }

        private void pnlMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btnAnasayfaForm_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = false;
            btnAnasayfaForm.color = Color.FromArgb(234, 90, 90);

            btnUrunler.color = Color.Transparent;
            btnFormuller.color = Color.Transparent;

            btnAnasayfaForm.Image = Image.FromFile(@"icons\home-beyaz.png");
            btnUrunler.Image = Image.FromFile(@"icons\barcode-gri.png");
            btnFormuller.Image = Image.FromFile(@"icons\atom-gri.png");
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = true;
            btnUrunler.color = Color.FromArgb(234, 90, 90);

            btnAnasayfaForm.color = Color.Transparent;
            btnFormuller.color = Color.Transparent;

            btnUrunler.Image = Image.FromFile(@"icons\barcode-beyaz.png");
            btnAnasayfaForm.Image = Image.FromFile(@"icons\home-gri.png");
            btnFormuller.Image = Image.FromFile(@"icons\atom-gri.png");

            pnlSubMenu.Controls.Clear();
            UrunlerMenuForm newForm = new UrunlerMenuForm();
            newForm.TopLevel = false;
            pnlSubMenu.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Top;
            newForm.BringToFront();
        }

        private void btnFormuller_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = true;
            btnFormuller.color = Color.FromArgb(234, 90, 90);
            btnUrunler.color = Color.Transparent;
            btnAnasayfaForm.color = Color.Transparent;

            pnlSubMenu.Controls.Clear();
            FormullerMenuForm newForm = new FormullerMenuForm();
            newForm.TopLevel = false;
            pnlSubMenu.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Top;
            newForm.BringToFront();

            btnFormuller.Image = Image.FromFile(@"icons\atom-beyaz.png");
            btnAnasayfaForm.Image = Image.FromFile(@"icons\home-gri.png");
            btnUrunler.Image = Image.FromFile(@"icons\barcode-gri.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alertmsc.AlertMessageFunc(3,"Test", "Merhaba");
        }

        private void pnlSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
