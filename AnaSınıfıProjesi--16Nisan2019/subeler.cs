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
    public partial class subeler : Form
    {
        public subeler()
        {
            InitializeComponent();
        }
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Şubes.ToList();
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

        private void subeler_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            comboBox3.DataSource = baglanti.Birims.ToList();
            comboBox3.DisplayMember = "BirimAdı";
            comboBox3.ValueMember = "BirimID";

            comboBox4.DataSource = baglanti.Çocuks.ToList();
            comboBox4.DisplayMember = "Adı";
            comboBox4.ValueMember = "ÇocukID";
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
            textBox1.Text = satır.Cells["ŞubeAdı"].Value.ToString();
            textBox1.Tag = satır.Cells["ŞubeID"].Value;
            comboBox3.SelectedIndex = Convert.ToInt32(satır.Cells["BirimID"].Value) - 1;
            comboBox4.SelectedIndex = Convert.ToInt32(satır.Cells["ÇocukID"].Value) - 1;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            Şube yenile = baglanti.Şubes.SingleOrDefault(y => y.ŞubeID == id);
            yenile.ŞubeAdı = textBox1.Text;
            yenile.BirimID = comboBox3.SelectedIndex + 1;
            yenile.ÇocukID = comboBox4.SelectedIndex + 1;

            baglanti.SubmitChanges();
            dataGridView1.DataSource = baglanti.Şubes.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Şube ekle = new Şube();
            ekle.ŞubeAdı = textBox1.Text.ToString();
            ekle.BirimID = comboBox3.SelectedIndex + 1;

            ekle.ÇocukID = comboBox4.SelectedIndex + 1;
            baglanti.Şubes.InsertOnSubmit(ekle);
            baglanti.SubmitChanges();
            Listele();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)textBox1.Tag;
          Şube sil = baglanti.Şubes.SingleOrDefault(kaybol => kaybol.ŞubeID == id);
            baglanti.Şubes.DeleteOnSubmit(sil);
            baglanti.SubmitChanges();
            Listele();
        }
    }
}
