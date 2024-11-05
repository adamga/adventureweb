using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AdventureWorksWinForms.DbContext;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksWinForms.Forms
{
    public partial class IndividualCustomerForm : Form
    {
        private AdventureWorksContext _context;

        public IndividualCustomerForm()
        {
            InitializeComponent();
            _context = new AdventureWorksContext();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var individualCustomers = _context.IndividualCustomers.ToList();
                dataGridViewIndividualCustomers.DataSource = individualCustomers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.dataGridViewIndividualCustomers = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxPhoneNumberType = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.comboBoxAddressType = new System.Windows.Forms.ComboBox();
            this.textBoxAddressLine1 = new System.Windows.Forms.TextBox();
            this.textBoxAddressLine2 = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.comboBoxStateProvince = new System.Windows.Forms.ComboBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.comboBoxCountryRegion = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividualCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIndividualCustomers
            // 
            this.dataGridViewIndividualCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndividualCustomers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewIndividualCustomers.Name = "dataGridViewIndividualCustomers";
            this.dataGridViewIndividualCustomers.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewIndividualCustomers.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 180);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 220);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // comboBoxPhoneNumberType
            // 
            this.comboBoxPhoneNumberType.FormattingEnabled = true;
            this.comboBoxPhoneNumberType.Location = new System.Drawing.Point(12, 260);
            this.comboBoxPhoneNumberType.Name = "comboBoxPhoneNumberType";
            this.comboBoxPhoneNumberType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPhoneNumberType.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(12, 300);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(12, 340);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmailAddress.TabIndex = 5;
            // 
            // comboBoxAddressType
            // 
            this.comboBoxAddressType.FormattingEnabled = true;
            this.comboBoxAddressType.Location = new System.Drawing.Point(12, 380);
            this.comboBoxAddressType.Name = "comboBoxAddressType";
            this.comboBoxAddressType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAddressType.TabIndex = 6;
            // 
            // textBoxAddressLine1
            // 
            this.textBoxAddressLine1.Location = new System.Drawing.Point(12, 420);
            this.textBoxAddressLine1.Name = "textBoxAddressLine1";
            this.textBoxAddressLine1.Size = new System.Drawing.Size(200, 20);
            this.textBoxAddressLine1.TabIndex = 7;
            // 
            // textBoxAddressLine2
            // 
            this.textBoxAddressLine2.Location = new System.Drawing.Point(12, 460);
            this.textBoxAddressLine2.Name = "textBoxAddressLine2";
            this.textBoxAddressLine2.Size = new System.Drawing.Size(200, 20);
            this.textBoxAddressLine2.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(12, 500);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // comboBoxStateProvince
            // 
            this.comboBoxStateProvince.FormattingEnabled = true;
            this.comboBoxStateProvince.Location = new System.Drawing.Point(12, 540);
            this.comboBoxStateProvince.Name = "comboBoxStateProvince";
            this.comboBoxStateProvince.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStateProvince.TabIndex = 10;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(12, 580);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(200, 20);
            this.textBoxPostalCode.TabIndex = 11;
            // 
            // comboBoxCountryRegion
            // 
            this.comboBoxCountryRegion.FormattingEnabled = true;
            this.comboBoxCountryRegion.Location = new System.Drawing.Point(12, 620);
            this.comboBoxCountryRegion.Name = "comboBoxCountryRegion";
            this.comboBoxCountryRegion.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCountryRegion.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 660);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // IndividualCustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxCountryRegion);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.comboBoxStateProvince);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddressLine2);
            this.Controls.Add(this.textBoxAddressLine1);
            this.Controls.Add(this.comboBoxAddressType);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.comboBoxPhoneNumberType);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridViewIndividualCustomers);
            this.Name = "IndividualCustomerForm";
            this.Text = "Individual Customer Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividualCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private System.Windows.Forms.DataGridView dataGridViewIndividualCustomers;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxPhoneNumberType;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.ComboBox comboBoxAddressType;
        private System.Windows.Forms.TextBox textBoxAddressLine1;
        private System.Windows.Forms.TextBox textBoxAddressLine2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.ComboBox comboBoxStateProvince;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.ComboBox comboBoxCountryRegion;
        private System.Windows.Forms.Button buttonSave;
    }
}
