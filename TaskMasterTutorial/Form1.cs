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
                cBoxStatus.Items.Add(s.Name);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
