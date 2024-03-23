using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamavize
{
    public partial class ana_menu : Form
    {
        public ana_menu()
        {
            InitializeComponent();
        }

        private void uyeeklemeislemi_Click(object sender, EventArgs e)
        {
            uye_ekleme form = new uye_ekleme();
            form.Show();
        }

        private void emanetislemleributonu_Click(object sender, EventArgs e)
        {
            emanet_islemleri form = new emanet_islemleri();
            form.Show();
        }

        private void kitapeklemeislemleri_Click(object sender, EventArgs e)
        {
            kitap_ekle form =new kitap_ekle();
            form.Show();
        }
    }
}
