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
    public partial class Form1 : Form
    {
        Form5 fm = new Form5();
        Form4 frmmm = new Form4();
        Form3 frmm = new Form3();
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        void doldur()
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            dataGridView1.DataSource = db.URUNLER.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet.URUNLER' table. You can move, or remove it, as needed.
            this.uRUNLERTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet.URUNLER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            URUNLER yeni = new URUNLER();
            yeni.Urun_Ad = textBox1.Text;
            db.URUNLER.Add(yeni);
            db.SaveChanges();
            doldur();
            MessageBox.Show("işlem tamam");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            URUNLER yeni = new URUNLER();
            var silinicek = Convert.ToInt32(textBox2.Text);
            var silinicekurun = db.URUNLER.Where(w => w.Urün_id == silinicek).FirstOrDefault();
            db.URUNLER.Remove(silinicekurun);
            db.SaveChanges();
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            URUNLER yeni = new URUNLER();
            var guncelle = Convert.ToInt32(textBox3.Text);
            var guncellenecekurun = db.URUNLER.Where(w => w.Urün_id == guncelle).FirstOrDefault();
            guncellenecekurun.Urun_Ad = textBox4.Text;
            db.SaveChanges();
            doldur();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                frm.Show();



            }
        }

        private void button4_Click(object sender, EventArgs e)
        { 

            frmm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmmm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fm.Show();
        }
    }
}
