using StarCinema.BL;
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
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }
        private void btnFilmEkle_Click(object sender, EventArgs e)
        {

            FrmFilm frm = new FrmFilm()
            {
                Text = "Film Ekle",
                Film = new Film() { ID = Guid.NewGuid() }
            };
        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.FilmEkle(frm.Film);
                if (b)
                {

                    DataSet ds = BLogic.FilmGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;

            }
        }

        private void btnFilmBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.FilmGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnFilmDüzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0];
            //DataGridViewRow row = dataGridView2.SelectedRows[0];


            FrmFilm frm = new FrmFilm()
            {
                Text = "Film Güncele",
                Güncelleme = true,
                Film = new Film()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),
                    Tur = row.Cells[2].Value.ToString(),
                    Sure = row.Cells[3].Value.ToString(),
                    Yoneten = row.Cells[4].Value.ToString(),
                    YapimYili = row.Cells[5].Value.ToString(),
                },


            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.FilmGüncele(frm.Film);
                if (b)
                {
                    row.Cells[1].Value = frm.Film.AD;
                    row.Cells[2].Value = frm.Film.Tur;
                    row.Cells[3].Value = frm.Film.Sure;
                    row.Cells[4].Value = frm.Film.Yoneten;
                    row.Cells[5].Value = frm.Film.YapimYili;

                }

            }
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Delete the selected record?", "confirm deletion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.FilmSil(ID);
                if (b)
                {

                    DataSet ds = BLogic.FilmGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
            }
        }

        private void Filmler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.FilmGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

      public Film Film { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
         
                Film = new Film()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),
                    Tur = row.Cells[2].Value.ToString(),
                    Sure = row.Cells[3].Value.ToString(),
                    Yoneten = row.Cells[4].Value.ToString(),
                    YapimYili = row.Cells[5].Value.ToString(),
               


                 };
        DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }
    }
}
