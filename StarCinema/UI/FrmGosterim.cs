using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCinema.UI
{
    public partial class FrmGosterim : Form
    {
        public FrmGosterim()
        {
            InitializeComponent();
        }
       

        public Gosterim Gosterim { get; set; }
        public bool Güncelleme { get; set; } = false;



        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen fiyat giriniz!");
                nmFiyat.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }
             Gosterim.tarih = dtTarih.Value;
             Gosterim.Saat= txtSaat.Text;
             Gosterim.Salon= txtSalon.Text;
             Gosterim.koltuk= txtKoltuk.Text;
             Gosterim.Fiyat= (double)nmFiyat.Value;
             Gosterim.FilmID = Guid.Parse( txtFilmID.Text);
             Gosterim.MusteriID = Guid.Parse (txtMusteriID.Text);
             



           DialogResult = DialogResult.OK;
        }

        private void FrmGosterim_Load(object sender, EventArgs e)
        {
          txtID.Text = Gosterim.ID.ToString();
            if(Güncelleme)
            {
                txtMusteriID.Text= Gosterim.MusteriID.ToString();
                txtFilmID.Text= Gosterim.FilmID.ToString();
                txtSaat.Text= Gosterim.Saat;
                txtKoltuk.Text=Gosterim.koltuk;
                dtTarih.Value = Gosterim.tarih;
                nmFiyat.Value = (decimal)Gosterim.Fiyat;

            }
          
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if(frm.ShowDialog() == DialogResult.OK)
            {
               // Musteri =frm.Musteri;
                txtMusteriID.Text = frm.Musteri.ID.ToString();
            }
        }

        private void btnFilmSeç_Click(object sender, EventArgs e)
        {
            Filmler frm = new Filmler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Film = frm.Film;
                 txtFilmID.Text = frm.Film.ID.ToString();
                
            }
        }
    }
}
