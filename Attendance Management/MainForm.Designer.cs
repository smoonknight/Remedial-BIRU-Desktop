
namespace Attendance_Management
{
    partial class MainForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.overviewUserControl1 = new Attendance_Management.View.UserControls.OverviewUserControl();
            this.manageUserControl1 = new Attendance_Management.View.UserControls.ManageUserControl();
            this.employeeListUserControl1 = new Attendance_Management.View.UserControls.EmployeeListUserControl();
            this.headerPanel.SuspendLayout();
            this.headerTableLayoutPanel.SuspendLayout();
            this.profileTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.headerPanel.Controls.Add(this.headerTableLayoutPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(909, 44);
            this.headerPanel.TabIndex = 1;
            // 
            // headerTableLayoutPanel
            // 
            this.headerTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.headerTableLayoutPanel.ColumnCount = 10;
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.headerTableLayoutPanel.Controls.Add(this.button4, 4, 0);
            this.headerTableLayoutPanel.Controls.Add(this.button3, 3, 0);
            this.headerTableLayoutPanel.Controls.Add(this.button2, 2, 0);
            this.headerTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.headerTableLayoutPanel.Controls.Add(this.profileTableLayoutPanel, 9, 0);
            this.headerTableLayoutPanel.Controls.Add(this.button1, 1, 0);
            this.headerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.headerTableLayoutPanel.Name = "headerTableLayoutPanel";
            this.headerTableLayoutPanel.RowCount = 1;
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTableLayoutPanel.Size = new System.Drawing.Size(909, 44);
            this.headerTableLayoutPanel.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(360, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Reports";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(240, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Employee\'s List";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(170, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Manage";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileTableLayoutPanel
            // 
            this.profileTableLayoutPanel.ColumnCount = 3;
            this.profileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.profileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.profileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.profileTableLayoutPanel.Controls.Add(this.label5, 2, 0);
            this.profileTableLayoutPanel.Controls.Add(this.adminNameLabel, 1, 0);
            this.profileTableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.profileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTableLayoutPanel.Location = new System.Drawing.Point(712, 3);
            this.profileTableLayoutPanel.Name = "profileTableLayoutPanel";
            this.profileTableLayoutPanel.RowCount = 1;
            this.profileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.profileTableLayoutPanel.Size = new System.Drawing.Size(194, 38);
            this.profileTableLayoutPanel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "V";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminNameLabel.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNameLabel.Location = new System.Drawing.Point(44, 0);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(123, 38);
            this.adminNameLabel.TabIndex = 3;
            this.adminNameLabel.Text = "Admin";
            this.adminNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 32);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Overview";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // overviewUserControl1
            // 
            this.overviewUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.overviewUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewUserControl1.ForeColor = System.Drawing.Color.Black;
            this.overviewUserControl1.Location = new System.Drawing.Point(0, 44);
            this.overviewUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.overviewUserControl1.Name = "overviewUserControl1";
            this.overviewUserControl1.Size = new System.Drawing.Size(909, 517);
            this.overviewUserControl1.TabIndex = 3;
            // 
            // manageUserControl1
            // 
            this.manageUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.manageUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageUserControl1.ForeColor = System.Drawing.Color.Black;
            this.manageUserControl1.Location = new System.Drawing.Point(0, 44);
            this.manageUserControl1.Name = "manageUserControl1";
            this.manageUserControl1.Size = new System.Drawing.Size(909, 517);
            this.manageUserControl1.TabIndex = 4;
            // 
            // employeeListUserControl1
            // 
            this.employeeListUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.employeeListUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeListUserControl1.ForeColor = System.Drawing.Color.Black;
            this.employeeListUserControl1.Location = new System.Drawing.Point(0, 44);
            this.employeeListUserControl1.Name = "employeeListUserControl1";
            this.employeeListUserControl1.Size = new System.Drawing.Size(909, 517);
            this.employeeListUserControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 561);
            this.Controls.Add(this.employeeListUserControl1);
            this.Controls.Add(this.manageUserControl1);
            this.Controls.Add(this.overviewUserControl1);
            this.Controls.Add(this.headerPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "Attendance Management";
            this.headerPanel.ResumeLayout(false);
            this.headerTableLayoutPanel.ResumeLayout(false);
            this.profileTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel headerTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel profileTableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private View.UserControls.OverviewUserControl overviewUserControl1;
        private View.UserControls.ManageUserControl manageUserControl1;
        private View.UserControls.EmployeeListUserControl employeeListUserControl1;
    }
}
