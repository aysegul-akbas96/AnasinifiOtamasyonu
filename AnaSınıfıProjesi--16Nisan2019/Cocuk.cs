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
    public partial class Cocuk : Form
    {
        public Cocuk()
        {
            InitializeComponent();
        }
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Çocuks.ToList();
        }
        private void Cocuk_Load(object sender, EventArgs e)
        {
            comboBox3.DataSource = baglanti.Çocuks.ToList();
            comboBox3.ValueMember = "ÇocukID";
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Çocuk ekle = new Çocuk();
            ekle.TC = Convert.ToInt32(textBox1.Text);
            ekle.Adı = textBox2.Text.ToString();
            ekle.Soyadı = textBox3.Text.ToString();
            ekle.Yaş = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            ekle.Cinsiyet = comboBox1.SelectedItem.ToString();
            baglanti.Çocuks.InsertOnSubmit(ekle);
            baglanti.SubmitChanges();
            Listele();


           
  
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = (int)comboBox3.Tag;
            Çocuk sil = baglanti.Çocuks.SingleOrDefault(kaybol => kaybol.ÇocukID == id);
            baglanti.Çocuks.DeleteOnSubmit(sil);
            baglanti.SubmitChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            comboBox3.Text = satır.Cells["ÇocukID"].Value.ToString();
            comboBox3.Tag = satır.Cells["ÇocukID"].Value;
            textBox1.Text = satır.Cells["TC"].Value.ToString();
            textBox2.Text = satır.Cells["Adı"].Value.ToString();
            textBox3.Text = satır.Cells["Soyadı"].Value.ToString();
            comboBox2.Text = satır.Cells["Yaş"].Value.ToString();
            comboBox1.Text = satır.Cells["Cinsiyet"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox3.SelectedValue);
            var arama = baglanti.Çocuks.Where(p => p.ÇocukID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox3.Tag;
            Çocuk yenile = baglanti.Çocuks.SingleOrDefault(kaybol => kaybol.ÇocukID == id);

            yenile.TC = Convert.ToInt32(textBox1.Text);
            yenile.Adı = textBox2.Text.ToString();
            yenile.Soyadı = textBox3.Text.ToString();
            yenile.Yaş = Convert.ToInt32(comboBox2.SelectedItem); 
            yenile.Cinsiyet= comboBox1.SelectedItem.ToString();



   
            baglanti.SubmitChanges();
            Listele();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
