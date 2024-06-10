using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCinema.DL
{
   
 
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
    new MySqlConnectionStringBuilder()
    {
        //127.0.0.1
        Server = "localhost",
        Database = "StarCinema",
        UserID = "root",
        Password = "123456",

        }.ConnectionString
     );

        public static int MüşteriEkle(Musteri m ) 
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_MusteriEkle", conn);
                komut .CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id",m.ID );
                komut.Parameters.AddWithValue("@ad", m.AD);
                komut.Parameters.AddWithValue("@Soy", m.Soyad);
                komut.Parameters.AddWithValue("@Email", m.Email);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@adr", m.Adres);
                int res= komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if ( conn.State !=System.Data.ConnectionState.Closed ) 
                
                   conn.Close();

                
            }

         
        }

        internal static int MüşteriGüncele(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_MusteriGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.AD);
                komut.Parameters.AddWithValue("@Soy", m.Soyad);
                komut.Parameters.AddWithValue("@Email", m.Email);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@adr", m.Adres);
                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }
      
        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut;
                if(string.IsNullOrEmpty(filtre))
                { 
                komut = new MySqlCommand("StarCinema_MusteriHpesi", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                
               }
               else
                {
               komut = new MySqlCommand("StarCinema_MusteriBul", conn);
               komut.CommandType = System.Data.CommandType.StoredProcedure;
               komut.Parameters.AddWithValue("@filtre", filtre);
                }
               
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

      
        internal static int MüşteriSil(string id)
        {
             try
             {
                if (conn.State != System.Data.ConnectionState.Open)

                conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_MusteriSil", conn);
                komut .CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID",id );
    
                int res= komut.ExecuteNonQuery();
                 return res;
             }

                catch (Exception ex)
            {
                throw ex;


              }
                finally
             {
                if ( conn.State !=System.Data.ConnectionState.Closed ) 
      
                conn.Close();

      
          }
              }

        internal static int FilmEkle(Film f)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_FilmEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", f.ID);
                komut.Parameters.AddWithValue("@ad", f.AD);
                komut.Parameters.AddWithValue("@tur", f.Tur);
                komut.Parameters.AddWithValue("@sure", f.Sure);
                komut.Parameters.AddWithValue("@Yoneten", f.Yoneten);
                komut.Parameters.AddWithValue("@YapimYili", f.YapimYili);
                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }


        }
        internal static int FilmGüncele(Film f)
                            {
                    try
                    {
                        if (conn.State != System.Data.ConnectionState.Open)

                            conn.Open();
                        MySqlCommand komut = new MySqlCommand("StarCinema_FilmGüncele", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@id", f.ID);
                        komut.Parameters.AddWithValue("@ad", f.AD);
                        komut.Parameters.AddWithValue("@tur", f.Tur);
                        komut.Parameters.AddWithValue("@sure", f.Sure);
                        komut.Parameters.AddWithValue("@Yoneten", f.Yoneten);
                        komut.Parameters.AddWithValue("@YapimYili", f.YapimYili);

                        int res = komut.ExecuteNonQuery();
                        return res;
                    }

                    catch (Exception ex)
                    {
                        throw ex;


                    }
                    finally
                    {
                        if (conn.State != System.Data.ConnectionState.Closed)

                            conn.Close();


                    }
                }
        internal static DataSet FilmGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("StarCinema_FilmlarHpesi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("StarCinema_FilmiBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static int FilmSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_FilmSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static int GösterimEkle(Gosterim g)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_GösterimEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@gid",g.ID);
                komut.Parameters.AddWithValue("@mid", g.MusteriID);
                komut.Parameters.AddWithValue("@fid", g.FilmID);
                komut.Parameters.AddWithValue("@tarih", g.tarih);
                komut.Parameters.AddWithValue("@Saat", g.Saat);
                komut.Parameters.AddWithValue("@Salon", g.Salon);
                komut.Parameters.AddWithValue("@kolutk", g.koltuk);
                komut.Parameters.AddWithValue("@fiyat", g.Fiyat);
                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static DataSet SatişDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_SatişDetay", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;


                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static int SatişGüncele(Gosterim g)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_GösterimGüncele", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@gid", g.ID);
                komut.Parameters.AddWithValue("@mid", g.MusteriID);
                komut.Parameters.AddWithValue("@fid", g.FilmID);
                komut.Parameters.AddWithValue("@tarih", g.tarih);
                komut.Parameters.AddWithValue("@Saat", g.Saat);
                komut.Parameters.AddWithValue("@Salon", g.Salon);
                komut.Parameters.AddWithValue("@kolutk", g.koltuk);
                komut.Parameters.AddWithValue("@fiyat", g.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static int SatişSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_GösterimSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static int OdemeEkle(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_OdemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tarih", o.tarih);
                komut.Parameters.AddWithValue("@tur", o.Tur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);
                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_OdemeDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;


                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static int OdemeGüncele(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_OdemeGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tarih", o.tarih);
                komut.Parameters.AddWithValue("@tur", o.Tur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);
                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }

        internal static int OdemeSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)

                    conn.Open();
                MySqlCommand komut = new MySqlCommand("StarCinema_OdemeSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ID", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }

            catch (Exception ex)
            {
                throw ex;


            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)

                    conn.Close();


            }
        }
    }
   }
 
