using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarCinema.BL;
using StarCinema.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StarCinema
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SatişDetay();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];


            DataSet ds2 = BLogic.OdemeDetay();
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        Müşteriler mf =new Müşteriler();
        Filmler ff = new Filmler();




        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnFilmler_Click(object sender, EventArgs e)
        {
           ff.ShowDialog();
        }

        private void btnGosterimYap_Click(object sender, EventArgs e)
        {
            FrmGosterim frm = new FrmGosterim()
            {
                Text = "Gösterim Zamani yap",
                Gosterim = new Gosterim()
                {
                    ID =Guid.NewGuid(),

                }

            };

            

            tekrar:
                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.GösterimEkle(frm.Gosterim);

                    if (b)
                    {

                    DataSet ds1 = BLogic.SatişDetay();
                    if (ds1 != null)
                        dataGridView1.DataSource = ds1.Tables[0];

                }
                    else
                        goto tekrar;

                
                }

         }

       

        private void btnSatişDüzenle_Click(object sender, EventArgs e)
        {
          
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                FrmGosterim frm = new FrmGosterim()
                {
                    Text = "Satiş Güncele",
                    Güncelleme = true,
                    Gosterim = new Gosterim()
                    {
                        ID = Guid.Parse(row.Cells[0].Value.ToString()),
                        MusteriID =Guid.Parse (row.Cells[1].Value.ToString()),
                        FilmID =Guid.Parse( row.Cells[2].Value.ToString()),
                        Saat = row.Cells[7].Value.ToString(),
                        tarih =DateTime.Parse( row.Cells[10].Value.ToString()),
                        koltuk = row.Cells[8].Value.ToString(),
                        Fiyat =double.Parse( row.Cells[9].Value.ToString()),
                    },


                };

                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SatişGüncele(frm.Gosterim);
                    if (b)
                    {
                        row.Cells[1].Value = frm.Gosterim.MusteriID;
                        row.Cells[2].Value = frm.Gosterim.FilmID;
                        row.Cells[7].Value = frm.Gosterim.Saat;
                        row.Cells[10].Value = frm.Gosterim.tarih;
                        row.Cells[9].Value = frm.Gosterim.Fiyat;
                        row.Cells[8].Value = frm.Gosterim.koltuk;
                       

                }

                }
            }

        private void btnSatişSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Delete the selected record?", "confirm deletion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatişSil(ID);
                if (b)
                {

                    DataSet ds = BLogic.SatişDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Odeme yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid(),

                }

            };



        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(frm.Odeme);

                if (b)
                {

                    DataSet ds2 = BLogic.OdemeDetay();
                    if (ds2 != null)
                        dataGridView2.DataSource = ds2.Tables[0];

                }
                else
                    goto tekrar;


            }
        }

        private void btnoOdemeDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Odeme Güncele",
                Güncelleme = true,
                Odeme = new Odeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tutar = double.Parse(row.Cells[4].Value.ToString()),
                    tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Tur = row.Cells[5].Value.ToString(),
                    Aciklama = row.Cells[6].Value.ToString(),
                },


            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGüncele(frm.Odeme);
                if (b)
                {
                    row.Cells[1].Value = frm.Odeme.MusteriID;
                    row.Cells[4].Value = frm.Odeme.Tutar;
                    row.Cells[3].Value=frm.Odeme.tarih;
                    row.Cells[5].Value = frm.Odeme.Tur;
                    row.Cells[6].Value = frm.Odeme.Aciklama;


                }

            }
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Delete the selected record?", "confirm deletion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);
                if (b)
                {

                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
            }
        }
    }
}

