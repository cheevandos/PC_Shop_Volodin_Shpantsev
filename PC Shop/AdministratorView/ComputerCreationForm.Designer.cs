namespace AdministratorView
{
    partial class ComputerCreationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerCreationForm));
            this.componentsGridView = new System.Windows.Forms.DataGridView();
            this.componentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.updateComponentButton = new System.Windows.Forms.Button();
            this.deleteComponentButton = new System.Windows.Forms.Button();
            this.refreshComponentsButton = new System.Windows.Forms.Button();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.computerNamePanel = new System.Windows.Forms.Panel();
            this.computerNameTextBox = new System.Windows.Forms.TextBox();
            this.computerPriceLabel = new System.Windows.Forms.Label();
            this.computerPricePanel = new System.Windows.Forms.Panel();
            this.computerPriceTextBox = new System.Windows.Forms.TextBox();
            this.componentsLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.componentsGridView)).BeginInit();
            this.computerNamePanel.SuspendLayout();
            this.computerPricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // componentsGridView
            // 
            this.componentsGridView.AllowUserToAddRows = false;
            this.componentsGridView.AllowUserToDeleteRows = false;
            this.componentsGridView.AllowUserToResizeRows = false;
            this.componentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.componentsGridView.BackgroundColor = System.Drawing.Color.White;
            this.componentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.componentID,
            this.componentNameColumn,
            this.componentCountColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.componentsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.componentsGridView.Location = new System.Drawing.Point(12, 171);
            this.componentsGridView.Name = "componentsGridView";
            this.componentsGridView.ReadOnly = true;
            this.componentsGridView.Size = new System.Drawing.Size(670, 250);
            this.componentsGridView.TabIndex = 1;
            // 
            // componentID
            // 
            this.componentID.HeaderText = "ID";
            this.componentID.Name = "componentID";
            this.componentID.ReadOnly = true;
            this.componentID.Visible = false;
            // 
            // componentNameColumn
            // 
            this.componentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.componentNameColumn.FillWeight = 80F;
            this.componentNameColumn.HeaderText = "Название";
            this.componentNameColumn.Name = "componentNameColumn";
            this.componentNameColumn.ReadOnly = true;
            // 
            // componentCountColumn
            // 
            this.componentCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.componentCountColumn.FillWeight = 20F;
            this.componentCountColumn.HeaderText = "Количество";
            this.componentCountColumn.Name = "componentCountColumn";
            this.componentCountColumn.ReadOnly = true;
            // 
            // addComponentButton
            // 
            this.addComponentButton.BackColor = System.Drawing.Color.White;
            this.addComponentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addComponentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComponentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addComponentButton.Location = new System.Drawing.Point(12, 118);
            this.addComponentButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(163, 40);
            this.addComponentButton.TabIndex = 2;
            this.addComponentButton.Text = "Добавить";
            this.addComponentButton.UseVisualStyleBackColor = false;
            this.addComponentButton.Click += new System.EventHandler(this.AddComponentButton_Click);
            // 
            // updateComponentButton
            // 
            this.updateComponentButton.BackColor = System.Drawing.Color.White;
            this.updateComponentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateComponentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateComponentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateComponentButton.Location = new System.Drawing.Point(181, 118);
            this.updateComponentButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.updateComponentButton.Name = "updateComponentButton";
            this.updateComponentButton.Size = new System.Drawing.Size(163, 40);
            this.updateComponentButton.TabIndex = 3;
            this.updateComponentButton.Text = "Изменить";
            this.updateComponentButton.UseVisualStyleBackColor = false;
            this.updateComponentButton.Click += new System.EventHandler(this.UpdateComponentButton_Click);
            // 
            // deleteComponentButton
            // 
            this.deleteComponentButton.BackColor = System.Drawing.Color.White;
            this.deleteComponentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteComponentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteComponentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteComponentButton.Location = new System.Drawing.Point(350, 118);
            this.deleteComponentButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.deleteComponentButton.Name = "deleteComponentButton";
            this.deleteComponentButton.Size = new System.Drawing.Size(163, 40);
            this.deleteComponentButton.TabIndex = 4;
            this.deleteComponentButton.Text = "Удалить";
            this.deleteComponentButton.UseVisualStyleBackColor = false;
            this.deleteComponentButton.Click += new System.EventHandler(this.DeleteComponentButton_Click);
            // 
            // refreshComponentsButton
            // 
            this.refreshComponentsButton.BackColor = System.Drawing.Color.White;
            this.refreshComponentsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshComponentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.refreshComponentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshComponentsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshComponentsButton.Location = new System.Drawing.Point(519, 118);
            this.refreshComponentsButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.refreshComponentsButton.Name = "refreshComponentsButton";
            this.refreshComponentsButton.Size = new System.Drawing.Size(163, 40);
            this.refreshComponentsButton.TabIndex = 5;
            this.refreshComponentsButton.Text = "Обновить список";
            this.refreshComponentsButton.UseVisualStyleBackColor = false;
            this.refreshComponentsButton.Click += new System.EventHandler(this.RefreshComponentsButton_Click);
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerNameLabel.Location = new System.Drawing.Point(8, 9);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(163, 30);
            this.computerNameLabel.TabIndex = 6;
            this.computerNameLabel.Text = "Название:";
            this.computerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // computerNamePanel
            // 
            this.computerNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerNamePanel.Controls.Add(this.computerNameTextBox);
            this.computerNamePanel.Location = new System.Drawing.Point(12, 42);
            this.computerNamePanel.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.computerNamePanel.Name = "computerNamePanel";
            this.computerNamePanel.Size = new System.Drawing.Size(332, 40);
            this.computerNamePanel.TabIndex = 7;
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.BackColor = System.Drawing.Color.White;
            this.computerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerNameTextBox.Location = new System.Drawing.Point(9, 7);
            this.computerNameTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.computerNameTextBox.TabIndex = 1;
            // 
            // computerPriceLabel
            // 
            this.computerPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerPriceLabel.Location = new System.Drawing.Point(346, 9);
            this.computerPriceLabel.Name = "computerPriceLabel";
            this.computerPriceLabel.Size = new System.Drawing.Size(163, 30);
            this.computerPriceLabel.TabIndex = 8;
            this.computerPriceLabel.Text = "Цена:";
            this.computerPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // computerPricePanel
            // 
            this.computerPricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerPricePanel.Controls.Add(this.computerPriceTextBox);
            this.computerPricePanel.Location = new System.Drawing.Point(350, 42);
            this.computerPricePanel.Name = "computerPricePanel";
            this.computerPricePanel.Size = new System.Drawing.Size(332, 40);
            this.computerPricePanel.TabIndex = 9;
            // 
            // computerPriceTextBox
            // 
            this.computerPriceTextBox.BackColor = System.Drawing.Color.White;
            this.computerPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerPriceTextBox.Enabled = false;
            this.computerPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerPriceTextBox.Location = new System.Drawing.Point(9, 7);
            this.computerPriceTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.computerPriceTextBox.Name = "computerPriceTextBox";
            this.computerPriceTextBox.ReadOnly = true;
            this.computerPriceTextBox.Size = new System.Drawing.Size(312, 22);
            this.computerPriceTextBox.TabIndex = 1;
            // 
            // componentsLabel
            // 
            this.componentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentsLabel.Location = new System.Drawing.Point(12, 85);
            this.componentsLabel.Name = "componentsLabel";
            this.componentsLabel.Size = new System.Drawing.Size(163, 30);
            this.componentsLabel.TabIndex = 10;
            this.componentsLabel.Text = "Комплектующие:";
            this.componentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 434);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(332, 40);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(350, 434);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(332, 40);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ComputerCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 486);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.componentsLabel);
            this.Controls.Add(this.addComponentButton);
            this.Controls.Add(this.updateComponentButton);
            this.Controls.Add(this.componentsGridView);
            this.Controls.Add(this.deleteComponentButton);
            this.Controls.Add(this.refreshComponentsButton);
            this.Controls.Add(this.computerPricePanel);
            this.Controls.Add(this.computerPriceLabel);
            this.Controls.Add(this.computerNamePanel);
            this.Controls.Add(this.computerNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComputerCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый ПК";
            this.Load += new System.EventHandler(this.ComputerCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.componentsGridView)).EndInit();
            this.computerNamePanel.ResumeLayout(false);
            this.computerNamePanel.PerformLayout();
            this.computerPricePanel.ResumeLayout(false);
            this.computerPricePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView componentsGridView;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.Button updateComponentButton;
        private System.Windows.Forms.Button deleteComponentButton;
        private System.Windows.Forms.Button refreshComponentsButton;
        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.Panel computerNamePanel;
        private System.Windows.Forms.TextBox computerNameTextBox;
        private System.Windows.Forms.Label computerPriceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentCountColumn;
        private System.Windows.Forms.Panel computerPricePanel;
        private System.Windows.Forms.TextBox computerPriceTextBox;
        private System.Windows.Forms.Label componentsLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}