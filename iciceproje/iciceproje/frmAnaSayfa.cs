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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGetir (Form frm)
        {
            
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();

        }
        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            frm2 fr2 = new frm2();
          //  FormGetir(frm2);
            fr2.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3 fr3 = new frm3();
            fr3.ShowDialog();
        }

        private void btnPassengerInformation_Click(object sender, EventArgs e)
        {
            frm4 fr4 = new frm4();
            fr4.ShowDialog();
        }

        private void btnEmployeeInformation_Click(object sender, EventArgs e)
        {
            frm5 fr5 = new frm5();
            fr5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm6 fr6 = new frm6();
            fr6.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
