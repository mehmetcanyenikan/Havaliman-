
namespace iciceproje
{
    partial class frm3
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
            this.txtDeleteNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxCompanyFlightInformation = new System.Windows.Forms.ComboBox();
            this.cboxTransferStatus = new System.Windows.Forms.ComboBox();
            this.dTimeLandingDate = new System.Windows.Forms.DateTimePicker();
            this.dTimeDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.cboxLandingPlace = new System.Windows.Forms.ComboBox();
            this.cboxDeparturePlace = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDeleteNumber);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(11, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 194);
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
            this.dataGridView1.Location = new System.Drawing.Point(268, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 475);
            this.dataGridView1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxCompanyFlightInformation);
            this.groupBox1.Controls.Add(this.cboxTransferStatus);
            this.groupBox1.Controls.Add(this.dTimeLandingDate);
            this.groupBox1.Controls.Add(this.dTimeDepartureDate);
            this.groupBox1.Controls.Add(this.cboxLandingPlace);
            this.groupBox1.Controls.Add(this.cboxDeparturePlace);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 295);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxCompanyFlightInformation
            // 
            this.cboxCompanyFlightInformation.FormattingEnabled = true;
            this.cboxCompanyFlightInformation.Location = new System.Drawing.Point(119, 191);
            this.cboxCompanyFlightInformation.Name = "cboxCompanyFlightInformation";
            this.cboxCompanyFlightInformation.Size = new System.Drawing.Size(121, 21);
            this.cboxCompanyFlightInformation.TabIndex = 24;
            // 
            // cboxTransferStatus
            // 
            this.cboxTransferStatus.FormattingEnabled = true;
            this.cboxTransferStatus.Location = new System.Drawing.Point(119, 159);
            this.cboxTransferStatus.Name = "cboxTransferStatus";
            this.cboxTransferStatus.Size = new System.Drawing.Size(121, 21);
            this.cboxTransferStatus.TabIndex = 23;
            // 
            // dTimeLandingDate
            // 
            this.dTimeLandingDate.CustomFormat = "dd-MM-yyyy";
            this.dTimeLandingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimeLandingDate.Location = new System.Drawing.Point(119, 124);
            this.dTimeLandingDate.Name = "dTimeLandingDate";
            this.dTimeLandingDate.Size = new System.Drawing.Size(121, 20);
            this.dTimeLandingDate.TabIndex = 22;
            // 
            // dTimeDepartureDate
            // 
            this.dTimeDepartureDate.CustomFormat = "dd-MM-yyyy";
            this.dTimeDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTimeDepartureDate.Location = new System.Drawing.Point(119, 93);
            this.dTimeDepartureDate.Name = "dTimeDepartureDate";
            this.dTimeDepartureDate.Size = new System.Drawing.Size(121, 20);
            this.dTimeDepartureDate.TabIndex = 21;
            // 
            // cboxLandingPlace
            // 
            this.cboxLandingPlace.FormattingEnabled = true;
            this.cboxLandingPlace.Location = new System.Drawing.Point(119, 57);
            this.cboxLandingPlace.Name = "cboxLandingPlace";
            this.cboxLandingPlace.Size = new System.Drawing.Size(121, 21);
            this.cboxLandingPlace.TabIndex = 20;
            // 
            // cboxDeparturePlace
            // 
            this.cboxDeparturePlace.FormattingEnabled = true;
            this.cboxDeparturePlace.Location = new System.Drawing.Point(119, 24);
            this.cboxDeparturePlace.Name = "cboxDeparturePlace";
            this.cboxDeparturePlace.Size = new System.Drawing.Size(121, 21);
            this.cboxDeparturePlace.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Company";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Transfer Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Landing Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Departure Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Landing Place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Departure Place";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(140, 237);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(100, 25);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm3";
            this.Text = "frm3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeleteNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox cboxCompanyFlightInformation;
        private System.Windows.Forms.ComboBox cboxTransferStatus;
        private System.Windows.Forms.DateTimePicker dTimeLandingDate;
        private System.Windows.Forms.DateTimePicker dTimeDepartureDate;
        private System.Windows.Forms.ComboBox cboxLandingPlace;
        private System.Windows.Forms.ComboBox cboxDeparturePlace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}