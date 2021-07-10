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
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=airport;user ID=postgres;password=1");
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into department(department_cityid,telephone,companyid,department_name)VALUES(@p1,@p2,@p3,@p4) ", baglanti);


            komut2.Parameters.AddWithValue("@p1", int.Parse(cboxDepartmentCity.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p2", txtDepartmentTelephone.Text);
           
            komut2.Parameters.AddWithValue("@p3", int.Parse(cboxDepartmentCompany.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p4", txtDepartments.Text);

            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarılı Ekleme");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from department ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand komut3 = new NpgsqlCommand("Delete from department where code=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtDeleteNumber.Text));
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("ürün silme işlemi gerçekleşti");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from department where department_name like '%" + txtSearch.Text + "%'", baglanti);

            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from company", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboxDepartmentCompany.DisplayMember = "company_name";
            cboxDepartmentCompany.ValueMember = "code";
            cboxDepartmentCompany.DataSource = dt;

            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter db = new NpgsqlDataAdapter("select * from city", baglanti);
            DataTable dc = new DataTable();
            db.Fill(dc);

            cboxDepartmentCity.DisplayMember = "cities";
            cboxDepartmentCity.ValueMember = "code";
            cboxDepartmentCity.DataSource = dc;

            baglanti.Close();
        }
    }
}
