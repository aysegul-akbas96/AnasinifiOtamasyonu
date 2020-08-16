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
    public partial class Projeler : Form
    {
        public Projeler()
        {
            InitializeComponent();
        }
        
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();

        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Projes.ToList();
        }
        private void Projeler_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            comboBox2.DataSource = baglanti.Çocuks.ToList();
            comboBox2.DisplayMember = "Adı";
            comboBox2.ValueMember = "ÇocukID";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
            var arama = baglanti.Şubes.Where(p => p.ŞubeID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["ProjeAdı"].Value.ToString();
            textBox1.Tag = satır.Cells["ProjeID"].Value;
            textBox2.Text = satır.Cells["KatıldığıŞehir"].Value.ToString();
            textBox4.Text = satır.Cells["ProjeKonusu"].Value.ToString();
            comboBox2.SelectedIndex = Convert.ToInt32(satır.Cells["ÇocukID"].Value) - 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proje ekle = new Proje();
            ekle.ProjeAdı = textBox1.Text.ToString();
            ekle.KatıldığıŞehir = textBox2.Text.ToString();
            ekle.ProjeKonusu = textBox4.Text.ToString();

            ekle.ÇocukID = comboBox2.SelectedIndex + 1;
            baglanti.Projes.InsertOnSubmit(ekle);
            baglanti.SubmitChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)textBox1.Tag;
            Proje sil = baglanti.Projes.SingleOrDefault(kaybol => kaybol.ProjeID == id);
            baglanti.Projes.DeleteOnSubmit(sil);
            baglanti.SubmitChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Tag);
            Proje yenile = baglanti.Projes.SingleOrDefault(y => y.ProjeID == id);
            yenile.ProjeAdı = textBox1.Text.ToString();
            yenile.KatıldığıŞehir = textBox2.Text.ToString();
            yenile.ProjeKonusu = textBox4.Text.ToString();

            yenile.ÇocukID = comboBox2.SelectedIndex + 1;
            

            baglanti.SubmitChanges();
            dataGridView1.DataSource = baglanti.Projes.ToList();
        }
    }
}
