using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iciceproje
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=airport;user ID=postgres;password=1");
        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into company(company_name,telephone,email,cityid,address)" +
                "VALUES(@p2,@p3,@p4,@p5,@p6) ", baglanti);
           
            komut1.Parameters.AddWithValue("@p2", txtCompanyName.Text);
            komut1.Parameters.AddWithValue("@p3", txtTelephone.Text);
            komut1.Parameters.AddWithValue("@p4", txtEmail.Text);
            komut1.Parameters.AddWithValue("@p5", int.Parse(cboxCity.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p6", txtAddress.Text);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarılı Ekleme");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from city", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboxCity.DisplayMember = "cities";
            cboxCity.ValueMember = "code";
            cboxCity.DataSource = dt;

            baglanti.Close();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from company ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand komut3 = new NpgsqlCommand("Delete from company where code=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtDeleteNumber.Text));
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("ürün silme işlemi gerçekleşti");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from company where company_name like '%" + txtSearch.Text + "%'", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}
