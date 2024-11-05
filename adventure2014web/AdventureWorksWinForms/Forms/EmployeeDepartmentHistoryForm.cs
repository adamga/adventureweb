using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AdventureWorksWinForms.DbContext;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksWinForms.Forms
{
    public partial class EmployeeDepartmentHistoryForm : Form
    {
        private AdventureWorksContext _context;

        public EmployeeDepartmentHistoryForm()
        {
            InitializeComponent();
            _context = new AdventureWorksContext();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var employeeDepartmentHistories = _context.EmployeeDepartmentHistories.ToList();
                dataGridViewEmployeeDepartmentHistories.DataSource = employeeDepartmentHistories;
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
            this.dataGridViewEmployeeDepartmentHistories = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxJobTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDepartmentHistories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeDepartmentHistories
            // 
            this.dataGridViewEmployeeDepartmentHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeDepartmentHistories.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEmployeeDepartmentHistories.Name = "dataGridViewEmployeeDepartmentHistories";
            this.dataGridViewEmployeeDepartmentHistories.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewEmployeeDepartmentHistories.TabIndex = 0;
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
            // comboBoxJobTitle
            // 
            this.comboBoxJobTitle.FormattingEnabled = true;
            this.comboBoxJobTitle.Location = new System.Drawing.Point(12, 260);
            this.comboBoxJobTitle.Name = "comboBoxJobTitle";
            this.comboBoxJobTitle.Size = new System.Drawing.Size(200, 21);
            this.comboBoxJobTitle.TabIndex = 3;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(12, 300);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDepartment.TabIndex = 4;
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Location = new System.Drawing.Point(12, 340);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(200, 21);
            this.comboBoxShift.TabIndex = 5;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(12, 380);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 6;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(12, 420);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 460);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // EmployeeDepartmentHistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.comboBoxShift);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxJobTitle);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridViewEmployeeDepartmentHistories);
            this.Name = "EmployeeDepartmentHistoryForm";
            this.Text = "Employee Department History Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDepartmentHistories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private System.Windows.Forms.DataGridView dataGridViewEmployeeDepartmentHistories;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxJobTitle;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button buttonSave;
    }
}
