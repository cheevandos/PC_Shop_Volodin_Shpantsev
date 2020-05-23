namespace AdministratorView
{
    partial class RequestCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestCreationForm));
            this.supplierLabel = new System.Windows.Forms.Label();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.componentsGridView = new System.Windows.Forms.DataGridView();
            this.componentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentsLabel = new System.Windows.Forms.Label();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.updateComponentButton = new System.Windows.Forms.Button();
            this.deleteComponentButton = new System.Windows.Forms.Button();
            this.refreshComponentsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.componentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierLabel
            // 
            this.supplierLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierLabel.Location = new System.Drawing.Point(12, 9);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(163, 30);
            this.supplierLabel.TabIndex = 8;
            this.supplierLabel.Text = "Поставщик:";
            this.supplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(12, 42);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(332, 27);
            this.supplierComboBox.TabIndex = 9;
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
            this.componentsGridView.Location = new System.Drawing.Point(12, 156);
            this.componentsGridView.Name = "componentsGridView";
            this.componentsGridView.Size = new System.Drawing.Size(670, 250);
            this.componentsGridView.TabIndex = 10;
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
            // componentsLabel
            // 
            this.componentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentsLabel.Location = new System.Drawing.Point(12, 72);
            this.componentsLabel.Name = "componentsLabel";
            this.componentsLabel.Size = new System.Drawing.Size(163, 30);
            this.componentsLabel.TabIndex = 15;
            this.componentsLabel.Text = "Комплектующие:";
            this.componentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addComponentButton
            // 
            this.addComponentButton.BackColor = System.Drawing.Color.White;
            this.addComponentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addComponentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComponentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addComponentButton.Location = new System.Drawing.Point(12, 103);
            this.addComponentButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(163, 40);
            this.addComponentButton.TabIndex = 11;
            this.addComponentButton.Text = "Добавить";
            this.addComponentButton.UseVisualStyleBackColor = false;
            // 
            // updateComponentButton
            // 
            this.updateComponentButton.BackColor = System.Drawing.Color.White;
            this.updateComponentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateComponentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateComponentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateComponentButton.Location = new System.Drawing.Point(181, 103);
            this.updateComponentButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.updateComponentButton.Name = "updateComponentButton";
            this.updateComponentButton.Size = new System.Drawing.Size(163, 40);
            this.updateComponentButton.TabIndex = 12;
            this.updateComponentButton.Text = "Изменить";
            this.updateComponentButton.UseVisualStyleBackColor = false;
            // 
            // deleteComponentButton
            // 
            this.deleteComponentButton.BackColor = System.Drawing.Color.White;
            this.deleteComponentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteComponentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteComponentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteComponentButton.Location = new System.Drawing.Point(350, 103);
            this.deleteComponentButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.deleteComponentButton.Name = "deleteComponentButton";
            this.deleteComponentButton.Size = new System.Drawing.Size(163, 40);
            this.deleteComponentButton.TabIndex = 13;
            this.deleteComponentButton.Text = "Удалить";
            this.deleteComponentButton.UseVisualStyleBackColor = false;
            // 
            // refreshComponentsButton
            // 
            this.refreshComponentsButton.BackColor = System.Drawing.Color.White;
            this.refreshComponentsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshComponentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.refreshComponentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshComponentsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshComponentsButton.Location = new System.Drawing.Point(519, 103);
            this.refreshComponentsButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.refreshComponentsButton.Name = "refreshComponentsButton";
            this.refreshComponentsButton.Size = new System.Drawing.Size(163, 40);
            this.refreshComponentsButton.TabIndex = 14;
            this.refreshComponentsButton.Text = "Обновить список";
            this.refreshComponentsButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(350, 419);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(332, 40);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 419);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(332, 40);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // RequestCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.componentsLabel);
            this.Controls.Add(this.addComponentButton);
            this.Controls.Add(this.updateComponentButton);
            this.Controls.Add(this.deleteComponentButton);
            this.Controls.Add(this.refreshComponentsButton);
            this.Controls.Add(this.componentsGridView);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.supplierLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая заявка";
            ((System.ComponentModel.ISupportInitialize)(this.componentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.DataGridView componentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentCountColumn;
        private System.Windows.Forms.Label componentsLabel;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.Button updateComponentButton;
        private System.Windows.Forms.Button deleteComponentButton;
        private System.Windows.Forms.Button refreshComponentsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}