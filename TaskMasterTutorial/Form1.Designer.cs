namespace TaskMasterTutorial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdCreateTasks = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDeleteTask = new System.Windows.Forms.Button();
            this.cmdCancelTask = new System.Windows.Forms.Button();
            this.cmdUpdateTask = new System.Windows.Forms.Button();
            this.cmdCreateTask = new System.Windows.Forms.Button();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textTask = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmdCreateTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // cmdCreateTasks
            // 
            this.cmdCreateTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCreateTasks.Controls.Add(this.label3);
            this.cmdCreateTasks.Controls.Add(this.label2);
            this.cmdCreateTasks.Controls.Add(this.label1);
            this.cmdCreateTasks.Controls.Add(this.cmdDeleteTask);
            this.cmdCreateTasks.Controls.Add(this.cmdCancelTask);
            this.cmdCreateTasks.Controls.Add(this.cmdUpdateTask);
            this.cmdCreateTasks.Controls.Add(this.cmdCreateTask);
            this.cmdCreateTasks.Controls.Add(this.cBoxStatus);
            this.cmdCreateTasks.Controls.Add(this.dateTimePicker1);
            this.cmdCreateTasks.Controls.Add(this.textTask);
            this.cmdCreateTasks.Location = new System.Drawing.Point(12, 12);
            this.cmdCreateTasks.Name = "cmdCreateTasks";
            this.cmdCreateTasks.Size = new System.Drawing.Size(576, 115);
            this.cmdCreateTasks.TabIndex = 1;
            this.cmdCreateTasks.TabStop = false;
            this.cmdCreateTasks.Text = "Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Due date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task";
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Location = new System.Drawing.Point(352, 52);
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteTask.TabIndex = 6;
            this.cmdDeleteTask.Text = "Delete";
            this.cmdDeleteTask.UseVisualStyleBackColor = true;
            this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
            // 
            // cmdCancelTask
            // 
            this.cmdCancelTask.Location = new System.Drawing.Point(271, 81);
            this.cmdCancelTask.Name = "cmdCancelTask";
            this.cmdCancelTask.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelTask.TabIndex = 5;
            this.cmdCancelTask.Text = "Cancel";
            this.cmdCancelTask.UseVisualStyleBackColor = true;
            this.cmdCancelTask.Click += new System.EventHandler(this.cmdCancelTask_Click);
            // 
            // cmdUpdateTask
            // 
            this.cmdUpdateTask.Location = new System.Drawing.Point(271, 52);
            this.cmdUpdateTask.Name = "cmdUpdateTask";
            this.cmdUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateTask.TabIndex = 4;
            this.cmdUpdateTask.Text = "Update";
            this.cmdUpdateTask.UseVisualStyleBackColor = true;
            this.cmdUpdateTask.Click += new System.EventHandler(this.cmdUpdateTask_Click);
            // 
            // cmdCreateTask
            // 
            this.cmdCreateTask.Location = new System.Drawing.Point(190, 52);
            this.cmdCreateTask.Name = "cmdCreateTask";
            this.cmdCreateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateTask.TabIndex = 3;
            this.cmdCreateTask.Text = "Create";
            this.cmdCreateTask.UseVisualStyleBackColor = true;
            this.cmdCreateTask.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Location = new System.Drawing.Point(56, 52);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(128, 23);
            this.cBoxStatus.TabIndex = 2;
            this.cBoxStatus.Text = "Please select...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(468, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textTask
            // 
            this.textTask.Location = new System.Drawing.Point(56, 22);
            this.textTask.Name = "textTask";
            this.textTask.Size = new System.Drawing.Size(269, 23);
            this.textTask.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 325);
            this.Controls.Add(this.cmdCreateTasks);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(616, 364);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Master";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmdCreateTasks.ResumeLayout(false);
            this.cmdCreateTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox cmdCreateTasks;
        private System.Windows.Forms.TextBox textTask;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdCancelTask;
        private System.Windows.Forms.Button cmdUpdateTask;
        private System.Windows.Forms.Button cmdCreateTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

