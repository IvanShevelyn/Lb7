namespace Lb6
{
    partial class Form1
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
            this.DepartmentGridView = new System.Windows.Forms.DataGridView();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveDepartment = new System.Windows.Forms.Button();
            this.WorkerGridView = new System.Windows.Forms.DataGridView();
            this.AddWorker = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveWorker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentGridView
            // 
            this.DepartmentGridView.AllowUserToResizeColumns = false;
            this.DepartmentGridView.AllowUserToResizeRows = false;
            this.DepartmentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DepartmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepartmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentGridView.Location = new System.Drawing.Point(12, 44);
            this.DepartmentGridView.Name = "DepartmentGridView";
            this.DepartmentGridView.RowHeadersWidth = 62;
            this.DepartmentGridView.RowTemplate.Height = 28;
            this.DepartmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepartmentGridView.Size = new System.Drawing.Size(387, 497);
            this.DepartmentGridView.TabIndex = 0;
            this.DepartmentGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentGridView_CellValueChanged);
            this.DepartmentGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DepartmentGridView_DataError);
            this.DepartmentGridView.SelectionChanged += new System.EventHandler(this.DepartmentGridView_SelectionChanged);
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepartmentButton.Location = new System.Drawing.Point(124, 8);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(65, 30);
            this.AddDepartmentButton.TabIndex = 2;
            this.AddDepartmentButton.Text = "Add";
            this.AddDepartmentButton.UseVisualStyleBackColor = true;
            this.AddDepartmentButton.Click += new System.EventHandler(this.AddDepartmentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departments:";
            // 
            // RemoveDepartment
            // 
            this.RemoveDepartment.Location = new System.Drawing.Point(195, 8);
            this.RemoveDepartment.Name = "RemoveDepartment";
            this.RemoveDepartment.Size = new System.Drawing.Size(83, 30);
            this.RemoveDepartment.TabIndex = 4;
            this.RemoveDepartment.Text = "Remove";
            this.RemoveDepartment.UseVisualStyleBackColor = true;
            this.RemoveDepartment.Click += new System.EventHandler(this.RemoveDepartment_Click);
            // 
            // WorkerGridView
            // 
            this.WorkerGridView.AllowUserToResizeColumns = false;
            this.WorkerGridView.AllowUserToResizeRows = false;
            this.WorkerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerGridView.Location = new System.Drawing.Point(422, 44);
            this.WorkerGridView.Name = "WorkerGridView";
            this.WorkerGridView.RowHeadersWidth = 62;
            this.WorkerGridView.RowTemplate.Height = 28;
            this.WorkerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkerGridView.Size = new System.Drawing.Size(582, 497);
            this.WorkerGridView.TabIndex = 0;
            this.WorkerGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkerGridView_CellValueChanged);
            this.WorkerGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.WorkerGridView_DataError);
            // 
            // AddWorker
            // 
            this.AddWorker.Location = new System.Drawing.Point(648, 8);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(65, 30);
            this.AddWorker.TabIndex = 5;
            this.AddWorker.Text = "Add";
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employees of this department:";
            // 
            // RemoveWorker
            // 
            this.RemoveWorker.Location = new System.Drawing.Point(719, 8);
            this.RemoveWorker.Name = "RemoveWorker";
            this.RemoveWorker.Size = new System.Drawing.Size(82, 30);
            this.RemoveWorker.TabIndex = 7;
            this.RemoveWorker.Text = "Remove";
            this.RemoveWorker.UseVisualStyleBackColor = true;
            this.RemoveWorker.Click += new System.EventHandler(this.RemoveWorker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 555);
            this.Controls.Add(this.RemoveWorker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddWorker);
            this.Controls.Add(this.RemoveDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDepartmentButton);
            this.Controls.Add(this.WorkerGridView);
            this.Controls.Add(this.DepartmentGridView);
            this.MinimumSize = new System.Drawing.Size(1042, 611);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DepartmentGridView;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveDepartment;
        private System.Windows.Forms.DataGridView WorkerGridView;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveWorker;
    }
}

