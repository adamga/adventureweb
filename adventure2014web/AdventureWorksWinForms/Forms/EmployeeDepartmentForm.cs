using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AdventureWorksWinForms.DbContext;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksWinForms.Forms
{
    public partial class EmployeeDepartmentForm : Form
    {
        private AdventureWorksContext _context;

        public EmployeeDepartmentForm()
        {
            InitializeComponent();
            _context = new AdventureWorksContext();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var employeeDepartments = _context.EmployeeDepartments.ToList();
                dataGridViewEmployeeDepartments.DataSource = employeeDepartments;
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
            this.dataGridViewEmployeeDepartments = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxJobTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeDepartments
            // 
            this.dataGridViewEmployeeDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeDepartments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEmployeeDepartments.Name = "dataGridViewEmployeeDepartments";
            this.dataGridViewEmployeeDepartments.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewEmployeeDepartments.TabIndex = 0;
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
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(12, 340);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 380);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // EmployeeDepartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxJobTitle);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridViewEmployeeDepartments);
            this.Name = "EmployeeDepartmentForm";
            this.Text = "Employee Department Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private System.Windows.Forms.DataGridView dataGridViewEmployeeDepartments;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxJobTitle;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button buttonSave;
    }
}
