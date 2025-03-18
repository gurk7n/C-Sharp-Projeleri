using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeTahmin
{
    public partial class Form1 : Form
    {
        private string turkceKelime;
        private string ingilizceKelime;
        private string dogruKelime;
        private int puan = 0;
        public Form1()
        {
            InitializeComponent();
            textBoxDene.MaxLength = 1;
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonTahmin_Click(object sender, EventArgs e)
        {
            if (textBoxTahmin.Text == dogruKelime)
            {
                puan++;
                labelPuan.Text = "Puan: " + puan.ToString();
                labelKelime.Text = dogruKelime;
                MessageBox.Show("Tebrikler, doğru tahmin ettiniz!");
            }
            else
            {
                MessageBox.Show("Maalesef, yanlış tahmin ettiniz!");
            }
        }

        private void buttonDene_Click(object sender, EventArgs e)
        {
            string girilenHarf = textBoxDene.Text.ToLower();
            if (girilenHarf.Length == 1 && char.IsLetter(girilenHarf[0]))
            {
                string kelimeyiTahminEt = labelKelime.Text;

                if (dogruKelime.ToLower().Contains(girilenHarf))
                {
                    char[] kelimeDizisi = kelimeyiTahminEt.ToCharArray();
                    for (int i = 0; i < dogruKelime.Length; i++)
                    {
                        if (dogruKelime[i].ToString().ToLower() == girilenHarf)
                        {
                            kelimeDizisi[i] = dogruKelime[i];
                        }
                    }

                    labelKelime.Text = new string(kelimeDizisi);
                    if (!labelKelime.Text.Contains('*'))
                    {
                        puan++;
                        labelPuan.Text = "Puan: " + puan.ToString();
                        MessageBox.Show("Tebrikler, doğru tahmin ettiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Harf kelimede yok!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir harf girin.");
            }

            textBoxDene.Clear();
        }

        private void buttonKelime_Click(object sender, EventArgs e)
        {

            string bag = @"Server=localhost\SQLEXPRESS01;Database=kelimeTahmin;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            string sql = "select * from kelimeler";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Random rnd = new Random();

                int index;

                do
                {
                    index = rnd.Next(dt.Rows.Count);
                    turkceKelime = dt.Rows[index]["tr"].ToString();
                    ingilizceKelime = dt.Rows[index]["en"].ToString();
                }
                while (labelKelime.Text == turkceKelime || labelKelime.Text == ingilizceKelime);

                if (checkBoxIngilizce.Checked)
                {
                    dogruKelime = ingilizceKelime;
                    string yildizliKelime = new string('*', ingilizceKelime.Length);
                    labelKelime.Text = yildizliKelime;
                }
                else
                {
                    dogruKelime = turkceKelime;
                    string yildizliKelime = new string('*', turkceKelime.Length);
                    labelKelime.Text = yildizliKelime;
                }



            }
        }
    }
}
