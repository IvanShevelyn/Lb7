using Lb6.EF;
using Lb6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb6
{
    public partial class AddWorkerForm : Form
    {
        private CompanyEntity context = null;
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {
            context = new CompanyEntity();
            dataGridView1.DataSource = context.Workers.Where(w => w.Department == null).ToList();
            dataGridView1.Columns.Remove("Department");
            comboBox1.Items.AddRange(context.Departments.ToArray());
            comboBox1.DisplayMember = "Name";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                dataGridView1.Enabled = false;
                panel1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dataGridView1.Enabled = true;
                panel1.Enabled = false;
            }
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть відділ для робітника!");
                return;
            }
                
            if (radioButton2.Checked)
            {
                if(dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Ви не обрали робітника!");
                    return;
                }
                    
                Worker worker = (Worker)dataGridView1.CurrentRow.DataBoundItem;
                worker.Department = (Department)comboBox1.SelectedItem;
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                return;
            }

            if (radioButton1.Checked)
            {
                int salary = default;
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введіть ім'я для робітника!");
                    return;
                }
                try
                {
                    salary = int.Parse(textBox2.Text);
                    if (salary < 0)
                    {
                        MessageBox.Show("Зарплата не може бути меншою за нуль!");
                        return;
                    }
                    Worker worker = new Worker
                    {
                        Department = (Department)comboBox1.SelectedItem,
                        Name = textBox1.Text,
                        Salary = salary
                    };
                    context.Workers.Add(worker);
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                    return;
                }
                catch { MessageBox.Show("Невірно введені дані!"); }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
