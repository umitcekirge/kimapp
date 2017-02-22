using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace kimapp
{
    public partial class Logincs : Form
    {
        public AlertMessageForm alertmsc = new AlertMessageForm();
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
        public Logincs()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Logincs_Load(object sender, EventArgs e)
        {
            pnlLogo.Select();
            if (txtKullaniciSifresi.Text == "Kullanıcı Şifresi")
            {
                txtKullaniciSifresi.isPassword = false;
            }
            if (txtVeritabaniSifresi.Text == "Veritabanı Şifresi")
            {
                txtVeritabaniSifresi.isPassword = false;
            }
        }


        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtKullaniciAdi.Text=="Kullanıcı Adı" || txtKullaniciSifresi.Text == "" || txtKullaniciSifresi.Text == "Kullanıcı Şifresi" || txtVeritabaniSifresi.Text == "" || txtVeritabaniSifresi.Text == "Veritabanı Şifresi")
            {
                alertmsc.AlertMessageFunc(2, "Hata!", "Lütfen gerekli alanları boş bırakmayınız.");

            }
            else
            {
                try
                {
                    OleDbConnection baglanti = new OleDbConnection();
                    baglanti.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db/veritabani.accdb;Jet OLEDB:Database Password =" + txtVeritabaniSifresi.Text + ";");
                    baglanti.Open();
                    String sorgu = "SELECT * FROM kullanicilar WHERE kadi=@kadi AND sifre=@sifre";
                    OleDbCommand cmd = new OleDbCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtKullaniciSifresi.Text);
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Form1 mainform = new Form1();
                        mainform.Show();
                        this.Visible = false;
                        DbConnect.DbPassword = txtVeritabaniSifresi.Text;
                    }
                    else
                    {
                        alertmsc.AlertMessageFunc(3, "Hatalı Bilgiler!", "Lütfen doğru kullanıcı ve şifrenizle giriş yapınız.");
                    }
                }
                catch (Exception ex)
                {

                    alertmsc.AlertMessageFunc(3, "Hata!", ex.Message);
                }
            }


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);

        }


        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı Adı")
            {
                txtKullaniciAdi.Text = "";
            }
        }

        private void txtKullaniciSifresi_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciSifresi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciSifresi.Text == "Kullanıcı Şifresi")
            {
                txtKullaniciSifresi.Text = "";
            }
        }

        private void txtVeritabaniSifresi_Enter(object sender, EventArgs e)
        {
            if (txtVeritabaniSifresi.Text == "Veritabanı Şifresi")
            {
                txtVeritabaniSifresi.Text = "";
            }
        }

        private void txtKullaniciSifresi_OnValueChanged_1(object sender, EventArgs e)
        {
            if (txtKullaniciSifresi.Text != "Kullanıcı Şifresi")
            {
                txtKullaniciSifresi.isPassword = true;
            }
        }

        private void txtVeritabaniSifresi_OnValueChanged(object sender, EventArgs e)
        {
            if (txtVeritabaniSifresi.Text != "Veritabanı Şifresi")
            {
                txtVeritabaniSifresi.isPassword = true;
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "Kullanıcı Adı";
            }
        }

        private void txtKullaniciSifresi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciSifresi.Text == "")
            {
                txtKullaniciSifresi.Text = "Kullanıcı Şifresi";
                txtKullaniciSifresi.isPassword = false;
            }
        }

        private void txtVeritabaniSifresi_Leave(object sender, EventArgs e)
        {
            if (txtVeritabaniSifresi.Text == "")
            {
                txtVeritabaniSifresi.Text = "Veritabanı Şifresi";
                txtVeritabaniSifresi.isPassword = false;
            }
        }
    }
}
