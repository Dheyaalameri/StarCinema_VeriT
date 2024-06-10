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
    public partial class FrmFilm : Form
    {
        public FrmFilm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Film Film {  get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(cbTur)) return;
            if (!ErrorControl(txtSure)) return;
            if (!ErrorControl(txtYoneten)) return;
            if (!ErrorControl(txtYapimYili)) return;

            Film.AD= txtAd.Text;
            Film.Tur=cbTur.Text;
            Film.Sure = txtSure.Text;
            Film.Yoneten= txtYoneten.Text;
            Film.YapimYili= txtYapimYili.Text;
        

            DialogResult = DialogResult.OK;

        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            return true;

        }

        private void FrmFilm_Load(object sender, EventArgs e)
        {
            txtID.Text=Film.ID.ToString();
            if(Güncelleme)
            {
              txtAd.Text = Film.AD ; 
               cbTur.Text = Film.Tur ;
              txtSure.Text =  Film.Sure; 
               txtYoneten.Text = Film.Yoneten ;
               txtYapimYili.Text=  Film.YapimYili ;

            }
        }
    }
}
