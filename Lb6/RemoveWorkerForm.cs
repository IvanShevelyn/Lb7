using Lb6.EF;
using Lb6.Models;
using System;
using System.CodeDom;
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
    public partial class RemoveWorkerForm : Form
    {
        private CompanyEntity context = null;
        private int Id = default;
        public RemoveWorkerForm()
        {
            InitializeComponent();
        }
        public RemoveWorkerForm(int WorkerId)
        {
            InitializeComponent();
            Id = WorkerId;
        }

        private void RemoveWorker_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Оберіть спосіб видалення!");
                return;
            }
            if (radioButton1.Checked)
            {
                context = new CompanyEntity();
                Worker w = context.Workers.Find(Id);
                w.Department.Workers.Remove(w);
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                return;
            }

            if (radioButton2.Checked)
            {
                context = new CompanyEntity();
                Worker w = context.Workers.Find(Id);
                context.Workers.Remove(w);
                context.SaveChanges();  
                DialogResult = DialogResult.OK;
                return;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
