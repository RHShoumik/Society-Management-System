namespace TutionManagementSystem.Views
{
    partial class AdminView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.toolStripMenuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPendingRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.Students = new System.Windows.Forms.MenuStrip();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItemHome
            // 
            this.toolStripMenuItemHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.toolStripMenuItemHome.Name = "toolStripMenuItemHome";
            this.toolStripMenuItemHome.Size = new System.Drawing.Size(100, 24);
            this.toolStripMenuItemHome.Text = "Home Page";
            this.toolStripMenuItemHome.Click += new System.EventHandler(this.toolStripMenuItemHome_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MenuItemCourse
            // 
            this.MenuItemCourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem});
            this.MenuItemCourse.Name = "MenuItemCourse";
            this.MenuItemCourse.Size = new System.Drawing.Size(68, 24);
            this.MenuItemCourse.Text = "Course";
            this.MenuItemCourse.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // MenuItemTeacher
            // 
            this.MenuItemTeacher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeacherToolStripMenuItem});
            this.MenuItemTeacher.Name = "MenuItemTeacher";
            this.MenuItemTeacher.Size = new System.Drawing.Size(80, 24);
            this.MenuItemTeacher.Text = "Teachers";
            this.MenuItemTeacher.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // addTeacherToolStripMenuItem
            // 
            this.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            this.addTeacherToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addTeacherToolStripMenuItem.Text = "Add Teacher";
            this.addTeacherToolStripMenuItem.Click += new System.EventHandler(this.addTeacherToolStripMenuItem_Click);
            // 
            // MenuItemStudent
            // 
            this.MenuItemStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem});
            this.MenuItemStudent.Name = "MenuItemStudent";
            this.MenuItemStudent.Size = new System.Drawing.Size(80, 24);
            this.MenuItemStudent.Text = "Students";
            this.MenuItemStudent.Click += new System.EventHandler(this.MenuItemStudent_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // MenuItemEmployees
            // 
            this.MenuItemEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.MenuItemEmployees.Name = "MenuItemEmployees";
            this.MenuItemEmployees.Size = new System.Drawing.Size(95, 24);
            this.MenuItemEmployees.Text = "Employees";
            this.MenuItemEmployees.Click += new System.EventHandler(this.MenuItemEmployees_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // MenuItemPendingRequest
            // 
            this.MenuItemPendingRequest.Name = "MenuItemPendingRequest";
            this.MenuItemPendingRequest.Size = new System.Drawing.Size(139, 24);
            this.MenuItemPendingRequest.Text = "Pending Requests";
            this.MenuItemPendingRequest.Click += new System.EventHandler(this.MenuItemPendingRequest_Click);
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.Transparent;
            this.Students.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Students.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHome,
            this.MenuItemCourse,
            this.MenuItemTeacher,
            this.MenuItemStudent,
            this.MenuItemEmployees,
            this.MenuItemPendingRequest,
            this.deleteUserToolStripMenuItem});
            this.Students.Location = new System.Drawing.Point(0, 0);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(905, 28);
            this.Students.TabIndex = 7;
            this.Students.Text = "menuStrip1";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(7, 273);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.RowHeadersWidth = 51;
            this.dataGridViewAll.RowTemplate.Height = 24;
            this.dataGridViewAll.Size = new System.Drawing.Size(892, 371);
            this.dataGridViewAll.TabIndex = 8;
            this.dataGridViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAll_CellContentClick);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 651);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.Students);
            this.MainMenuStrip = this.Students;
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.Students.ResumeLayout(false);
            this.Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHome;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCourse;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTeacher;
        private System.Windows.Forms.ToolStripMenuItem addTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEmployees;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPendingRequest;
        private System.Windows.Forms.MenuStrip Students;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}