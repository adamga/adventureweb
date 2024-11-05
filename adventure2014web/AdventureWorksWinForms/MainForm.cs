using System;
using System.Windows.Forms;

namespace AdventureWorksWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            var menuStrip = new MenuStrip();

            var employeeMenuItem = new ToolStripMenuItem("Employee");
            employeeMenuItem.Click += (sender, e) => OpenForm(new EmployeeForm());

            var employeeDepartmentMenuItem = new ToolStripMenuItem("Employee Department");
            employeeDepartmentMenuItem.Click += (sender, e) => OpenForm(new EmployeeDepartmentForm());

            var employeeDepartmentHistoryMenuItem = new ToolStripMenuItem("Employee Department History");
            employeeDepartmentHistoryMenuItem.Click += (sender, e) => OpenForm(new EmployeeDepartmentHistoryForm());

            var individualCustomerMenuItem = new ToolStripMenuItem("Individual Customer");
            individualCustomerMenuItem.Click += (sender, e) => OpenForm(new IndividualCustomerForm());

            menuStrip.Items.Add(employeeMenuItem);
            menuStrip.Items.Add(employeeDepartmentMenuItem);
            menuStrip.Items.Add(employeeDepartmentHistoryMenuItem);
            menuStrip.Items.Add(individualCustomerMenuItem);

            Controls.Add(menuStrip);
        }

        private void OpenForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
    }
}
