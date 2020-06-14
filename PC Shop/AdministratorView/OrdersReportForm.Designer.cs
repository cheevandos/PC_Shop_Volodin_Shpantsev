namespace AdministratorView
{
    partial class OrdersReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersReportForm));
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ordersReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.createButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.componentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.createReportGroupBox = new System.Windows.Forms.GroupBox();
            this.emailGroupBox = new System.Windows.Forms.GroupBox();
            this.emailPanel.SuspendLayout();
            this.createReportGroupBox.SuspendLayout();
            this.emailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(157, 23);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.startDateTimePicker.TabIndex = 0;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(157, 67);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.endDateTimePicker.TabIndex = 1;
            // 
            // ordersReportViewer
            // 
            this.ordersReportViewer.LocalReport.ReportEmbeddedResource = "AdministratorView.OrdersReport.rdlc";
            this.ordersReportViewer.Location = new System.Drawing.Point(12, 169);
            this.ordersReportViewer.Name = "ordersReportViewer";
            this.ordersReportViewer.ServerReport.BearerToken = null;
            this.ordersReportViewer.ShowBackButton = false;
            this.ordersReportViewer.ShowExportButton = false;
            this.ordersReportViewer.ShowFindControls = false;
            this.ordersReportViewer.ShowPageNavigationControls = false;
            this.ordersReportViewer.ShowPrintButton = false;
            this.ordersReportViewer.Size = new System.Drawing.Size(742, 414);
            this.ordersReportViewer.TabIndex = 2;
            this.ordersReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(10, 100);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(347, 40);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Сформировать";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(6, 100);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(351, 40);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить и отправить на почту";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.ButtonToPdf_Click);
            // 
            // componentLabel
            // 
            this.componentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentLabel.Location = new System.Drawing.Point(6, 23);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(145, 27);
            this.componentLabel.TabIndex = 5;
            this.componentLabel.Text = "Начало периода:";
            this.componentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "конец периода:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailPanel
            // 
            this.emailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailPanel.Controls.Add(this.emailTextBox);
            this.emailPanel.Location = new System.Drawing.Point(6, 54);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(351, 40);
            this.emailPanel.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(9, 7);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(312, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(6, 23);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(163, 27);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email получателя:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createReportGroupBox
            // 
            this.createReportGroupBox.Controls.Add(this.componentLabel);
            this.createReportGroupBox.Controls.Add(this.startDateTimePicker);
            this.createReportGroupBox.Controls.Add(this.endDateTimePicker);
            this.createReportGroupBox.Controls.Add(this.label1);
            this.createReportGroupBox.Controls.Add(this.createButton);
            this.createReportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.createReportGroupBox.Name = "createReportGroupBox";
            this.createReportGroupBox.Size = new System.Drawing.Size(368, 151);
            this.createReportGroupBox.TabIndex = 9;
            this.createReportGroupBox.TabStop = false;
            this.createReportGroupBox.Text = "Данные для отчета";
            // 
            // emailGroupBox
            // 
            this.emailGroupBox.Controls.Add(this.emailLabel);
            this.emailGroupBox.Controls.Add(this.saveButton);
            this.emailGroupBox.Controls.Add(this.emailPanel);
            this.emailGroupBox.Location = new System.Drawing.Point(386, 12);
            this.emailGroupBox.Name = "emailGroupBox";
            this.emailGroupBox.Size = new System.Drawing.Size(368, 151);
            this.emailGroupBox.TabIndex = 10;
            this.emailGroupBox.TabStop = false;
            this.emailGroupBox.Text = "Отправить по почте";
            // 
            // OrdersReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 595);
            this.Controls.Add(this.emailGroupBox);
            this.Controls.Add(this.createReportGroupBox);
            this.Controls.Add(this.ordersReportViewer);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrdersReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по заказам";
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.createReportGroupBox.ResumeLayout(false);
            this.emailGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private Microsoft.Reporting.WinForms.ReportViewer ordersReportViewer;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.GroupBox createReportGroupBox;
        private System.Windows.Forms.GroupBox emailGroupBox;
    }
}