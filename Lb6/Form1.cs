using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using Lb6.EF;
using Lb6.Models;
using System.Threading;

namespace Lb6
{
    public partial class Form1 : Form
    {
        private CompanyEntity context = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDepartmentGridView();
        }

        private void DepartmentGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) //update department
        {
            try
            {
                int i = DepartmentGridView.CurrentRow.Index;
                Department d = DepartmentGridView.Rows[i].DataBoundItem as Department;
                context.Departments.AddOrUpdate(d);
                context.Entry(d).State = EntityState.Modified;
                context.SaveChanges();
                UpdateDepartmentGridView();
            }
            catch { UpdateDepartmentGridView(); }
        }

        private void UpdateDepartmentGridView()
        {
            context = new CompanyEntity();
            DepartmentGridView.DataSource = context.Departments.ToList();
            DepartmentGridView.Columns.Remove("Workers");
        }

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            AddDepartmentForm form = new AddDepartmentForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            Department d = new Department
            {
                Name = form.textBox1.Text
            };
            context = new CompanyEntity();
            context.Departments.Add(d);
            context.SaveChanges();
            UpdateDepartmentGridView();
        }

        private void RemoveDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentGridView.SelectedRows.Count == 0 | DepartmentGridView.SelectedRows.Count > 1)
                return;
            Department d = (Department)DepartmentGridView.SelectedRows[0].DataBoundItem;
            foreach (Worker w in context.Workers)
            {
                if (w.Department == d) 
                    w.Department = null;
            }
            context.Departments.Remove(d);
            context.SaveChanges();
            UpdateDepartmentGridView();
        }

        private void WorkerGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = WorkerGridView.CurrentRow.Index;
                Worker w = WorkerGridView.Rows[i].DataBoundItem as Worker;
                context.Workers.AddOrUpdate(w);
                context.Entry(w).State = EntityState.Modified;
                context.SaveChanges();
                UpdateDepartmentGridView();
            }
            catch { UpdateDepartmentGridView(); }       
        }

        private void DepartmentGridView_SelectionChanged(object sender, EventArgs e)
        {
            Department d = (Department)DepartmentGridView.CurrentRow.DataBoundItem;
            WorkerGridView.DataSource = context.Workers.Where(w => w.Department.Id == d.Id).ToList();
            WorkerGridView.Columns.Remove("Department");
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            AddWorkerForm form = new AddWorkerForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            UpdateDepartmentGridView();
        }
        private void WorkerGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void RemoveWorker_Click(object sender, EventArgs e)
        {
            if (WorkerGridView.CurrentRow == null)
                return;
            int i = WorkerGridView.CurrentRow.Index;
            Worker w = WorkerGridView.Rows[i].DataBoundItem as Worker;
            RemoveWorkerForm form = new RemoveWorkerForm(w.Id);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            UpdateDepartmentGridView();
        }

        private void DepartmentGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
