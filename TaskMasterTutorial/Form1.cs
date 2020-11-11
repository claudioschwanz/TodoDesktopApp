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


            } else
            {
                MessageBox.Show("Please make sure all data has been entered!");
            }
        }
    }
}
