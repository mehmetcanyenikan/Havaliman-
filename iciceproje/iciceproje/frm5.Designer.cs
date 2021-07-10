
namespace iciceproje
{
    partial class frm5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDeleteNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboxEmployeeFlightInformation = new System.Windows.Forms.ComboBox();
            this.cboxEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.cboxEmployeeCompany = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.cboxEmployeeBloodGroup = new System.Windows.Forms.ComboBox();
            this.cboxEmployeeCity = new System.Windows.Forms.ComboBox();
            this.txtEmployeeTelephone = new System.Windows.Forms.TextBox();
            this.dTimeBusinessLoginDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEmployeeInformationList = new System.Windows.Forms.Button();
            this.btnEmployeeInformation = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.txtDeleteNumber);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 138);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Please Delete Number:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Employee Code:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(145, 94);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtDeleteNumber
            // 
            this.txtDeleteNumber.Location = new System.Drawing.Point(145, 55);
            this.txtDeleteNumber.Name = "txtDeleteNumber";
            this.txtDeleteNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteNumber.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1157, 513);
            this.dataGridView1.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboxEmployeeFlightInformation);
            this.groupBox4.Controls.Add(this.cboxEmployeeDepartment);
            this.groupBox4.Controls.Add(this.cboxEmployeeCompany);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtEmployeeCode);
            this.groupBox4.Controls.Add(this.cboxEmployeeBloodGroup);
            this.groupBox4.Controls.Add(this.cboxEmployeeCity);
            this.groupBox4.Controls.Add(this.txtEmployeeTelephone);
            this.groupBox4.Controls.Add(this.dTimeBusinessLoginDate);
            this.groupBox4.Controls.Add(this.txtEmployeeSurname);
            this.groupBox4.Controls.Add(this.txtEmployeeName);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 323);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Information ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cboxEmployeeFlightInformation
            // 
            this.cboxEmployeeFlightInformation.FormattingEnabled = true;
            this.cboxEmployeeFlightInformation.Location = new System.Drawing.Point(174, 288);
            this.cboxEmployeeFlightInformation.Name = "cboxEmployeeFlightInformation";
            this.cboxEmployeeFlightInformation.Size = new System.Drawing.Size(73, 21);
            this.cboxEmployeeFlightInformation.TabIndex = 25;
            // 
            // cboxEmployeeDepartment
            // 
            this.cboxEmployeeDepartment.FormattingEnabled = true;
            this.cboxEmployeeDepartment.Location = new System.Drawing.Point(90, 288);
            this.cboxEmployeeDepartment.Name = "cboxEmployeeDepartment";
            this.cboxEmployeeDepartment.Size = new System.Drawing.Size(73, 21);
            this.cboxEmployeeDepartment.TabIndex = 18;
            // 
            // cboxEmployeeCompany
            // 
            this.cboxEmployeeCompany.FormattingEnabled = true;
            this.cboxEmployeeCompany.Location = new System.Drawing.Point(12, 288);
            this.cboxEmployeeCompany.Name = "cboxEmployeeCompany";
            this.cboxEmployeeCompany.Size = new System.Drawing.Size(72, 21);
            this.cboxEmployeeCompany.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Company /Department/FlightInformation";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(147, 218);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCode.TabIndex = 13;
            // 
            // cboxEmployeeBloodGroup
            // 
            this.cboxEmployeeBloodGroup.FormattingEnabled = true;
            this.cboxEmployeeBloodGroup.Location = new System.Drawing.Point(147, 184);
            this.cboxEmployeeBloodGroup.Name = "cboxEmployeeBloodGroup";
            this.cboxEmployeeBloodGroup.Size = new System.Drawing.Size(100, 21);
            this.cboxEmployeeBloodGroup.TabIndex = 12;
            // 
            // cboxEmployeeCity
            // 
            this.cboxEmployeeCity.FormattingEnabled = true;
            this.cboxEmployeeCity.Location = new System.Drawing.Point(147, 151);
            this.cboxEmployeeCity.Name = "cboxEmployeeCity";
            this.cboxEmployeeCity.Size = new System.Drawing.Size(100, 21);
            this.cboxEmployeeCity.TabIndex = 11;
            // 
            // txtEmployeeTelephone
            // 
            this.txtEmployeeTelephone.Location = new System.Drawing.Point(147, 119);
            this.txtEmployeeTelephone.Name = "txtEmployeeTelephone";
            this.txtEmployeeTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeTelephone.TabIndex = 10;
            // 
            // dTimeBusinessLoginDate
            // 
            this.dTimeBusinessLoginDate.Location = new System.Drawing.Point(147, 88);
            this.dTimeBusinessLoginDate.Name = "dTimeBusinessLoginDate";
            this.dTimeBusinessLoginDate.Size = new System.Drawing.Size(100, 20);
            this.dTimeBusinessLoginDate.TabIndex = 9;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(147, 60);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeSurname.TabIndex = 8;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(147, 32);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(26, 225);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Employee Code";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(26, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Blood Group";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "City";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Telephone";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Business Login Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Surname";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Name";
            // 
            // btnEmployeeInformationList
            // 
            this.btnEmployeeInformationList.Location = new System.Drawing.Point(159, 358);
            this.btnEmployeeInformationList.Name = "btnEmployeeInformationList";
            this.btnEmployeeInformationList.Size = new System.Drawing.Size(91, 23);
            this.btnEmployeeInformationList.TabIndex = 17;
            this.btnEmployeeInformationList.Text = "List";
            this.btnEmployeeInformationList.UseVisualStyleBackColor = true;
            this.btnEmployeeInformationList.Click += new System.EventHandler(this.btnEmployeeInformationList_Click);
            // 
            // btnEmployeeInformation
            // 
            this.btnEmployeeInformation.Location = new System.Drawing.Point(22, 358);
            this.btnEmployeeInformation.Name = "btnEmployeeInformation";
            this.btnEmployeeInformation.Size = new System.Drawing.Size(92, 23);
            this.btnEmployeeInformation.TabIndex = 14;
            this.btnEmployeeInformation.Text = "Save";
            this.btnEmployeeInformation.UseVisualStyleBackColor = true;
            this.btnEmployeeInformation.Click += new System.EventHandler(this.btnEmployeeInformation_Click);
            // 
            // frm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 535);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnEmployeeInformationList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEmployeeInformation);
            this.Name = "frm5";
            this.Text = "frm5";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDeleteNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboxEmployeeFlightInformation;
        private System.Windows.Forms.ComboBox cboxEmployeeDepartment;
        private System.Windows.Forms.ComboBox cboxEmployeeCompany;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.ComboBox cboxEmployeeBloodGroup;
        private System.Windows.Forms.ComboBox cboxEmployeeCity;
        private System.Windows.Forms.TextBox txtEmployeeTelephone;
        private System.Windows.Forms.DateTimePicker dTimeBusinessLoginDate;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnEmployeeInformationList;
        private System.Windows.Forms.Button btnEmployeeInformation;
    }
}