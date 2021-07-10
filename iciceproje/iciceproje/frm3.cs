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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=airport;user ID=postgres;password=1");
        private void btnSave_Click(object sender, EventArgs e)
        { 
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into flight_information(departure_place,landing_place,departure_date,landing_date,transfer_statusid,companyID)" +
                "VALUES(@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(cboxDeparturePlace.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p2", int.Parse(cboxLandingPlace.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p3", this.dTimeDepartureDate.Value);
            komut2.Parameters.AddWithValue("@p4", this.dTimeLandingDate.Value);
            komut2.Parameters.AddWithValue("@p5", int.Parse(cboxTransferStatus.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p6", int.Parse(cboxCompanyFlightInformation.SelectedValue.ToString()));

            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarılı Ekleme");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter db = new NpgsqlDataAdapter("select * from city", baglanti);
            NpgsqlDataAdapter dt = new NpgsqlDataAdapter("select * from transfer_status", baglanti);
            NpgsqlDataAdapter a = new NpgsqlDataAdapter("select * from company", baglanti);
            DataTable da = new DataTable();
            DataTable dx = new DataTable();
            DataTable dl = new DataTable();
            DataTable ax = new DataTable();
            db.Fill(da);
            db.Fill(dx);
            dt.Fill(dl);
            a.Fill(ax);
            cboxDeparturePlace.DisplayMember = "cities";
            cboxDeparturePlace.ValueMember = "code";
            cboxDeparturePlace.DataSource = da;

            cboxLandingPlace.DisplayMember = "cities";
            cboxLandingPlace.ValueMember = "code";
            cboxLandingPlace.DataSource = dx;


            cboxTransferStatus.DisplayMember = "transfer_statuses";
            cboxTransferStatus.ValueMember = "code";
            cboxTransferStatus.DataSource = dl;


            cboxCompanyFlightInformation.DisplayMember = "company_name";
            cboxCompanyFlightInformation.ValueMember = "code";
            cboxCompanyFlightInformation.DataSource = ax;

            baglanti.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from flight_information ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Delete from flight_information where code=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtDeleteNumber.Text));
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("ürün silme işlemi gerçekleşti");
        }

  
    }
}
