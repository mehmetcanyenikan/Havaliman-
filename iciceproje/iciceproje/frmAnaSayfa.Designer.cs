
namespace iciceproje
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmployeeInformation = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPassengerInformation = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployeeInformation
            // 
            this.btnEmployeeInformation.Location = new System.Drawing.Point(321, 32);
            this.btnEmployeeInformation.Name = "btnEmployeeInformation";
            this.btnEmployeeInformation.Size = new System.Drawing.Size(100, 50);
            this.btnEmployeeInformation.TabIndex = 11;
            this.btnEmployeeInformation.Text = "Employee Information Add";
            this.btnEmployeeInformation.UseVisualStyleBackColor = true;
            this.btnEmployeeInformation.Click += new System.EventHandler(this.btnEmployeeInformation_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "Department Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(533, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPassengerInformation
            // 
            this.btnPassengerInformation.Location = new System.Drawing.Point(215, 32);
            this.btnPassengerInformation.Name = "btnPassengerInformation";
            this.btnPassengerInformation.Size = new System.Drawing.Size(100, 50);
            this.btnPassengerInformation.TabIndex = 8;
            this.btnPassengerInformation.Text = "Passenger Information Add";
            this.btnPassengerInformation.UseVisualStyleBackColor = true;
            this.btnPassengerInformation.Click += new System.EventHandler(this.btnPassengerInformation_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Flight Information Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Location = new System.Drawing.Point(3, 32);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(100, 50);
            this.btnCompanyAdd.TabIndex = 6;
            this.btnCompanyAdd.Text = "Company Add";
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnEmployeeInformation);
            this.panel1.Controls.Add(this.btnCompanyAdd);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnPassengerInformation);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 113);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 301);
            this.panel2.TabIndex = 13;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAnaSayfa";
            this.Text = "Home Page";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeInformation;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPassengerInformation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

