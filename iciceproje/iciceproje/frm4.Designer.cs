
namespace iciceproje
{
    partial class frm4
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPassengerInformation = new System.Windows.Forms.Button();
            this.btnPassengerInformationList = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.cboxFlight = new System.Windows.Forms.ComboBox();
            this.cboxPassengerCompany = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cboxFightClass = new System.Windows.Forms.ComboBox();
            this.cboxCountry = new System.Windows.Forms.ComboBox();
            this.cboxGender = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.txtDeleteNumber);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(6, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 144);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Name:";
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
            this.dataGridView1.Location = new System.Drawing.Point(263, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 427);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPassengerInformation);
            this.groupBox3.Controls.Add(this.btnPassengerInformationList);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Controls.Add(this.cboxFlight);
            this.groupBox3.Controls.Add(this.cboxPassengerCompany);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.cboxFightClass);
            this.groupBox3.Controls.Add(this.cboxCountry);
            this.groupBox3.Controls.Add(this.cboxGender);
            this.groupBox3.Controls.Add(this.txtSurname);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 275);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passenger Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnPassengerInformation
            // 
            this.btnPassengerInformation.Location = new System.Drawing.Point(30, 236);
            this.btnPassengerInformation.Name = "btnPassengerInformation";
            this.btnPassengerInformation.Size = new System.Drawing.Size(81, 23);
            this.btnPassengerInformation.TabIndex = 25;
            this.btnPassengerInformation.Text = "Save";
            this.btnPassengerInformation.UseVisualStyleBackColor = true;
            this.btnPassengerInformation.Click += new System.EventHandler(this.btnPassengerInformation_Click);
            // 
            // btnPassengerInformationList
            // 
            this.btnPassengerInformationList.Location = new System.Drawing.Point(139, 236);
            this.btnPassengerInformationList.Name = "btnPassengerInformationList";
            this.btnPassengerInformationList.Size = new System.Drawing.Size(100, 23);
            this.btnPassengerInformationList.TabIndex = 26;
            this.btnPassengerInformationList.Text = "List";
            this.btnPassengerInformationList.UseVisualStyleBackColor = true;
            this.btnPassengerInformationList.Click += new System.EventHandler(this.btnPassengerInformationList_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(27, 193);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(32, 13);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "Flight";
            // 
            // cboxFlight
            // 
            this.cboxFlight.FormattingEnabled = true;
            this.cboxFlight.Location = new System.Drawing.Point(139, 185);
            this.cboxFlight.Name = "cboxFlight";
            this.cboxFlight.Size = new System.Drawing.Size(100, 21);
            this.cboxFlight.TabIndex = 23;
            // 
            // cboxPassengerCompany
            // 
            this.cboxPassengerCompany.FormattingEnabled = true;
            this.cboxPassengerCompany.Location = new System.Drawing.Point(139, 158);
            this.cboxPassengerCompany.Name = "cboxPassengerCompany";
            this.cboxPassengerCompany.Size = new System.Drawing.Size(100, 21);
            this.cboxPassengerCompany.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 166);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 17;
            this.label25.Text = "Company ";
            // 
            // cboxFightClass
            // 
            this.cboxFightClass.FormattingEnabled = true;
            this.cboxFightClass.Location = new System.Drawing.Point(139, 131);
            this.cboxFightClass.Name = "cboxFightClass";
            this.cboxFightClass.Size = new System.Drawing.Size(100, 21);
            this.cboxFightClass.TabIndex = 15;
            // 
            // cboxCountry
            // 
            this.cboxCountry.FormattingEnabled = true;
            this.cboxCountry.Location = new System.Drawing.Point(139, 104);
            this.cboxCountry.Name = "cboxCountry";
            this.cboxCountry.Size = new System.Drawing.Size(100, 21);
            this.cboxCountry.TabIndex = 14;
            // 
            // cboxGender
            // 
            this.cboxGender.FormattingEnabled = true;
            this.cboxGender.Location = new System.Drawing.Point(139, 77);
            this.cboxGender.Name = "cboxGender";
            this.cboxGender.Size = new System.Drawing.Size(100, 21);
            this.cboxGender.TabIndex = 13;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(139, 51);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Flight Class";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Country ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Surname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name";
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm4";
            this.Text = "frm4";
            this.Load += new System.EventHandler(this.frm4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPassengerInformation;
        private System.Windows.Forms.Button btnPassengerInformationList;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cboxFlight;
        private System.Windows.Forms.ComboBox cboxPassengerCompany;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cboxFightClass;
        private System.Windows.Forms.ComboBox cboxCountry;
        private System.Windows.Forms.ComboBox cboxGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}