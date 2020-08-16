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
    public partial class Öğretmen : Form
    {
        public Öğretmen()
        {
            InitializeComponent();
        }

        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Hocalars.ToList();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void Öğretmen_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;


            comboBox3.DataSource = baglanti.Çocuks.ToList();
            comboBox3.DisplayMember = "ÇocukAdı";
            comboBox3.ValueMember = "ÇocukID";

            comboBox2.DataSource = baglanti.Birims.ToList();
            comboBox2.DisplayMember = "BirimAdı";
            comboBox2.ValueMember = "BirimID";

            comboBox4.DataSource = baglanti.Görevlendirmes.ToList();
            comboBox4.DisplayMember = "GörevAdı";
            comboBox4.ValueMember = "GörevID";

            comboBox5.DataSource = baglanti.Şubes.ToList();
            comboBox5.DisplayMember = "ŞubeAdı";
            comboBox5.ValueMember = "ŞubeID";

            comboBox6.DataSource = baglanti.Projes.ToList();
            comboBox6.DisplayMember = "ProjeAdı";
            comboBox6.ValueMember = "ProjeID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hocalar ekle = new Hocalar();
            ekle.HocaAdıSoyadı = textBox1.Text.ToString();
            ekle.ÇocukID = comboBox3.SelectedIndex + 1;
            ekle.BirimID = comboBox2.SelectedIndex + 1;
            ekle.GörevID = comboBox4.SelectedIndex + 1;
            ekle.ŞubeID = comboBox5.SelectedIndex + 1;
            ekle.ProjeID = comboBox6.SelectedIndex +1;

            
            baglanti.Hocalars.InsertOnSubmit(ekle);
            baglanti.SubmitChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["HocaAdıSoyadı"].Value.ToString();
            textBox1.Tag = satır.Cells["HocaID"].Value;
            comboBox3.SelectedIndex = Convert.ToInt32(satır.Cells["ÇocukID"].Value) - 1;
            comboBox2.SelectedIndex = Convert.ToInt32(satır.Cells["BirimID"].Value) - 1;
            comboBox4.SelectedIndex = Convert.ToInt32(satır.Cells["GörevID"].Value) - 1;
            comboBox5.SelectedIndex = Convert.ToInt32(satır.Cells["ŞubeID"].Value) - 1;
            comboBox6.SelectedIndex = Convert.ToInt32(satır.Cells["ProjeID"].Value) - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)textBox1.Tag;
            Hocalar sil = baglanti.Hocalars.SingleOrDefault(kaybol => kaybol.HocaID == id);
            baglanti.Hocalars.DeleteOnSubmit(sil);
            baglanti.SubmitChanges();
            Listele();
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

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
            var arama = baglanti.Hocalars.Where(p => p.HocaID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            Hocalar yenile = baglanti.Hocalars.SingleOrDefault(y => y.HocaID == id);
            yenile.ÇocukID = comboBox3.SelectedIndex + 1;
            yenile.BirimID = comboBox2.SelectedIndex + 1;
            yenile.GörevID = comboBox4.SelectedIndex + 1;
            yenile.ŞubeID = comboBox5.SelectedIndex + 1;
            yenile.ProjeID = comboBox6.SelectedIndex + 1;
            baglanti.SubmitChanges();
            dataGridView1.DataSource = baglanti.Hocalars.ToList();
        }
    }
}
