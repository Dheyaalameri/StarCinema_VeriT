using Mysqlx;
using StarCinema.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCinema.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Musteri m)

        {
            try { 

           int res= DataLayer.MüşteriEkle(m);
            return (res > 0) ;

            }
            catch (Exception ex) 
            { 
            MessageBox.Show("There was an error:" + ex.Message);
                return false ;
            }
        }


        internal static DataSet MüşteriGetir(string filtre)
        {

            try
            {

                DataSet ds = DataLayer.MüşteriGetir(filtre);
                return ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error :  " + ex.Message);
                return null;
            }
        }


        internal static bool MüşteriGüncele(Musteri m)
        {
            try
            {

                int res = DataLayer.MüşteriGüncele(m);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static bool MüşteriSil(string id)
        {
            try
            {

                int res = DataLayer.MüşteriSil(id);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

         internal static bool FilmEkle(Film f)
            {
                try
                {

                    int res = DataLayer.FilmEkle(f);
                    return (res > 0);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error:" + ex.Message);
                    return false;
                }
            }  
        
        internal static DataSet FilmGetir(string filtre)
        {
            try
            {

                DataSet ds = DataLayer.FilmGetir(filtre);
                return ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error :  " + ex.Message);
                return null;
            }
        }

        internal static bool FilmGüncele(Film f)
        {
            try
            {

                int res = DataLayer.FilmGüncele(f);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static bool FilmSil(string id)
        {
            try
            {

                int res = DataLayer.FilmSil(id);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static bool GösterimEkle(Gosterim g)
        {
            try
            {

                int res = DataLayer.GösterimEkle(g);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatişDetay()
        {
            try
            {

                DataSet ds = DataLayer.SatişDetay();
                return ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error :  " + ex.Message);
                return null;
            }
        }

        internal static bool SatişGüncele(Gosterim g)
        {
            try
            {

                int res = DataLayer.SatişGüncele(g);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static bool SatişSil(string id)
        {
            try
            {

                int res = DataLayer.SatişSil(id);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeEkle(Odeme o)
        {
            try
            {

                int res = DataLayer.OdemeEkle(o);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {

                DataSet ds = DataLayer.OdemeDetay();
                return ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error :  " + ex.Message);
                return null;
            }
        }

        internal static bool OdemeGüncele(Odeme o)
        {
            try
            {

                int res = DataLayer.OdemeGüncele(o);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string id)
        {
            try
            {

                int res = DataLayer.OdemeSil(id);
                return (res > 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message);
                return false;
            }
        }
    }
    }

