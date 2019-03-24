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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pASTANEİSLETMECİLİĞİDataSet17.MASALAR' table. You can move, or remove it, as needed.
            this.mASALARTableAdapter.Fill(this.pASTANEİSLETMECİLİĞİDataSet17.MASALAR);

        }
        void doldur()
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            dataGridView3.DataSource = db.MASALAR.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 dp = new PASTANEİSLETMECİLİĞİEntities3();
            MASALAR yeni = new MASALAR();
            yeni.Masa_Ad = textBox1.Text;
            dp.MASALAR.Add(yeni);
            dp.SaveChanges();
            doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            MASALAR yeni = new MASALAR();
            var silinicek = Convert.ToInt32(textBox2.Text);
            var silinicekurun = db.MASALAR.Where(w => w.Masa_id == silinicek).FirstOrDefault();
            db.MASALAR.Remove(silinicekurun);
            db.SaveChanges();
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PASTANEİSLETMECİLİĞİEntities3 db = new PASTANEİSLETMECİLİĞİEntities3();
            MASALAR yeni = new MASALAR();
            var guncelle = Convert.ToInt32(textBox3.Text);
            var guncellenecekurun = db.MASALAR.Where(w => w.Masa_id== guncelle).FirstOrDefault();
            guncellenecekurun.Masa_Ad = textBox4.Text;
            db.SaveChanges();
            doldur();

        }
    }
}
