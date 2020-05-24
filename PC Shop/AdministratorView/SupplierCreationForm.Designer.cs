namespace AdministratorView
{
    partial class SupplierCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierCreationForm));
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNamePanel = new System.Windows.Forms.Panel();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.fullNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 243);
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
            this.cancelButton.Location = new System.Drawing.Point(181, 243);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(9, 7);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(312, 22);
            this.loginTextBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(12, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(163, 30);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Location = new System.Drawing.Point(12, 42);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(332, 40);
            this.loginPanel.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 85);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(163, 30);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Location = new System.Drawing.Point(12, 118);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(332, 40);
            this.passwordPanel.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(9, 7);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(312, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(12, 161);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(163, 30);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "ФИО:";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullNamePanel
            // 
            this.fullNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNamePanel.Controls.Add(this.fullNameTextBox);
            this.fullNamePanel.Location = new System.Drawing.Point(12, 194);
            this.fullNamePanel.Name = "fullNamePanel";
            this.fullNamePanel.Size = new System.Drawing.Size(332, 40);
            this.fullNamePanel.TabIndex = 7;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.Color.White;
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTextBox.Location = new System.Drawing.Point(9, 7);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 9);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // SupplierCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 295);
            this.Controls.Add(this.fullNamePanel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplierCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый поставщик";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.fullNamePanel.ResumeLayout(false);
            this.fullNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Panel fullNamePanel;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}