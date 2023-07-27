
namespace Remedial_BIRU.View.Forms
{
    partial class WhatsappForm
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.whatsappPictureBox = new System.Windows.Forms.PictureBox();
            this.beautifyPanel4 = new Remedial_BIRU.Template.CustomPanel.BeautifyPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.commonLabel1 = new Remedial_BIRU.View.Labels.CommonLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.beautifyPanel1 = new Remedial_BIRU.Template.CustomPanel.BeautifyPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.counterCommonLabel = new Remedial_BIRU.View.Labels.CommonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.whatsappPictureBox)).BeginInit();
            this.beautifyPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.beautifyPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // whatsappPictureBox
            // 
            this.whatsappPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whatsappPictureBox.Image = global::Remedial_BIRU.Properties.Resources.whatsapp;
            this.whatsappPictureBox.Location = new System.Drawing.Point(700, 6);
            this.whatsappPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.whatsappPictureBox.Name = "whatsappPictureBox";
            this.whatsappPictureBox.Size = new System.Drawing.Size(28, 28);
            this.whatsappPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.whatsappPictureBox.TabIndex = 2;
            this.whatsappPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.whatsappPictureBox, "Kirim data ke whatsapp petugas");
            this.whatsappPictureBox.Click += new System.EventHandler(this.whatsappPictureBox_Click);
            // 
            // beautifyPanel4
            // 
            this.beautifyPanel4.BackColor = System.Drawing.Color.White;
            this.beautifyPanel4.BorderColor = System.Drawing.Color.Empty;
            this.beautifyPanel4.BorderRadius = 30;
            this.beautifyPanel4.BorderWidth = 3;
            this.beautifyPanel4.Controls.Add(this.tableLayoutPanel2);
            this.beautifyPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beautifyPanel4.Location = new System.Drawing.Point(33, 390);
            this.beautifyPanel4.Margin = new System.Windows.Forms.Padding(33, 0, 33, 20);
            this.beautifyPanel4.Name = "beautifyPanel4";
            this.beautifyPanel4.Size = new System.Drawing.Size(734, 40);
            this.beautifyPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.whatsappPictureBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.employeeNumberTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.commonLabel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(734, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeNumberTextBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberTextBox.Location = new System.Drawing.Point(90, 10);
            this.employeeNumberTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(561, 20);
            this.employeeNumberTextBox.TabIndex = 5;
            // 
            // commonLabel1
            // 
            this.commonLabel1.AutoSize = true;
            this.commonLabel1.Font = new System.Drawing.Font("Century", 12F);
            this.commonLabel1.Location = new System.Drawing.Point(3, 0);
            this.commonLabel1.Name = "commonLabel1";
            this.commonLabel1.Size = new System.Drawing.Size(71, 40);
            this.commonLabel1.TabIndex = 6;
            this.commonLabel1.Text = "Nomor Pegawai";
            this.commonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.beautifyPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.beautifyPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // beautifyPanel1
            // 
            this.beautifyPanel1.BackColor = System.Drawing.Color.White;
            this.beautifyPanel1.BorderColor = System.Drawing.Color.Empty;
            this.beautifyPanel1.BorderRadius = 30;
            this.beautifyPanel1.BorderWidth = 3;
            this.beautifyPanel1.Controls.Add(this.tableLayoutPanel3);
            this.beautifyPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beautifyPanel1.Location = new System.Drawing.Point(33, 20);
            this.beautifyPanel1.Margin = new System.Windows.Forms.Padding(33, 20, 33, 20);
            this.beautifyPanel1.Name = "beautifyPanel1";
            this.beautifyPanel1.Size = new System.Drawing.Size(734, 350);
            this.beautifyPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.messageTextRichTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.counterCommonLabel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(734, 350);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // messageTextRichTextBox
            // 
            this.messageTextRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextRichTextBox.Location = new System.Drawing.Point(20, 20);
            this.messageTextRichTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.messageTextRichTextBox.Name = "messageTextRichTextBox";
            this.messageTextRichTextBox.Size = new System.Drawing.Size(694, 290);
            this.messageTextRichTextBox.TabIndex = 1;
            this.messageTextRichTextBox.Text = "";
            this.messageTextRichTextBox.TextChanged += new System.EventHandler(this.messageTextRichTextBox_TextChanged);
            // 
            // counterCommonLabel
            // 
            this.counterCommonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counterCommonLabel.Font = new System.Drawing.Font("Century", 12F);
            this.counterCommonLabel.Location = new System.Drawing.Point(3, 330);
            this.counterCommonLabel.Name = "counterCommonLabel";
            this.counterCommonLabel.Size = new System.Drawing.Size(728, 20);
            this.counterCommonLabel.TabIndex = 2;
            this.counterCommonLabel.Text = "0/700";
            this.counterCommonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WhatsappForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WhatsappForm";
            this.Text = "Whatsapp";
            this.Load += new System.EventHandler(this.WhatsappForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.whatsappPictureBox)).EndInit();
            this.beautifyPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.beautifyPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private Remedial_BIRU.Template.CustomPanel.BeautifyPanel beautifyPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Remedial_BIRU.Template.CustomPanel.BeautifyPanel beautifyPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox whatsappPictureBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private Labels.CommonLabel commonLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox messageTextRichTextBox;
        private Labels.CommonLabel counterCommonLabel;
    }
}