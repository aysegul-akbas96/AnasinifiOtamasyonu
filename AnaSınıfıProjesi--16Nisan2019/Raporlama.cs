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
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }
        AnaSınıfıDataContext baglanti = new AnaSınıfıDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            var artanfiyat = from Ödeme in baglanti.Ödemes 
                             join Çocuk in baglanti.Çocuks
                             on Ödeme.ÇocukID equals Çocuk.ÇocukID
                             orderby Ödeme.Tutar
                             select new
                             {
                                 Çocuk.Adı,
                                 Çocuk.Soyadı,
                               Ödeme.Tutar
                             };
            dataGridView1.DataSource = artanfiyat.ToList();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var artanfiyat = from Ödeme in baglanti.Ödemes
                             join Çocuk in baglanti.Çocuks
                             on Ödeme.ÇocukID equals Çocuk.ÇocukID
                             orderby Ödeme.Tutar descending
                             select new
                             {
                                 Çocuk.Adı,
                                 Çocuk.Soyadı,
                                 Ödeme.Tutar
                             };
            dataGridView1.DataSource = artanfiyat.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tutar = from Ödeme in baglanti.Ödemes
                        join Çocuk in baglanti.Çocuks
                        on Ödeme.ÇocukID equals Çocuk.ÇocukID
                        group Ödeme by Çocuk.Adı
                    into Toplamaİslemleri //group by çalıştırmak için kullanılan isim. Verilmek zorunda group by temsit etmek için
                        select new
                        {
                            Ödeme = Toplamaİslemleri.Key,//key anahtar işlemadı bizim anahtarımız oldu..
                            totaltutar = Toplamaİslemleri.Sum(topla => topla.Tutar)
                        };
            dataGridView1.DataSource = tutar.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var secim = from Proje in baglanti.Projes
                        join Şube in baglanti.Şubes
                      on Proje.ÇocukID equals Şube.ÇocukID
                        join Çocuk in baglanti.Çocuks
                        on Proje.ÇocukID equals Çocuk.ÇocukID
                       select new
                        {
                           Çocuk.Adı,
                           Çocuk.Soyadı,
                           Proje.ProjeAdı,
                           Proje.ProjeKonusu,
                           Şube.ŞubeAdı 

                        };
            dataGridView1.DataSource = secim.ToList();
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var bul = from Hocalar in baglanti.Hocalars
                      join Görevlendirme in baglanti.Görevlendirmes
                      on Hocalar.GörevID equals Görevlendirme.GörevID
                      select new
                      {
                          Hocalar.HocaAdıSoyadı,
                          Görevlendirme.GörevAdı,
                          Görevlendirme.GörevYeri
                      };
            dataGridView1.DataSource = bul.ToList();
        }
    }
}
