using Fabrika_1_2.orm.context;
using Fabrika_1_2.orm.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        internet_sales net;
        shoe_in_and_out in_out;
        shoe_manufacturıng manu;
        materıals_avaılable mat;
        context db = new context();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            net = new internet_sales();


            if (net != null)
            {

                net.Model = txt_model.Text;
                net.Brand = txt_marka.Text;
                net.Colour = txt_renk.Text;
                net.Number = txt_numara.Text;
                net.pıece = txt_adet.Text;
                net.prıce = txt_fiyat.Text;
                net.barcod_No = txt_Barkod.Text;

                db.Internet_Sales.Add(net);
                db.SaveChanges();

                txt_model.Text = "";
                txt_Barkod.Text = "";
                txt_marka.Text = " ";
                txt_renk.Text = "";
                txt_numara.Text = "";
                txt_adet.Text = "";
                txt_fiyat.Text = "";


                MessageBox.Show("Veri eklendi!");
                dataGridView1.DataSource = db.Internet_Sales.ToList();
            }
            else
                MessageBox.Show("Veri yüklenmedi!");
            dataGridView1.DataSource = db.Internet_Sales.ToList();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            net = new internet_sales();
            int id = Convert.ToInt32(txt_id.Text);
            var i = db.Internet_Sales.Where(w => w.ID == id).FirstOrDefault();


            if (i != null)
            {
                var b = db.Internet_Sales.Find(id);

                b.barcod_No = txt_Barkod.Text;
                b.Brand = txt_marka.Text;
                b.Model = txt_model.Text;
                b.Colour = txt_renk.Text;
                b.Number = txt_numara.Text;
                b.prıce = txt_fiyat.Text;
                b.pıece = txt_adet.Text;


                db.SaveChanges();
                delete_txt();

                MessageBox.Show("Güncelleme gerçekleşti!");
                txt_id.Text = "";
                dataGridView1.DataSource = db.Internet_Sales.ToList();
            }
            else
            {
                MessageBox.Show("Hata!");
                dataGridView1.DataSource = db.Internet_Sales.ToList();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            net = new internet_sales();
            net.ID = Convert.ToInt32(txt_id.Text);
            net = db.Internet_Sales.Find(net.ID);
            if (net != null)
            {
                db.Internet_Sales.Remove(net);
                db.SaveChanges();

                txt_id.Text = "";

                MessageBox.Show("Veri Silindi!");
                dataGridView1.DataSource = db.Internet_Sales.ToList();
            }
            else
                MessageBox.Show("Hata! Veri Silinemedi!");

            dataGridView1.DataSource = db.Internet_Sales.ToList();
        }
        private void DateGridview1_celldoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public void delete_txt()
        {
            txt_model.Text = "";
            txt_marka.Text = " ";
            txt_renk.Text = "";
            txt_numara.Text = "";
            txt_adet.Text = "";
            txt_fiyat.Text = "";
            txt_Barkod.Text = "";
            txt_quantıty.Text = "";
            txt_number_plate.Text = "";
            txt_genus.Text = "";
            txt_id.Text = "";
            txt_fınıshed_shoes_sıze.Text = "";
            txt_returned_shoe_sıze.Text = "";
            txt_shoes_delıvery_dates.Text = "";
        }
        private void btn_internet_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Internet_Sales.ToList();
        }

        private void btn_manufacturing_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Shoe_Manufacturıngs.ToList();
        }

        private void btn_ayakkabıGiriş_çıkış_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Shoe_In_And_Outs.ToList();
        }

        private void btn_malzemeler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Materıals_Avaılable.ToList();
        }

        private void btn_materıals_kaydet_Click(object sender, EventArgs e)
        {
            mat = new materıals_avaılable();
            if (mat != null)
            {

                mat.Model = txt_model.Text;
                mat.Brand = txt_marka.Text;
                mat.Colour = txt_renk.Text;
                mat.number_plate = txt_numara.Text;
                mat.genus = txt_adet.Text;
                mat.quantıty = txt_fiyat.Text;
                mat.Barcod_No = txt_Barkod.Text;

                db.Materıals_Avaılable.Add(mat);
                db.SaveChanges();

                delete_txt();

                MessageBox.Show("Veri eklendi!");
                dataGridView1.DataSource = db.Materıals_Avaılable.ToList();
            }
            else
                MessageBox.Show("Veri yüklenmedi!");
            dataGridView1.DataSource = db.Materıals_Avaılable.ToList();
        }

        private void btn_materıals_güncelle_Click(object sender, EventArgs e)
        {
            mat = new materıals_avaılable();
            int id = Convert.ToInt32(txt_id.Text);
            var i = db.Internet_Sales.Where(w => w.ID == id).FirstOrDefault();


            if (i != null)
            {
                var b = db.Materıals_Avaılable.Find(id);

                b.Barcod_No = txt_Barkod.Text;
                b.Brand = txt_marka.Text;
                b.Model = txt_model.Text;
                b.Colour = txt_renk.Text;
                b.genus = txt_genus.Text;
                b.number_plate = txt_number_plate.Text;
                b.quantıty = txt_quantıty.Text;


                db.SaveChanges();

                delete_txt();
                MessageBox.Show("Güncelleme gerçekleşti!");
                txt_id.Text = "";
                dataGridView1.DataSource = db.Materıals_Avaılable.ToList();
            }
            else
            {
                MessageBox.Show("Hata!");
                dataGridView1.DataSource = db.Materıals_Avaılable.ToList();
            }
        }

        private void btn_materıals_sil_Click(object sender, EventArgs e)
        {
            mat = new materıals_avaılable();
            mat.ID = Convert.ToInt32(txt_id.Text);
            mat = db.Materıals_Avaılable.Find(mat.ID);
            if (mat != null)
            {
                db.Materıals_Avaılable.Remove(mat);
                db.SaveChanges();

                txt_id.Text = "";

                MessageBox.Show("Veri Silindi!");
                dataGridView1.DataSource = db.Materıals_Avaılable.ToList();
            }
            else
                MessageBox.Show("Hata! Veri Silinemedi!");

            dataGridView1.DataSource = db.Materıals_Avaılable.ToList();
        }

        private void btn_manufacturıng_kaydet_Click(object sender, EventArgs e)
        {
            manu = new shoe_manufacturıng();
            if (manu != null)
            {

                manu.Model = txt_model.Text;
                manu.Brand = txt_marka.Text;
                manu.Colour = txt_renk.Text;
                manu.Barcod_No = txt_Barkod.Text;
                manu.fınıshed_shoes_sıze = txt_fınıshed_shoes_sıze.Text;

                db.Shoe_Manufacturıngs.Add(manu);
                db.SaveChanges();

                delete_txt();

                MessageBox.Show("Veri eklendi!");
                dataGridView1.DataSource = db.Shoe_Manufacturıngs.ToList();
            }
            else
                MessageBox.Show("Veri yüklenmedi!");
            dataGridView1.DataSource = db.Shoe_Manufacturıngs.ToList();
        }


        private void btn_manufacturıng_güncelle_Click(object sender, EventArgs e)
        {
            manu = new shoe_manufacturıng();
            int id = Convert.ToInt32(txt_id.Text);
            var i = db.Shoe_Manufacturıngs.Where(w => w.ID == id).FirstOrDefault();


            if (i != null)
            {
                var b = db.Shoe_Manufacturıngs.Find(id);

                b.Barcod_No = txt_Barkod.Text;
                b.Brand = txt_marka.Text;
                b.Model = txt_model.Text;
                b.Colour = txt_renk.Text;
                b.fınıshed_shoes_sıze = txt_fınıshed_shoes_sıze.Text;




                db.SaveChanges();
                delete_txt();

                MessageBox.Show("Güncelleme gerçekleşti!");
                txt_id.Text = "";
                dataGridView1.DataSource = db.Shoe_Manufacturıngs.ToList();
            }
            else
            {
                MessageBox.Show("Hata!");
                dataGridView1.DataSource = db.Shoe_Manufacturıngs.ToList();
            }
        }

        private void btn_manufacturıng_sil_Click(object sender, EventArgs e)
        {
            manu = new shoe_manufacturıng();
            manu.ID = Convert.ToInt32(txt_id.Text);
            manu = db.Shoe_Manufacturıngs.Find(manu.ID);
            if (manu != null)
            {
                db.Shoe_Manufacturıngs.Remove(manu);
                db.SaveChanges();

                txt_id.Text = "";

                MessageBox.Show("Veri Silindi!");
                dataGridView1.DataSource = db.Shoe_Manufacturıngs.ToList();
            }
            else
                MessageBox.Show("Hata! Veri Silinemedi!");

            dataGridView1.DataSource = db.Shoe_Manufacturıngs.ToList();
        }

        private void btn_in_and_out_kaydet_Click(object sender, EventArgs e)
        {
            in_out = new shoe_in_and_out();
            if (in_out != null)
            {

                in_out.Model = txt_model.Text;
                in_out.Brand = txt_marka.Text;
                in_out.Colour = txt_renk.Text;
                in_out.Barcod_No = txt_Barkod.Text;
                in_out.returned_shoe_sıze = txt_returned_shoe_sıze.Text;
                in_out.shoes_delıvery_dates = txt_shoes_delıvery_dates.Text;

                db.Shoe_In_And_Outs.Add(in_out);
                db.SaveChanges();

                delete_txt();

                MessageBox.Show("Veri eklendi!");
                dataGridView1.DataSource = db.Shoe_In_And_Outs.ToList();
            }
            else
                MessageBox.Show("Veri yüklenmedi!");
            dataGridView1.DataSource = db.Shoe_In_And_Outs.ToList();
        }

        private void btn_in_and_out_güncelle_Click(object sender, EventArgs e)
        {
            manu = new shoe_manufacturıng();
            int id = Convert.ToInt32(txt_id.Text);
            var i = db.Shoe_Manufacturıngs.Where(w => w.ID == id).FirstOrDefault();


            if (i != null)
            {
                var b = db.Shoe_In_And_Outs.Find(id);

                b.Barcod_No = txt_Barkod.Text;
                b.Brand = txt_marka.Text;
                b.Model = txt_model.Text;
                b.Colour = txt_renk.Text;
                b.shoes_delıvery_dates = txt_fınıshed_shoes_sıze.Text;
                b.returned_shoe_sıze = txt_returned_shoe_sıze.Text;




                db.SaveChanges();
                delete_txt();

                MessageBox.Show("Güncelleme gerçekleşti!");
                txt_id.Text = "";
                dataGridView1.DataSource = db.Shoe_In_And_Outs.ToList();
            }
            else
            {
                MessageBox.Show("Hata!");
                dataGridView1.DataSource = db.Shoe_In_And_Outs.ToList();
            }
        }

        private void btn_in_and_out_sil_Click(object sender, EventArgs e)
        {
            in_out = new shoe_in_and_out();
            in_out.ID = Convert.ToInt32(txt_id.Text);
            in_out = db.Shoe_In_And_Outs.Find(in_out.ID);
            if (in_out != null)
            {
                db.Shoe_In_And_Outs.Remove(in_out);
                db.SaveChanges();

                txt_id.Text = "";

                MessageBox.Show("Veri Silindi!");
                dataGridView1.DataSource = db.Shoe_In_And_Outs.ToList();
            }
            else
                MessageBox.Show("Hata! Veri Silinemedi!");

            dataGridView1.DataSource = db.Shoe_In_And_Outs.ToList();
        }
    }
}
