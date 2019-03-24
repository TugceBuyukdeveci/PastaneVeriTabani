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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet18.ALINANMALLAR' table. You can move, or remove it, as needed.
            this.aLINANMALLARTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet18.ALINANMALLAR);

        }
        void doldur()
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            dataGridView4.DataSource = db.ALINANMALLAR.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 dp = new PASTANEİSLETMECİLİĞİEntities3();
            ALINANMALLAR yeni = new ALINANMALLAR();
            yeni.Alinanmal_Ad= textBox1.Text;
            yeni.Alinanmal_Mik = Convert.ToInt32(textBox2.Text);
            yeni.Alinanmal_Tarih = Convert.ToDateTime(textBox3.Text);
            yeni.Alinanmal_SKT =Convert.ToDateTime( textBox4.Text);
            dp.ALINANMALLAR.Add(yeni);
            dp.SaveChanges();
            doldur();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            ALINANMALLAR yeni = new ALINANMALLAR();
            var guncelle = Convert.ToInt32(textBox5.Text);
            var guncellenecekurun = db.ALINANMALLAR.Where(w => w.Alinanmal_id == guncelle).FirstOrDefault();
            guncellenecekurun.Alinanmal_Ad = textBox6.Text;
            guncellenecekurun.Alinanmal_Mik = Convert.ToInt32( textBox7.Text);
            guncellenecekurun.Alinanmal_Tarih =Convert.ToDateTime( textBox8.Text);
            guncellenecekurun.Alinanmal_SKT =Convert.ToDateTime( textBox9.Text);
            db.SaveChanges();
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
           ALINANMALLAR yeni = new ALINANMALLAR();
            var silinicek = Convert.ToInt32(textBox10.Text);
            var silinicekurun = db.ALINANMALLAR.Where(w => w.Alinanmal_id == silinicek).FirstOrDefault();
            db.ALINANMALLAR.Remove(silinicekurun);
            db.SaveChanges();
            doldur();
        }
    }
}
