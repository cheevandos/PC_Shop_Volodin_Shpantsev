namespace AdministratorView
{
    partial class SuppliersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersListForm));
            this.suppliersGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliersGridView
            // 
            this.suppliersGridView.AllowUserToAddRows = false;
            this.suppliersGridView.AllowUserToDeleteRows = false;
            this.suppliersGridView.AllowUserToResizeRows = false;
            this.suppliersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersGridView.BackgroundColor = System.Drawing.Color.White;
            this.suppliersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersGridView.Location = new System.Drawing.Point(12, 58);
            this.suppliersGridView.Name = "suppliersGridView";
            this.suppliersGridView.ReadOnly = true;
            this.suppliersGridView.Size = new System.Drawing.Size(670, 200);
            this.suppliersGridView.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(12, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(670, 40);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Обновить список";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SuppliersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 270);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.suppliersGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SuppliersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.SuppliersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView suppliersGridView;
        private System.Windows.Forms.Button refreshButton;
    }
}