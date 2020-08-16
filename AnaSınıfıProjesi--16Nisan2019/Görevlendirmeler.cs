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
    public partial class Görevlendirmeler : Form
    {
        public Görevlendirmeler()
        {
            InitializeComponent();
        }
      
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        public void  Listele()
        {
            dataGridView1.DataSource = baglanti.Görevlendirmes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Görevlendirmeler_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["GörevAdı"].Value.ToString();
            textBox1.Tag = satır.Cells["GörevID"].Value;
            textBox2.Text = satır.Cells["GörevYeri"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Görevlendirme ekle = new Görevlendirme();
            ekle.GörevAdı = textBox1.Text.ToString();
            ekle.GörevYeri = textBox2.Text.ToString();
            baglanti.Görevlendirmes.InsertOnSubmit(ekle);
            baglanti.SubmitChanges();
            Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = (int)textBox1.Tag;
           Görevlendirme sil = baglanti.Görevlendirmes.SingleOrDefault(kaybol => kaybol.GörevID == id);
            baglanti.Görevlendirmes.DeleteOnSubmit(sil);
            baglanti.SubmitChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int id = (int)textBox1.Tag;
            Görevlendirme yenile = baglanti.Görevlendirmes.SingleOrDefault(kaybol => kaybol.GörevID == id);
            yenile.GörevAdı = textBox1.Text.ToString();
            yenile.GörevYeri = textBox2.Text.ToString();
          
            baglanti.SubmitChanges();
            Listele();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
            var arama = baglanti.Görevlendirmes.Where(p => p.GörevID == id);
            dataGridView1.DataSource = arama.ToList();
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
    }
}
