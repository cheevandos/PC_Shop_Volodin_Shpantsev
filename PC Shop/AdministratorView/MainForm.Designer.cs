namespace AdministratorView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.refreshOrdersButton = new System.Windows.Forms.Button();
            this.getPaidButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.startPreparingButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.requestsTabPage = new System.Windows.Forms.TabPage();
            this.refreshRequestsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.requestsGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.ordersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.requestsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ordersTabPage);
            this.tabControl.Controls.Add(this.requestsTabPage);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(152, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1120, 468);
            this.tabControl.TabIndex = 0;
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Controls.Add(this.refreshOrdersButton);
            this.ordersTabPage.Controls.Add(this.getPaidButton);
            this.ordersTabPage.Controls.Add(this.completeButton);
            this.ordersTabPage.Controls.Add(this.startPreparingButton);
            this.ordersTabPage.Controls.Add(this.confirmButton);
            this.ordersTabPage.Controls.Add(this.ordersGridView);
            this.ordersTabPage.Location = new System.Drawing.Point(4, 30);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTabPage.Size = new System.Drawing.Size(1112, 434);
            this.ordersTabPage.TabIndex = 0;
            this.ordersTabPage.Text = "Заказы";
            this.ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // refreshOrdersButton
            // 
            this.refreshOrdersButton.BackColor = System.Drawing.Color.White;
            this.refreshOrdersButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshOrdersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.refreshOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshOrdersButton.Location = new System.Drawing.Point(943, 190);
            this.refreshOrdersButton.Name = "refreshOrdersButton";
            this.refreshOrdersButton.Size = new System.Drawing.Size(163, 40);
            this.refreshOrdersButton.TabIndex = 5;
            this.refreshOrdersButton.Text = "Обновить список";
            this.refreshOrdersButton.UseVisualStyleBackColor = false;
            this.refreshOrdersButton.Click += new System.EventHandler(this.RefreshOrdersButton_Click);
            // 
            // getPaidButton
            // 
            this.getPaidButton.BackColor = System.Drawing.Color.White;
            this.getPaidButton.Enabled = false;
            this.getPaidButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.getPaidButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.getPaidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPaidButton.Location = new System.Drawing.Point(943, 144);
            this.getPaidButton.Name = "getPaidButton";
            this.getPaidButton.Size = new System.Drawing.Size(163, 40);
            this.getPaidButton.TabIndex = 4;
            this.getPaidButton.Text = "Оплата получена";
            this.getPaidButton.UseVisualStyleBackColor = false;
            this.getPaidButton.Click += new System.EventHandler(this.GetPaidButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.Color.White;
            this.completeButton.Enabled = false;
            this.completeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.completeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Location = new System.Drawing.Point(943, 98);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(163, 40);
            this.completeButton.TabIndex = 3;
            this.completeButton.Text = "Заказ готов";
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // startPreparingButton
            // 
            this.startPreparingButton.BackColor = System.Drawing.Color.White;
            this.startPreparingButton.Enabled = false;
            this.startPreparingButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.startPreparingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.startPreparingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPreparingButton.Location = new System.Drawing.Point(943, 52);
            this.startPreparingButton.Name = "startPreparingButton";
            this.startPreparingButton.Size = new System.Drawing.Size(163, 40);
            this.startPreparingButton.TabIndex = 2;
            this.startPreparingButton.Text = "В обработку";
            this.startPreparingButton.UseVisualStyleBackColor = false;
            this.startPreparingButton.Click += new System.EventHandler(this.StartPreparingButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.White;
            this.confirmButton.Enabled = false;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(943, 6);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(163, 40);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ordersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersGridView.BackgroundColor = System.Drawing.Color.White;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ordersGridView.Location = new System.Drawing.Point(7, 6);
            this.ordersGridView.MultiSelect = false;
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.Size = new System.Drawing.Size(930, 422);
            this.ordersGridView.TabIndex = 1;
            this.ordersGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersGridView_CellMouseClick);
            this.ordersGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersGridView_RowHeaderMouseClick);
            // 
            // requestsTabPage
            // 
            this.requestsTabPage.Controls.Add(this.refreshRequestsButton);
            this.requestsTabPage.Controls.Add(this.deleteButton);
            this.requestsTabPage.Controls.Add(this.updateButton);
            this.requestsTabPage.Controls.Add(this.createButton);
            this.requestsTabPage.Controls.Add(this.requestsGridView);
            this.requestsTabPage.Location = new System.Drawing.Point(4, 30);
            this.requestsTabPage.Name = "requestsTabPage";
            this.requestsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.requestsTabPage.Size = new System.Drawing.Size(1112, 434);
            this.requestsTabPage.TabIndex = 1;
            this.requestsTabPage.Text = "Заявки";
            this.requestsTabPage.UseVisualStyleBackColor = true;
            // 
            // refreshRequestsButton
            // 
            this.refreshRequestsButton.BackColor = System.Drawing.Color.White;
            this.refreshRequestsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refreshRequestsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.refreshRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshRequestsButton.Location = new System.Drawing.Point(942, 144);
            this.refreshRequestsButton.Name = "refreshRequestsButton";
            this.refreshRequestsButton.Size = new System.Drawing.Size(163, 40);
            this.refreshRequestsButton.TabIndex = 9;
            this.refreshRequestsButton.Text = "Обновить список";
            this.refreshRequestsButton.UseVisualStyleBackColor = false;
            this.refreshRequestsButton.Click += new System.EventHandler(this.RefreshRequestsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(943, 98);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(163, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.White;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(943, 52);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(163, 40);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Редактировать";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Location = new System.Drawing.Point(943, 6);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(163, 40);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Создать заявку";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // requestsGridView
            // 
            this.requestsGridView.AllowUserToAddRows = false;
            this.requestsGridView.AllowUserToDeleteRows = false;
            this.requestsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.requestsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.requestsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.requestsGridView.BackgroundColor = System.Drawing.Color.White;
            this.requestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requestsGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.requestsGridView.Location = new System.Drawing.Point(7, 6);
            this.requestsGridView.MultiSelect = false;
            this.requestsGridView.Name = "requestsGridView";
            this.requestsGridView.ReadOnly = true;
            this.requestsGridView.Size = new System.Drawing.Size(930, 422);
            this.requestsGridView.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computersToolStripMenuItem,
            this.componentsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.newOrderToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainMenuStrip.Size = new System.Drawing.Size(148, 492);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.computersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.computersToolStripMenuItem.Text = "ПК";
            this.computersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.computersToolStripMenuItem.Click += new System.EventHandler(this.ComputersToolStripMenuItem_Click);
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.componentsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.componentsToolStripMenuItem.Text = "Комплектующие";
            this.componentsToolStripMenuItem.Click += new System.EventHandler(this.ComponentsToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.suppliersToolStripMenuItem.Text = "Поставщики";
            this.suppliersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.SuppliersToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newOrderToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.newOrderToolStripMenuItem.Text = "Новый заказ";
            this.newOrderToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.NewOrderToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            this.reportsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 492);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин компьютерной техники. Панель администратора";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.ordersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.requestsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestsGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ordersTabPage;
        private System.Windows.Forms.TabPage requestsTabPage;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridView requestsGridView;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshOrdersButton;
        private System.Windows.Forms.Button getPaidButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button startPreparingButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.Button refreshRequestsButton;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

