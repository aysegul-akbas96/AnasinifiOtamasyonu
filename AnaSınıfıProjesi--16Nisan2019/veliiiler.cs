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
    public partial class veliiiler : Form
    {
        public veliiiler()
        {
            InitializeComponent();
        }
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Velis.ToList();
        }
        private void veliiiler_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = baglanti.Çocuks.ToList();
            comboBox2.DisplayMember = "Adı";
            comboBox2.ValueMember = "ÇocukID";

            comboBox3.DataSource = baglanti.Ödemes.ToList();
            comboBox3.ValueMember = "ÖdemeID";

            comboBox4.DataSource = baglanti.Projes.ToList();
            comboBox4.DisplayMember = "ProjeAdı";
            comboBox4.ValueMember = "ProjeID";

            comboBox5.DataSource = baglanti.Şubes.ToList();
            comboBox5.DisplayMember = "ŞubeAdı";
            comboBox5.ValueMember = "ŞubeID";

            comboBox6.DataSource = baglanti.Rehberliks.ToList();
            comboBox6.DisplayMember = "RehberlikDurumu";
            comboBox6.ValueMember = "RehberlikID";




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Giriş git = new Giriş();
            git.Show();
            this.Hide();
        }
    }
}
