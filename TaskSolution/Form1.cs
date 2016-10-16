using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaskSolution.Manager;
using TaskSolution.Models;

namespace TaskSolution
{
    public partial class TaskSolution : Form
    {
        EmployeeManager employeeController = new EmployeeManager();
        public TaskSolution()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            employeeController.SaveFile();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

            label1.Text = employeeController.OpenFile();
            PrintEmployeeList(employeeController.listEmployee);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            EmployeeDataGrid.Rows.Clear();
            string name = SearchField.Text;
            PrintEmployeeList(employeeController.GetByName(name));
           
        }

        private void SortByAscButton_Click(object sender, EventArgs e)
        {
            employeeController.SortListByAscending();
            PrintEmployeeList(employeeController.listEmployee);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintEmployeeList(employeeController.listEmployee);
        }

        private void SortByDesButton_Click(object sender, EventArgs e)
        {
            employeeController.SortListByDescending();
            PrintEmployeeList(employeeController.listEmployee);
        }

        private void FirstFiveButton_Click(object sender, EventArgs e)
        {
            EmployeeDataGrid.Rows.Clear();
            EmployeeDataGrid.Columns.Clear();
            EmployeeDataGrid.Columns.Add("EmployeeName", "Name");

            int i = 0;
            foreach (var x in employeeController.GetFirstFive())
            {
                EmployeeDataGrid.Rows.Add();
                EmployeeDataGrid.Rows[i].Cells[0].Value = x.Name;
                i++;
            }
        }

        private void LastThreeButton_Click(object sender, EventArgs e)
        {
            EmployeeDataGrid.Rows.Clear();
            EmployeeDataGrid.Columns.Clear();
            EmployeeDataGrid.Columns.Add("Id", "Id");
            int i = 0;
            foreach (var x in employeeController.GetLastThree())
            {
                EmployeeDataGrid.Rows.Add();
                EmployeeDataGrid.Rows[i].Cells[0].Value = x.Id;
                i++;
            }
        }

        private void PrintEmployeeList(List<Employee> list)
        {
            int i = 0;
            EmployeeDataGrid.Rows.Clear();
            if(EmployeeDataGrid.Columns.Count != 3)
            {
                EmployeeDataGrid.Columns.Clear();
                EmployeeDataGrid.Columns.Add("Id", "Id");
                EmployeeDataGrid.Columns.Add("EmployeeName", "Name");
                EmployeeDataGrid.Columns.Add("Payment", "Payment");
            }
            
            foreach (var Employeer in list)
            {
                EmployeeDataGrid.Rows.Add();
                EmployeeDataGrid.Rows[i].Cells[0].Value = Employeer.Id;
                EmployeeDataGrid.Rows[i].Cells[1].Value = Employeer.Name;
                EmployeeDataGrid.Rows[i].Cells[2].Value = Employeer.GetAverageSalary();
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDataGrid.Columns.Clear();
            EmployeeDataGrid.Columns.Add("Id", "Id");
        }
    }
}
