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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet23.CALISANLAR' table. You can move, or remove it, as needed.
            this.cALISANLARTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet23.CALISANLAR);
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet22.MASALAR' table. You can move, or remove it, as needed.
            this.mASALARTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet22.MASALAR);
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet20.URUNLER' table. You can move, or remove it, as needed.
            this.uRUNLERTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet20.URUNLER);
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet19.SIPARISLER' table. You can move, or remove it, as needed.
            this.sIPARISLERTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet19.SIPARISLER);

        }
        void doldur()
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            dataGridView5.DataSource = db.SIPARISLER.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 dp = new PASTANEİSLETMECİLİĞİEntities3();
            SIPARISLER yeni = new SIPARISLER();
            yeni.Siparis_ad = textBox1.Text;
            yeni.Siparis_Tarih= Convert.ToDateTime(textBox2.Text);
            yeni.Urün_id =Convert.ToInt32( comboBox1.Text);
            yeni.Masa_id = Convert.ToInt32(comboBox2.Text);
            yeni.Calisan_id = Convert.ToInt32(comboBox3.Text);
            dp.SIPARISLER.Add(yeni);
            dp.SaveChanges();
            doldur();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
           SIPARISLER yeni = new SIPARISLER();
            var guncelle = Convert.ToInt32(textBox3.Text);
            var guncellenecekurun = db.SIPARISLER.Where(w => w.Siparis_id == guncelle).FirstOrDefault();
            guncellenecekurun.Siparis_ad=textBox4.Text;
            guncellenecekurun.Siparis_Tarih = Convert.ToDateTime(textBox5.Text);
            guncellenecekurun.Urün_id = Convert.ToInt32(comboBox4.Text);
            guncellenecekurun.Masa_id = Convert.ToInt32(comboBox5.Text);
            guncellenecekurun.Calisan_id = Convert.ToInt32(comboBox6.Text);
            db.SaveChanges();
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            SIPARISLER yeni = new SIPARISLER();
            var silinicek = Convert.ToInt32(textBox6.Text);
            var silinicekurun = db.SIPARISLER.Where(w => w.Siparis_id == silinicek).FirstOrDefault();
            db.SIPARISLER.Remove(silinicekurun);
            db.SaveChanges();
            doldur();
        }
    }
}
