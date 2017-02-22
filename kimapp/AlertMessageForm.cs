using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace kimapp
{
    public partial class AlertMessageForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public AlertMessageForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
        public void AlertMessageFunc(int alert, string MessageTitle, string Message)
        {
            AlertMessageForm altermessage = new AlertMessageForm();
            if (alert == 0)
            {
                altermessage.Controls["panel1"].BackColor = Color.FromArgb(114, 181, 95);
                altermessage.Controls["panel1"].BackgroundImage = Image.FromFile(@"icons\success.png");
                altermessage.Controls["pnl2"].BackColor = Color.FromArgb(114, 181, 95);
                altermessage.Controls["lblMessagetitle"].ForeColor = Color.FromArgb(114, 181, 95);
            }
            else if (alert == 1)
            {
                altermessage.Controls["panel1"].BackColor = Color.FromArgb(35, 184, 175);
                altermessage.Controls["panel1"].BackgroundImage = Image.FromFile(@"icons\information.png");
                altermessage.Controls["pnl2"].BackColor = Color.FromArgb(35, 184, 175);
                altermessage.Controls["lblMessagetitle"].ForeColor = Color.FromArgb(35, 184, 175);
            }
            else if (alert == 2)
            {
                altermessage.Controls["panel1"].BackColor = Color.FromArgb(245, 130, 41);
                altermessage.Controls["panel1"].BackgroundImage = Image.FromFile(@"icons\warning.png");
                altermessage.Controls["pnl2"].BackColor = Color.FromArgb(245, 130, 41);
                altermessage.Controls["lblMessagetitle"].ForeColor = Color.FromArgb(245, 130, 41);
            }
            else if (alert == 3)
            {
                altermessage.Controls["panel1"].BackColor = Color.FromArgb(246, 43, 43);
                altermessage.Controls["panel1"].BackgroundImage = Image.FromFile(@"icons\error.png");
                altermessage.Controls["pnl2"].BackColor = Color.FromArgb(246, 43, 43);
                altermessage.Controls["lblMessagetitle"].ForeColor = Color.FromArgb(246, 43, 43);
            }
            altermessage.Controls["lblMessagetitle"].Text = MessageTitle;
            altermessage.Controls["lblAlertMessage"].Text = Message;
            altermessage.ShowDialog();
        }
        private void AlertMessageForm_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
