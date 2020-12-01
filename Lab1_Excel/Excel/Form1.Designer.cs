﻿namespace Excel
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
            this.Excel = new System.Windows.Forms.DataGridView();
            this.InputTexbox = new System.Windows.Forms.TextBox();
            this.EvaluateButton = new System.Windows.Forms.Button();
            this.RowLable = new System.Windows.Forms.Label();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.ColumnLable = new System.Windows.Forms.Label();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.RemoveColumnButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ReadMeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // Excel
            // 
            this.Excel.AllowUserToAddRows = false;
            this.Excel.AllowUserToDeleteRows = false;
            this.Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Excel.Location = new System.Drawing.Point(-1, 82);
            this.Excel.Margin = new System.Windows.Forms.Padding(2);
            this.Excel.Name = "Excel";
            this.Excel.ReadOnly = true;
            this.Excel.RowHeadersWidth = 51;
            this.Excel.RowTemplate.Height = 24;
            this.Excel.Size = new System.Drawing.Size(763, 338);
            this.Excel.TabIndex = 0;
            this.Excel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Excel_CellClick);
            // 
            // InputTexbox
            // 
            this.InputTexbox.Location = new System.Drawing.Point(473, 33);
            this.InputTexbox.Margin = new System.Windows.Forms.Padding(2);
            this.InputTexbox.Name = "InputTexbox";
            this.InputTexbox.Size = new System.Drawing.Size(189, 20);
            this.InputTexbox.TabIndex = 1;
            // 
            // EvaluateButton
            // 
            this.EvaluateButton.Location = new System.Drawing.Point(666, 20);
            this.EvaluateButton.Margin = new System.Windows.Forms.Padding(2);
            this.EvaluateButton.Name = "EvaluateButton";
            this.EvaluateButton.Size = new System.Drawing.Size(83, 47);
            this.EvaluateButton.TabIndex = 2;
            this.EvaluateButton.Text = "Calculate";
            this.EvaluateButton.UseVisualStyleBackColor = true;
            this.EvaluateButton.Click += new System.EventHandler(this.EvaluateButton_Click);
            // 
            // RowLable
            // 
            this.RowLable.AutoSize = true;
            this.RowLable.Location = new System.Drawing.Point(269, 20);
            this.RowLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RowLable.Name = "RowLable";
            this.RowLable.Size = new System.Drawing.Size(34, 13);
            this.RowLable.TabIndex = 3;
            this.RowLable.Text = "Rows";
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(244, 35);
            this.AddRowButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(38, 26);
            this.AddRowButton.TabIndex = 4;
            this.AddRowButton.Text = "+";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Location = new System.Drawing.Point(286, 35);
            this.RemoveRowButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(37, 26);
            this.RemoveRowButton.TabIndex = 4;
            this.RemoveRowButton.Text = "-";
            this.RemoveRowButton.UseVisualStyleBackColor = true;
            this.RemoveRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // ColumnLable
            // 
            this.ColumnLable.AutoSize = true;
            this.ColumnLable.Location = new System.Drawing.Point(379, 20);
            this.ColumnLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColumnLable.Name = "ColumnLable";
            this.ColumnLable.Size = new System.Drawing.Size(47, 13);
            this.ColumnLable.TabIndex = 3;
            this.ColumnLable.Text = "Columns";
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Location = new System.Drawing.Point(359, 35);
            this.AddColumnButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(38, 26);
            this.AddColumnButton.TabIndex = 4;
            this.AddColumnButton.Text = "+";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // RemoveColumnButton
            // 
            this.RemoveColumnButton.Location = new System.Drawing.Point(401, 35);
            this.RemoveColumnButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveColumnButton.Name = "RemoveColumnButton";
            this.RemoveColumnButton.Size = new System.Drawing.Size(38, 26);
            this.RemoveColumnButton.TabIndex = 4;
            this.RemoveColumnButton.Text = "-";
            this.RemoveColumnButton.UseVisualStyleBackColor = true;
            this.RemoveColumnButton.Click += new System.EventHandler(this.RemoveColumnButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 25);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(59, 36);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(74, 25);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(62, 36);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ReadMeButton
            // 
            this.ReadMeButton.Location = new System.Drawing.Point(140, 24);
            this.ReadMeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReadMeButton.Name = "ReadMeButton";
            this.ReadMeButton.Size = new System.Drawing.Size(59, 37);
            this.ReadMeButton.TabIndex = 5;
            this.ReadMeButton.Text = "Help";
            this.ReadMeButton.UseVisualStyleBackColor = true;
            this.ReadMeButton.Click += new System.EventHandler(this.ReadMeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ReadMeButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RemoveColumnButton);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.RemoveRowButton);
            this.Controls.Add(this.ColumnLable);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.RowLable);
            this.Controls.Add(this.EvaluateButton);
            this.Controls.Add(this.InputTexbox);
            this.Controls.Add(this.Excel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.Excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Excel;
        private System.Windows.Forms.TextBox InputTexbox;
        private System.Windows.Forms.Button EvaluateButton;
        private System.Windows.Forms.Label RowLable;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button RemoveRowButton;
        private System.Windows.Forms.Label ColumnLable;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Button RemoveColumnButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ReadMeButton;
    }
}

