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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void veliGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            veliiiler git = new veliiiler();
            git.Show();
            this.Hide();
        }

        private void kullanıcıGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama git = new Raporlama();
            git.Show();
            this.Hide();
        }
    }
}
