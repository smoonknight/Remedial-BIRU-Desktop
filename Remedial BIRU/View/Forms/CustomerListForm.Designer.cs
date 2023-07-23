
namespace Remedial_BIRU.View.Forms
{
    partial class CustomerListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.visitButton = new System.Windows.Forms.Button();
            this.customerListUserControl1 = new Remedial_BIRU.View.UserControls.CustomerListUserControl();
            this.headerPanel.SuspendLayout();
            this.headerTableLayoutPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(784, 44);
            this.headerPanel.TabIndex = 2;
            // 
            // headerTableLayoutPanel
            // 
            this.headerTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.headerTableLayoutPanel.ColumnCount = 3;
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.headerTableLayoutPanel.Controls.Add(this.visitButton, 1, 0);
            this.headerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.headerTableLayoutPanel.Name = "headerTableLayoutPanel";
            this.headerTableLayoutPanel.RowCount = 1;
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTableLayoutPanel.Size = new System.Drawing.Size(784, 44);
            this.headerTableLayoutPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remedial BIRU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitButton
            // 
            this.visitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitButton.FlatAppearance.BorderSize = 0;
            this.visitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitButton.Location = new System.Drawing.Point(100, 0);
            this.visitButton.Margin = new System.Windows.Forms.Padding(0);
            this.visitButton.Name = "visitButton";
            this.visitButton.Size = new System.Drawing.Size(80, 44);
            this.visitButton.TabIndex = 6;
            this.visitButton.Text = "Kunjungan";
            this.visitButton.UseVisualStyleBackColor = true;
            this.visitButton.Click += new System.EventHandler(this.visitButton_Click);
            // 
            // customerListUserControl1
            // 
            this.customerListUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.customerListUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerListUserControl1.Location = new System.Drawing.Point(0, 44);
            this.customerListUserControl1.Name = "customerListUserControl1";
            this.customerListUserControl1.Size = new System.Drawing.Size(784, 517);
            this.customerListUserControl1.TabIndex = 0;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.customerListUserControl1);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CustomerListForm";
            this.Text = "Remedial BIRU";
            this.headerPanel.ResumeLayout(false);
            this.headerTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.CustomerListUserControl customerListUserControl1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel headerTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button visitButton;
    }
}