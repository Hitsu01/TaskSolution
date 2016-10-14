namespace TaskSolution
{
    partial class TaskSolution
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
            this.EmployeeDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SortByAscButton = new System.Windows.Forms.Button();
            this.SortByDesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstFiveButton = new System.Windows.Forms.Button();
            this.LastThreeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGrid
            // 
            this.EmployeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GridEmployeeName,
            this.Payment});
            this.EmployeeDataGrid.Location = new System.Drawing.Point(12, 107);
            this.EmployeeDataGrid.Name = "EmployeeDataGrid";
            this.EmployeeDataGrid.Size = new System.Drawing.Size(385, 285);
            this.EmployeeDataGrid.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // GridEmployeeName
            // 
            this.GridEmployeeName.HeaderText = "Name";
            this.GridEmployeeName.Name = "GridEmployeeName";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(103, 21);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 29);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(27, 21);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(70, 27);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(261, 21);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(157, 20);
            this.SearchField.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(424, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(51, 20);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SortByAscButton
            // 
            this.SortByAscButton.Location = new System.Drawing.Point(403, 162);
            this.SortByAscButton.Name = "SortByAscButton";
            this.SortByAscButton.Size = new System.Drawing.Size(92, 33);
            this.SortByAscButton.TabIndex = 6;
            this.SortByAscButton.Text = "Sort by Asc";
            this.SortByAscButton.UseVisualStyleBackColor = true;
            this.SortByAscButton.Click += new System.EventHandler(this.SortByAscButton_Click);
            // 
            // SortByDesButton
            // 
            this.SortByDesButton.Location = new System.Drawing.Point(403, 107);
            this.SortByDesButton.Name = "SortByDesButton";
            this.SortByDesButton.Size = new System.Drawing.Size(92, 34);
            this.SortByDesButton.TabIndex = 7;
            this.SortByDesButton.Text = "Sort by Des";
            this.SortByDesButton.UseVisualStyleBackColor = true;
            this.SortByDesButton.Click += new System.EventHandler(this.SortByDesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // FirstFiveButton
            // 
            this.FirstFiveButton.Location = new System.Drawing.Point(403, 215);
            this.FirstFiveButton.Name = "FirstFiveButton";
            this.FirstFiveButton.Size = new System.Drawing.Size(90, 33);
            this.FirstFiveButton.TabIndex = 9;
            this.FirstFiveButton.Text = "First five name";
            this.FirstFiveButton.UseVisualStyleBackColor = true;
            this.FirstFiveButton.Click += new System.EventHandler(this.FirstFiveButton_Click);
            // 
            // LastThreeButton
            // 
            this.LastThreeButton.Location = new System.Drawing.Point(403, 263);
            this.LastThreeButton.Name = "LastThreeButton";
            this.LastThreeButton.Size = new System.Drawing.Size(92, 35);
            this.LastThreeButton.TabIndex = 10;
            this.LastThreeButton.Text = "Last three id";
            this.LastThreeButton.UseVisualStyleBackColor = true;
            this.LastThreeButton.Click += new System.EventHandler(this.LastThreeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // TaskSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(526, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastThreeButton);
            this.Controls.Add(this.FirstFiveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortByDesButton);
            this.Controls.Add(this.SortByAscButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchField);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmployeeDataGrid);
            this.Name = "TaskSolution";
            this.Text = "TaskSolution";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGrid;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SortByAscButton;
        private System.Windows.Forms.Button SortByDesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FirstFiveButton;
        private System.Windows.Forms.Button LastThreeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
    }
}

