using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaSınıfıProjesi__16Nisan2019
{
    public partial class Ödemeler : Form
    {
        public Ödemeler()
        {
            InitializeComponent();
        }
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Ödemes.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Ödemeler_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            comboBox2.DataSource = baglanti.Ödemes.ToList();
            comboBox2.ValueMember = "ÖdemeID";




            comboBox3.DataSource = baglanti.Çocuks.ToList();
            comboBox3.ValueMember = "ÇocukID";
            comboBox3.DisplayMember = "Adı";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Evet")
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                MessageBox.Show("Arama İşleminiz Tanımlanamadı...");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            comboBox2.Text = satır.Cells["ÖdemeID"].Value.ToString();
            comboBox5.Text = satır.Cells["ÖdemeTipi"].Value.ToString();
            textBox1.Text = satır.Cells["GeçerlilikDurumu"].Value.ToString();
            textBox2.Text = satır.Cells["Tutar"].Value.ToString();
            comboBox3.SelectedIndex = Convert.ToInt32(satır.Cells["ÇocukID"].Value) - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox3.Text);
            var arama = baglanti.Ödemes.Where(p => p.ÖdemeID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ödeme ekle = new Ödeme();
            ekle.ÖdemeTipi = comboBox5.SelectedItem.ToString();
            ekle.GeçerlilikDurumu = textBox1.Text;
            ekle.Tutar = Convert.ToInt32(textBox2.Text);

            ekle.ÇocukID = comboBox3.SelectedIndex + 1;
            baglanti.Ödemes.InsertOnSubmit(ekle);
            baglanti.SubmitChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            Ödeme sil = baglanti.Ödemes.SingleOrDefault(kaybol => kaybol.ÖdemeID == id);
            baglanti.Ödemes.DeleteOnSubmit(sil);
            baglanti.SubmitChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            Ödeme yenile = baglanti.Ödemes.SingleOrDefault(y => y.ÖdemeID == id);
            yenile.ÖdemeTipi = comboBox5.SelectedItem.ToString();
            yenile.GeçerlilikDurumu = textBox1.Text;
            yenile.Tutar = Convert.ToDecimal(textBox2.Text);

            yenile.ÇocukID = comboBox3.SelectedIndex + 1;
         
             baglanti.SubmitChanges();
            dataGridView1.DataSource = baglanti.Ödemes.ToList();
        }
    }
}
