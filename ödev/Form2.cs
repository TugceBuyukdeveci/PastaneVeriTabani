using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet16.CALISANLAR' table. You can move, or remove it, as needed.
            this.cALISANLARTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet16.CALISANLAR);

        }

        void doldur()
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            dataGridView2.DataSource = db.CALISANLAR.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 dp = new PASTANEİSLETMECİLİĞİEntities3();
            CALISANLAR yeni = new CALISANLAR();
            yeni.Calisan_Ad = textBox1.Text;
            yeni.Calisan_Soyad = textBox2.Text;
            yeni.Calisan_Cep_Tel = textBox3.Text;
            yeni.Calisan_Mail = textBox4.Text;
            dp.CALISANLAR.Add(yeni);
            dp.SaveChanges();
            doldur();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            CALISANLAR yeni = new CALISANLAR();
            var silinicek = Convert.ToInt32(textBox5.Text);
            var silinicekurun = db.CALISANLAR.Where(w => w.Calisan_id == silinicek).FirstOrDefault();
            db.CALISANLAR.Remove(silinicekurun);
            db.SaveChanges();
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            CALISANLAR yeni = new CALISANLAR();
            var guncelle = Convert.ToInt32(textBox6.Text);
            var guncellenecekurun = db.CALISANLAR.Where(w => w.Calisan_id == guncelle).FirstOrDefault();
            guncellenecekurun.Calisan_Ad = textBox7.Text;
            guncellenecekurun.Calisan_Soyad = textBox8.Text;
            guncellenecekurun.Calisan_Cep_Tel = textBox9.Text;
            guncellenecekurun.Calisan_Mail = textBox10.Text;
            db.SaveChanges();
            doldur();
        }
    }
}
