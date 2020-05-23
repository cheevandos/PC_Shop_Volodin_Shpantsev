namespace AdministratorView
{
    partial class ComponentAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentAddingForm));
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.componentLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.countPanel = new System.Windows.Forms.Panel();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.countPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 158);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(163, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(181, 158);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // componentLabel
            // 
            this.componentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentLabel.Location = new System.Drawing.Point(12, 9);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(163, 30);
            this.componentLabel.TabIndex = 4;
            this.componentLabel.Text = "Комплектующее:";
            this.componentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countLabel
            // 
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(12, 72);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(163, 30);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Количество:";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countPanel
            // 
            this.countPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countPanel.Controls.Add(this.countTextBox);
            this.countPanel.Location = new System.Drawing.Point(12, 105);
            this.countPanel.Name = "countPanel";
            this.countPanel.Size = new System.Drawing.Size(332, 40);
            this.countPanel.TabIndex = 6;
            // 
            // countTextBox
            // 
            this.countTextBox.BackColor = System.Drawing.Color.White;
            this.countTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTextBox.Location = new System.Drawing.Point(9, 7);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(312, 22);
            this.countTextBox.TabIndex = 1;
            // 
            // componentComboBox
            // 
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Location = new System.Drawing.Point(12, 42);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(332, 27);
            this.componentComboBox.TabIndex = 7;
            // 
            // ComponentAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 210);
            this.Controls.Add(this.componentComboBox);
            this.Controls.Add(this.countPanel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.componentLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComponentAddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить комплектующее";
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Panel countPanel;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.ComboBox componentComboBox;
    }
}