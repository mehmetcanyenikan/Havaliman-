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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=airport;user ID=postgres;password=1");
        private void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into employee_information(name,surname,business_login_date,telephone,cityid,blood_groupid,employee_code,companyid,departmentid,flight_informationid)" +
                "VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10) ", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtEmployeeName.Text);
            komut2.Parameters.AddWithValue("@p2", txtEmployeeSurname.Text);
            komut2.Parameters.AddWithValue("@p3", this.dTimeBusinessLoginDate.Value);
            komut2.Parameters.AddWithValue("@p4", txtEmployeeTelephone.Text);
            komut2.Parameters.AddWithValue("@p5", int.Parse(cboxEmployeeCity.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p6", int.Parse(cboxEmployeeBloodGroup.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p7", txtEmployeeCode.Text);
           
            komut2.Parameters.AddWithValue("@p8", int.Parse(cboxEmployeeCompany.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p9", int.Parse(cboxEmployeeDepartment.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p10", int.Parse(cboxEmployeeFlightInformation.SelectedValue.ToString()));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarılı Ekleme");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from city", baglanti);
            NpgsqlDataAdapter db = new NpgsqlDataAdapter("select * from blood_group", baglanti);
            NpgsqlDataAdapter dc = new NpgsqlDataAdapter("select * from company", baglanti);
            NpgsqlDataAdapter dd = new NpgsqlDataAdapter("select * from department", baglanti);
            NpgsqlDataAdapter d1 = new NpgsqlDataAdapter("select * from flight_information", baglanti);
            DataTable dt = new DataTable();
            DataTable dy = new DataTable();
            DataTable dl = new DataTable();
            DataTable dz = new DataTable();
            DataTable d2 = new DataTable();
            da.Fill(dt);
            db.Fill(dy);
            dc.Fill(dl);
            dd.Fill(dz);
            d1.Fill(d2);


            cboxEmployeeCity.DisplayMember = "cities";
            cboxEmployeeCity.ValueMember = "code";
            cboxEmployeeCity.DataSource = dt;


            cboxEmployeeBloodGroup.DisplayMember = "blood_groups";
            cboxEmployeeBloodGroup.ValueMember = "code";
            cboxEmployeeBloodGroup.DataSource = dy;



            cboxEmployeeCompany.DisplayMember = "company_name";
            cboxEmployeeCompany.ValueMember = "code";
            cboxEmployeeCompany.DataSource = dl;


            cboxEmployeeDepartment.DisplayMember = "department_name";
            cboxEmployeeDepartment.ValueMember = "code";
            cboxEmployeeDepartment.DataSource = dz;

            cboxEmployeeFlightInformation.DisplayMember = "code";
            cboxEmployeeFlightInformation.ValueMember = "code";
            cboxEmployeeFlightInformation.DataSource = d2;

            baglanti.Close();
        }

        private void btnEmployeeInformationList_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from employee_information ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand komut3 = new NpgsqlCommand("Delete from employee_information where code=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtDeleteNumber.Text));
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("ürün silme işlemi gerçekleşti");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();

            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from employee_information where employee_code like '%" + txtSearch.Text + "%'", baglanti);

            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

    
    }
}
