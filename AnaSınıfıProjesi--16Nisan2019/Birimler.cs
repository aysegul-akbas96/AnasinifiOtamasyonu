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
    public partial class Birimler : Form
    {
        public Birimler()
        {
            InitializeComponent();
        }
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Birims.ToList();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Birimler_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = baglanti.Birims.ToList();
            comboBox2.ValueMember = "BirimID";
            comboBox2.DisplayMember = "BirimAdı";


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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satır = dataGridView1.CurrentRow;
            comboBox2.Text = satır.Cells["BirimAdı"].Value.ToString();
            comboBox2.Tag = satır.Cells["BirimID"].Value;
        }

       
    }
}
