namespace AdministratorView
{
    partial class OrderCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCreationForm));
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.computerLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.countPanel = new System.Windows.Forms.Panel();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.computerComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountPanel = new System.Windows.Forms.Panel();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.countPanel.SuspendLayout();
            this.amountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 237);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(181, 237);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // computerLabel
            // 
            this.computerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerLabel.Location = new System.Drawing.Point(12, 9);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(163, 30);
            this.computerLabel.TabIndex = 4;
            this.computerLabel.Text = "ПК:";
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // computerComboBox
            // 
            this.computerComboBox.FormattingEnabled = true;
            this.computerComboBox.Location = new System.Drawing.Point(12, 42);
            this.computerComboBox.Name = "computerComboBox";
            this.computerComboBox.Size = new System.Drawing.Size(332, 27);
            this.computerComboBox.TabIndex = 7;
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(12, 148);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(163, 30);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Сумма заказа:";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amountPanel
            // 
            this.amountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountPanel.Controls.Add(this.amountTextBox);
            this.amountPanel.Location = new System.Drawing.Point(12, 181);
            this.amountPanel.Name = "amountPanel";
            this.amountPanel.Size = new System.Drawing.Size(332, 40);
            this.amountPanel.TabIndex = 7;
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.White;
            this.amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTextBox.Location = new System.Drawing.Point(9, 7);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(312, 22);
            this.amountTextBox.TabIndex = 1;
            // 
            // OrderCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 289);
            this.Controls.Add(this.amountPanel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.computerComboBox);
            this.Controls.Add(this.countPanel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый заказ";
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            this.amountPanel.ResumeLayout(false);
            this.amountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Panel countPanel;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.ComboBox computerComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Panel amountPanel;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}