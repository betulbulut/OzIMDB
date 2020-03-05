using OzIMDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzIMDB
{
    public partial class Form1 : Form
    {

        string dbName = "OzImdb";
        SqlConnection con = new SqlConnection("server=.;database=master;uid=sa;pwd=123;");
        BindingList<Film> filmler; //ozimdb.models 
        bool guncellemeAcik = false;

        public Form1()
        {
            con.Open();
            veritabanıYoksaOlustur();
            InitializeComponent();
            FilmleriListele();
        }

        private void FilmleriListele()
        {
            guncellemeAcik = false;
            var cmd = new SqlCommand("select * from filmler", con);
            var dr = cmd.ExecuteReader();

            filmler = new BindingList<Film>();
            while (dr.Read())
            {
                filmler.Add(new Film
                {
                    Id = (int)dr["Id"],
                    FilmAd = (string)dr["filmad"],
                    puan = dr["puan"] as int?,
                    Foto = convertToImage(dr["Foto"] as byte[])
                });
            }
            dr.Close();
            lstFilmler.DataSource = filmler;
            //pboFoto.Image = filmler[0].Foto;
            guncellemeAcik = true;

        }

        private void veritabanıYoksaOlustur()
        {
            var cmd = new SqlCommand($"select db_id(N'{dbName}')", con);
            short? sonuc = cmd.ExecuteScalar() as short?;

            if (sonuc == null) //(sonuc.hasValue)
            {
                cmd = new SqlCommand($"Create database {dbName}", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"Use { dbName };"
                  + @"create table filmler
(
    Id Int Primary key identity,
    filmad nvarchar(200) not null,
    puan int null,
    foto varbinary(max) null);"
                    , con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand($"USE {dbName}", con);
                cmd.ExecuteNonQuery();
            }

        }

        private Image convertToImage(byte[] data)
        {
            if (data == null)
                return null;
            return (Image)new ImageConverter().ConvertFrom(data);
        }

        private void btnYeniFilm_Click(object sender, EventArgs e)
        {
            int id = YeniFilmEkle();
            FilmleriListele();

            //foreach (var item in lstFilmler.Items)
            //{
            //    Film film = (Film)item;
            //    if (film.Id==id)
            //    {
            //        lstFilmler.SelectedItem = item;
            //        break;

            //    }
            //}
        }

        private int YeniFilmEkle()
        {
            var cmd = new SqlCommand("Insert into filmler(filmad) values (N'Yeni Film'); select scope_identity();", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void lstFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1)
            {
                return;
            }
            guncellemeAcik = false;

            Film film = (Film)lstFilmler.SelectedItem;

            txtFilmId.Text = film.Id.ToString();
            txtFilmAd.Text = film.FilmAd;

            #region Puan Göster
            if (film.puan == null)
            {
                rb0.Checked = true;
            }
            else
            {
                //RadioButton rb;
                //foreach (Control control in gboPuan.Controls)
                //{
                //-----yöntem1--------
                //if (control is RadioButton)

                //rb= (RadioButton)control;
                //if(rb.Tag is int && (int)rb.Tag == film.puan.Value)
                //{
                //    rb.Checked=true;
                //    break;

                //}

                //-----yöntem2--------
                //if (control is RadioButton
                //   && control.Tag != null
                //   && control.Tag.ToString() == film.puan.ToString())
                //{
                //    ((RadioButton)control).Checked = true;
                //    break;
                //}

                //-----yöntem3-------
                RadioButton[] rbDizi1 = { rb0, rbPuan1, rbPuan2, rbPuan3, rbPuan4, rbPuan5 };
                rbDizi1[film.puan.Value].Checked = true;

                guncellemeAcik = true;


            }

            #endregion

            pboFoto.Image = film.Foto;
        }

        private void txtFilmAd_TextChanged(object sender, EventArgs e)
        {
            Guncelle();

        }

        private void Guncelle()
        {
            if (guncellemeAcik && lstFilmler.SelectedIndex > -1) //güncelleme açık mı listede seçili bi item var mı
            {
                Film film = (Film)lstFilmler.SelectedItem;
                film.FilmAd = txtFilmAd.Text;
                film.Foto = pboFoto.Image;
                film.puan = SeciliPuan();
                //todo: puanı ve resmi güncelle 

                var cmd = new SqlCommand("update Filmler set filmad=@p1 , puan=@p2 , Foto=@p3 where Id=@p4", con);
                cmd.Parameters.AddWithValue("@p1", film.FilmAd);
                cmd.Parameters.AddWithValue("@p2",(object) film.puan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p3",(object) converterToByteArray(film.Foto) ?? SqlBinary.Null); //yeni film eklerken güncelleme yapılması için 
                cmd.Parameters.AddWithValue("@p4", film.Id);
                cmd.ExecuteNonQuery();


                filmler.ResetBindings(); // güncelleme yaparken otomatik olarak datasource dan (refresh) gösterim (listview) 

            }
        }
        private int? SeciliPuan()
        {
            RadioButton rb=null;

            foreach (Control control in gboPuan.Controls)
            {
                if (control is RadioButton)
                {
                    rb = (RadioButton)control;
                    if (rb.Checked)
                    {
                        break;
                    }
                }
            }
            return rb.Tag == null ? null as int ? : Convert.ToInt32(rb.Tag); //tag null ise null döndür değilse tag i int e cast ederek döndür
        }

        private void rb0_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Guncelle();
            }
        }

        private void pboFoto_Click(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1)
                return;
            DialogResult dr=openFileDialog1.ShowDialog();

            if (dr==DialogResult.OK)
            {
                Film film = (Film)lstFilmler.SelectedItem;
                pboFoto.Image = Image.FromFile(openFileDialog1.FileName);
                Guncelle();

            }          
        }

        public static byte[] converterToByteArray(Image image)
        {
            if (image == null)
                return null;


            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(image, typeof(byte[]));
            return xByte;
        }

        private void lstFilmler_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Delete == lstFilmler.SelectedIndex > -1)
            {
                int sid = lstFilmler.SelectedIndex;
                Film film = (Film)lstFilmler.SelectedItem;
                filmler.Remove(film);
                FilmSil(film.Id);

                if (sid == lstFilmler.SelectedIndex)
                {
                    lstFilmler.SelectedIndex = -1;
                    lstFilmler.SelectedIndex = sid;
                    //MessageBox.Show("silindi ama index değişmedi");
                }
                else if (lstFilmler.SelectedIndex == -1)
                {
                    FormuTemizle();
                }
            }
        }

        private void FormuTemizle()
        {
            txtFilmAd.Clear();
            txtFilmId.Clear();
            rb0.Checked = true;
            pboFoto.Image = null;
        }

        private void FilmSil(int id)
        {
            var cmd = new SqlCommand("Delete from filmler where Id=" + id, con);
            cmd.ExecuteNonQuery();
        }

        private void txtFilmAd_Leave(object sender, EventArgs e)
        {
            if (txtFilmAd.Text.Trim()=="")
            {
                MessageBox.Show("Film adı girmediniz!");
                txtFilmAd.Focus();
            }
        }
    }
}


