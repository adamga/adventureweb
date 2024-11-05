using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AdventureWorksWinForms.DbContext;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksWinForms.Forms
{
    public partial class EmployeeForm : Form
    {
        private AdventureWorksContext _context;

        public EmployeeForm()
        {
            InitializeComponent();
            _context = new AdventureWorksContext();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var employees = _context.Employees.ToList();
                dataGridViewEmployees.DataSource = employees;
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxJobTitle = new System.Windows.Forms.ComboBox();
            this.dateTimePickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCurrentFlag = new System.Windows.Forms.CheckBox();
            this.numericUpDownVacationHours = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVacationHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewEmployees.TabIndex = 0;
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
            // dateTimePickerHireDate
            // 
            this.dateTimePickerHireDate.Location = new System.Drawing.Point(12, 300);
            this.dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            this.dateTimePickerHireDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHireDate.TabIndex = 4;
            // 
            // checkBoxCurrentFlag
            // 
            this.checkBoxCurrentFlag.AutoSize = true;
            this.checkBoxCurrentFlag.Location = new System.Drawing.Point(12, 340);
            this.checkBoxCurrentFlag.Name = "checkBoxCurrentFlag";
            this.checkBoxCurrentFlag.Size = new System.Drawing.Size(84, 17);
            this.checkBoxCurrentFlag.TabIndex = 5;
            this.checkBoxCurrentFlag.Text = "Current Flag";
            this.checkBoxCurrentFlag.UseVisualStyleBackColor = true;
            // 
            // numericUpDownVacationHours
            // 
            this.numericUpDownVacationHours.Location = new System.Drawing.Point(12, 380);
            this.numericUpDownVacationHours.Name = "numericUpDownVacationHours";
            this.numericUpDownVacationHours.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownVacationHours.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 420);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // EmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownVacationHours);
            this.Controls.Add(this.checkBoxCurrentFlag);
            this.Controls.Add(this.dateTimePickerHireDate);
            this.Controls.Add(this.comboBoxJobTitle);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "EmployeeForm";
            this.Text = "Employee Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVacationHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxJobTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerHireDate;
        private System.Windows.Forms.CheckBox checkBoxCurrentFlag;
        private System.Windows.Forms.NumericUpDown numericUpDownVacationHours;
        private System.Windows.Forms.Button buttonSave;
    }
}
