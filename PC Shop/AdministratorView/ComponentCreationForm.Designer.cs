namespace AdministratorView
{
    partial class ComponentCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentCreationForm));
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.componentNameTextBox = new System.Windows.Forms.TextBox();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.componentNamePanel = new System.Windows.Forms.Panel();
            this.componentPriceLabel = new System.Windows.Forms.Label();
            this.componentPricePanel = new System.Windows.Forms.Panel();
            this.componentPriceTextBox = new System.Windows.Forms.TextBox();
            this.componentNamePanel.SuspendLayout();
            this.componentPricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 171);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Сохранить";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(181, 171);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // componentNameTextBox
            // 
            this.componentNameTextBox.BackColor = System.Drawing.Color.White;
            this.componentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.componentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentNameTextBox.Location = new System.Drawing.Point(9, 7);
            this.componentNameTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.componentNameTextBox.Name = "componentNameTextBox";
            this.componentNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.componentNameTextBox.TabIndex = 1;
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentNameLabel.Location = new System.Drawing.Point(12, 9);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(163, 30);
            this.componentNameLabel.TabIndex = 4;
            this.componentNameLabel.Text = "Название:";
            this.componentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // componentNamePanel
            // 
            this.componentNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentNamePanel.Controls.Add(this.componentNameTextBox);
            this.componentNamePanel.Location = new System.Drawing.Point(12, 42);
            this.componentNamePanel.Name = "componentNamePanel";
            this.componentNamePanel.Size = new System.Drawing.Size(332, 40);
            this.componentNamePanel.TabIndex = 5;
            // 
            // componentPriceLabel
            // 
            this.componentPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentPriceLabel.Location = new System.Drawing.Point(12, 85);
            this.componentPriceLabel.Name = "componentPriceLabel";
            this.componentPriceLabel.Size = new System.Drawing.Size(163, 30);
            this.componentPriceLabel.TabIndex = 6;
            this.componentPriceLabel.Text = "Цена:";
            this.componentPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // componentPricePanel
            // 
            this.componentPricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentPricePanel.Controls.Add(this.componentPriceTextBox);
            this.componentPricePanel.Location = new System.Drawing.Point(12, 118);
            this.componentPricePanel.Name = "componentPricePanel";
            this.componentPricePanel.Size = new System.Drawing.Size(332, 40);
            this.componentPricePanel.TabIndex = 6;
            // 
            // componentPriceTextBox
            // 
            this.componentPriceTextBox.BackColor = System.Drawing.Color.White;
            this.componentPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.componentPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentPriceTextBox.Location = new System.Drawing.Point(9, 7);
            this.componentPriceTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.componentPriceTextBox.Name = "componentPriceTextBox";
            this.componentPriceTextBox.Size = new System.Drawing.Size(312, 22);
            this.componentPriceTextBox.TabIndex = 1;
            // 
            // ComponentCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 223);
            this.Controls.Add(this.componentPricePanel);
            this.Controls.Add(this.componentPriceLabel);
            this.Controls.Add(this.componentNamePanel);
            this.Controls.Add(this.componentNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComponentCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый компонент";
            this.componentNamePanel.ResumeLayout(false);
            this.componentNamePanel.PerformLayout();
            this.componentPricePanel.ResumeLayout(false);
            this.componentPricePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox componentNameTextBox;
        private System.Windows.Forms.Label componentNameLabel;
        private System.Windows.Forms.Panel componentNamePanel;
        private System.Windows.Forms.Label componentPriceLabel;
        private System.Windows.Forms.Panel componentPricePanel;
        private System.Windows.Forms.TextBox componentPriceTextBox;
    }
}