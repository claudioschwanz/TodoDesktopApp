using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMasterTutorial.Models;

namespace TaskMasterTutorial
{
    public partial class Form1 : Form
    {
        private DBTASK_MASTERContext tmDbContext;
        public Form1()
        {
            InitializeComponent();

            tmDbContext = new DBTASK_MASTERContext();

            var statuses = tmDbContext.Statuses.ToList();

            foreach(Status s in statuses)
            {
                cBoxStatus.Items.Add(s);
            }
            refreshData();
        }

        public void refreshData()
        {
            BindingSource bi = new BindingSource();

            var query = from t in tmDbContext.Taskes
                        orderby t.DueDate
                        select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };

            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }


        private void cmdCreateTask_Click(object sender, EventArgs e)
        {
            if(cBoxStatus.SelectedItem != null && textTask.Text != String.Empty)
            {
                var newTask = new Models.Task()
                {
                    Name = textTask.Text,
                    StatusId = (cBoxStatus.SelectedItem as Models.Status).Id,
                    DueDate = dateTimePicker1.Value
                };

                tmDbContext.Taskes.Add(newTask);

                tmDbContext.SaveChanges();
                refreshData();


            } else
            {
                MessageBox.Show("Please make sure all data has been entered!");
            }
        }

        private void cmdDeleteTask_Click(object sender, EventArgs e)
        {
            var t = tmDbContext.Taskes.Find((int)dataGridView1.SelectedCells[0].Value);

            tmDbContext.Taskes.Remove(t);
            tmDbContext.SaveChanges();
            refreshData();


        }

        private void cmdUpdateTask_Click(object sender, EventArgs e)
        {
            if(cmdUpdateTask.Text == "Update")
            {
                textTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[3].Value;
                foreach(Status s in cBoxStatus.Items)
                {
                    if(s.Name == dataGridView1.SelectedCells[2].Value.ToString())
                    {
                        cBoxStatus.SelectedItem = s;
                    }
                }
                cmdUpdateTask.Text = "Save";
            } else if (cmdUpdateTask.Text == "Save")
            {
                var t = tmDbContext.Taskes.Find((int)dataGridView1.SelectedCells[0].Value);
                t.Name = textTask.Text;
                t.StatusId = (cBoxStatus.SelectedItem as Status).Id;
                t.DueDate = dateTimePicker1.Value;

                tmDbContext.SaveChanges();

                refreshData();

                cmdUpdateTask.Text = "Update";
                textTask.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                cBoxStatus.Text = "Please select...";
                
            }
        }

        private void cmdCancelTask_Click(object sender, EventArgs e)
        {

            refreshData();

            cmdUpdateTask.Text = "Update";
            textTask.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cBoxStatus.Text = "Please select...";
        }
    }
}
