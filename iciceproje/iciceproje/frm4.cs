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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=airport;user ID=postgres;password=1");
        private void btnPassengerInformation_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into passenger_information(name,surname,genderid,countryid,flight_classid,companyid,flight_informationid)VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7) ", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtName.Text);
            komut2.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut2.Parameters.AddWithValue("@p3", int.Parse(cboxGender.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p4", int.Parse(cboxCountry.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p5", int.Parse(cboxFightClass.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p6", int.Parse(cboxPassengerCompany.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p7", int.Parse(cboxFlight.SelectedValue.ToString()));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarılı Ekleme");
        }

        private void btnPassengerInformationList_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from passenger_information ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand komut3 = new NpgsqlCommand("Delete from passenger_information where code=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtDeleteNumber.Text));
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("ürün silme işlemi gerçekleşti");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from passenger_information where name like '%" + txtSearch.Text + "%'", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from gender", baglanti);
            NpgsqlDataAdapter db = new NpgsqlDataAdapter("select * from country", baglanti);
            NpgsqlDataAdapter dc = new NpgsqlDataAdapter("select * from flight_class", baglanti);
            NpgsqlDataAdapter dz = new NpgsqlDataAdapter("select * from company", baglanti);
            NpgsqlDataAdapter d1 = new NpgsqlDataAdapter("select * from flight_information", baglanti);
            DataTable dx = new DataTable();
            DataTable dt = new DataTable();
            DataTable dy = new DataTable();
            DataTable dl = new DataTable();
            DataTable d2 = new DataTable();
            da.Fill(dt);
            db.Fill(dx);
            dc.Fill(dy);
            dz.Fill(dl);
            d1.Fill(d2);
            cboxGender.DisplayMember = "genders";
            cboxGender.ValueMember = "code";
            cboxGender.DataSource = dt;


            cboxCountry.DisplayMember = "countries";
            cboxCountry.ValueMember = "code";
            cboxCountry.DataSource = dx;


            cboxFightClass.DisplayMember = "flight_classes";
            cboxFightClass.ValueMember = "code";
            cboxFightClass.DataSource = dy;
            baglanti.Close();

            cboxPassengerCompany.DisplayMember = "company_name";
            cboxPassengerCompany.ValueMember = "code";
            cboxPassengerCompany.DataSource = dl;
            baglanti.Close();

            cboxFlight.DisplayMember = "code";
            cboxFlight.ValueMember = "code";
            cboxFlight.DataSource = d2;
            baglanti.Close();

        }

        private void frm4_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
