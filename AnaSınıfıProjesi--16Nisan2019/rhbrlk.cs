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
    public partial class rhbrlk : Form
    {
        public rhbrlk()
        {
            InitializeComponent();
        }
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Rehberliks.ToList();
        }

        private void rhbrlk_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            comboBox2.DataSource = baglanti.Çocuks.ToList();
            comboBox2.DisplayMember = "Adı";
            comboBox2.ValueMember = "ÇocukID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            int id =Convert.ToInt32(textBox3.Text);
            var arama = baglanti.Rehberliks.Where(p => p.RehberlikID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox5.Text = satır.Cells["RehberlikID"].Value.ToString();
            textBox1.Text = satır.Cells["RehberlikDurumu"].Value.ToString(); 
            textBox2.Text = satır.Cells["Tespit"].Value.ToString();
            textBox4.Text = satır.Cells["Açıklama"].Value.ToString();
            comboBox2.SelectedIndex = Convert.ToInt32(satır.Cells["ÇocukID"].Value) - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rehberlik ekle = new Rehberlik();
            ekle.RehberlikDurumu = textBox1.Text.ToString();
            ekle.Tespit = textBox2.Text.ToString();
            ekle.Açıklama = textBox4.Text.ToString();
          ekle.ÇocukID = comboBox2.SelectedIndex + 1;
            baglanti.Rehberliks.InsertOnSubmit(ekle);
            baglanti.SubmitChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            Rehberlik sil = baglanti.Rehberliks.SingleOrDefault(kaybol => kaybol.RehberlikID == id);
            baglanti.Rehberliks.DeleteOnSubmit(sil);
            baglanti.SubmitChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            Rehberlik yenile = baglanti.Rehberliks.SingleOrDefault(y => y.RehberlikID == id);
            yenile.RehberlikDurumu = textBox1.Text;
            yenile.Tespit = textBox2.Text;
            yenile.Açıklama = textBox4.Text;
            yenile.ÇocukID = comboBox2.SelectedIndex + 1;

            baglanti.SubmitChanges();
            dataGridView1.DataSource = baglanti.Rehberliks.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
    }
}
