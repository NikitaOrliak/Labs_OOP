﻿namespace Lab2
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.ToHTMLButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaxRadioButton = new System.Windows.Forms.RadioButton();
            this.DomRadioButton = new System.Windows.Forms.RadioButton();
            this.LinqRadioButton = new System.Windows.Forms.RadioButton();
            this.AuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleCheckBox = new System.Windows.Forms.CheckBox();
            this.GenreCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceCheckBox = new System.Windows.Forms.CheckBox();
            this.PublishYearCheckBox = new System.Windows.Forms.CheckBox();
            this.PublishYearComboBox = new System.Windows.Forms.ComboBox();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.OpenXML = new System.Windows.Forms.Button();
            this.OpenHTML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(195, 362);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 36);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ToHTMLButton
            // 
            this.ToHTMLButton.Location = new System.Drawing.Point(441, 364);
            this.ToHTMLButton.Margin = new System.Windows.Forms.Padding(2);
            this.ToHTMLButton.Name = "ToHTMLButton";
            this.ToHTMLButton.Size = new System.Drawing.Size(106, 34);
            this.ToHTMLButton.TabIndex = 1;
            this.ToHTMLButton.Text = "Transform to HTML";
            this.ToHTMLButton.UseVisualStyleBackColor = true;
            this.ToHTMLButton.Click += new System.EventHandler(this.ToHTMLButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(318, 362);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(106, 36);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaxRadioButton
            // 
            this.SaxRadioButton.AutoSize = true;
            this.SaxRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaxRadioButton.Location = new System.Drawing.Point(430, 27);
            this.SaxRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaxRadioButton.Name = "SaxRadioButton";
            this.SaxRadioButton.Size = new System.Drawing.Size(46, 17);
            this.SaxRadioButton.TabIndex = 3;
            this.SaxRadioButton.TabStop = true;
            this.SaxRadioButton.Text = "Sax";
            this.SaxRadioButton.UseVisualStyleBackColor = true;
            // 
            // DomRadioButton
            // 
            this.DomRadioButton.AutoSize = true;
            this.DomRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DomRadioButton.Location = new System.Drawing.Point(497, 27);
            this.DomRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DomRadioButton.Name = "DomRadioButton";
            this.DomRadioButton.Size = new System.Drawing.Size(50, 17);
            this.DomRadioButton.TabIndex = 4;
            this.DomRadioButton.TabStop = true;
            this.DomRadioButton.Text = "Dom";
            this.DomRadioButton.UseVisualStyleBackColor = true;
            // 
            // LinqRadioButton
            // 
            this.LinqRadioButton.AutoSize = true;
            this.LinqRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinqRadioButton.Location = new System.Drawing.Point(564, 27);
            this.LinqRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LinqRadioButton.Name = "LinqRadioButton";
            this.LinqRadioButton.Size = new System.Drawing.Size(49, 17);
            this.LinqRadioButton.TabIndex = 5;
            this.LinqRadioButton.TabStop = true;
            this.LinqRadioButton.Text = "Linq";
            this.LinqRadioButton.UseVisualStyleBackColor = true;
            // 
            // AuthorCheckBox
            // 
            this.AuthorCheckBox.AutoSize = true;
            this.AuthorCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorCheckBox.Location = new System.Drawing.Point(564, 140);
            this.AuthorCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorCheckBox.Name = "AuthorCheckBox";
            this.AuthorCheckBox.Size = new System.Drawing.Size(63, 17);
            this.AuthorCheckBox.TabIndex = 6;
            this.AuthorCheckBox.Text = "Author";
            this.AuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // TitleCheckBox
            // 
            this.TitleCheckBox.AutoSize = true;
            this.TitleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleCheckBox.Location = new System.Drawing.Point(564, 184);
            this.TitleCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleCheckBox.Name = "TitleCheckBox";
            this.TitleCheckBox.Size = new System.Drawing.Size(51, 17);
            this.TitleCheckBox.TabIndex = 7;
            this.TitleCheckBox.Text = "Title";
            this.TitleCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenreCheckBox
            // 
            this.GenreCheckBox.AutoSize = true;
            this.GenreCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreCheckBox.Location = new System.Drawing.Point(564, 225);
            this.GenreCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreCheckBox.Name = "GenreCheckBox";
            this.GenreCheckBox.Size = new System.Drawing.Size(60, 17);
            this.GenreCheckBox.TabIndex = 8;
            this.GenreCheckBox.Text = "Genre";
            this.GenreCheckBox.UseVisualStyleBackColor = true;
            // 
            // PriceCheckBox
            // 
            this.PriceCheckBox.AutoSize = true;
            this.PriceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceCheckBox.Location = new System.Drawing.Point(564, 270);
            this.PriceCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriceCheckBox.Name = "PriceCheckBox";
            this.PriceCheckBox.Size = new System.Drawing.Size(55, 17);
            this.PriceCheckBox.TabIndex = 9;
            this.PriceCheckBox.Text = "Price";
            this.PriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // PublishYearCheckBox
            // 
            this.PublishYearCheckBox.AutoSize = true;
            this.PublishYearCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishYearCheckBox.Location = new System.Drawing.Point(564, 312);
            this.PublishYearCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.PublishYearCheckBox.Name = "PublishYearCheckBox";
            this.PublishYearCheckBox.Size = new System.Drawing.Size(95, 17);
            this.PublishYearCheckBox.TabIndex = 10;
            this.PublishYearCheckBox.Text = "Publish year";
            this.PublishYearCheckBox.UseVisualStyleBackColor = true;
            // 
            // PublishYearComboBox
            // 
            this.PublishYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublishYearComboBox.FormattingEnabled = true;
            this.PublishYearComboBox.Location = new System.Drawing.Point(411, 312);
            this.PublishYearComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PublishYearComboBox.Name = "PublishYearComboBox";
            this.PublishYearComboBox.Size = new System.Drawing.Size(116, 21);
            this.PublishYearComboBox.TabIndex = 11;
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Location = new System.Drawing.Point(411, 270);
            this.PriceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(116, 21);
            this.PriceComboBox.TabIndex = 12;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(411, 223);
            this.GenreComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(116, 21);
            this.GenreComboBox.TabIndex = 13;
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(411, 180);
            this.TitleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(116, 21);
            this.TitleComboBox.TabIndex = 14;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(411, 136);
            this.AuthorComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(116, 21);
            this.AuthorComboBox.TabIndex = 15;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(11, 38);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(302, 295);
            this.richTextBox.TabIndex = 16;
            this.richTextBox.Text = "";
            // 
            // OpenXML
            // 
            this.OpenXML.Location = new System.Drawing.Point(460, 64);
            this.OpenXML.Margin = new System.Windows.Forms.Padding(2);
            this.OpenXML.Name = "OpenXML";
            this.OpenXML.Size = new System.Drawing.Size(128, 37);
            this.OpenXML.TabIndex = 17;
            this.OpenXML.Text = "Open XML";
            this.OpenXML.UseVisualStyleBackColor = true;
            this.OpenXML.Click += new System.EventHandler(this.OpenXML_Click);
            // 
            // OpenHTML
            // 
            this.OpenHTML.Location = new System.Drawing.Point(561, 364);
            this.OpenHTML.Margin = new System.Windows.Forms.Padding(2);
            this.OpenHTML.Name = "OpenHTML";
            this.OpenHTML.Size = new System.Drawing.Size(106, 34);
            this.OpenHTML.TabIndex = 18;
            this.OpenHTML.Text = "Open HTML";
            this.OpenHTML.UseVisualStyleBackColor = true;
            this.OpenHTML.Click += new System.EventHandler(this.OpenHTML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(678, 409);
            this.Controls.Add(this.OpenHTML);
            this.Controls.Add(this.OpenXML);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.TitleComboBox);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.PriceComboBox);
            this.Controls.Add(this.PublishYearComboBox);
            this.Controls.Add(this.PublishYearCheckBox);
            this.Controls.Add(this.PriceCheckBox);
            this.Controls.Add(this.GenreCheckBox);
            this.Controls.Add(this.TitleCheckBox);
            this.Controls.Add(this.AuthorCheckBox);
            this.Controls.Add(this.LinqRadioButton);
            this.Controls.Add(this.DomRadioButton);
            this.Controls.Add(this.SaxRadioButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ToHTMLButton);
            this.Controls.Add(this.ClearButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Orliak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ToHTMLButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton SaxRadioButton;
        private System.Windows.Forms.RadioButton DomRadioButton;
        private System.Windows.Forms.RadioButton LinqRadioButton;
        private System.Windows.Forms.CheckBox AuthorCheckBox;
        private System.Windows.Forms.CheckBox TitleCheckBox;
        private System.Windows.Forms.CheckBox GenreCheckBox;
        private System.Windows.Forms.CheckBox PriceCheckBox;
        private System.Windows.Forms.CheckBox PublishYearCheckBox;
        private System.Windows.Forms.ComboBox PublishYearComboBox;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button OpenXML;
        private System.Windows.Forms.Button OpenHTML;
    }
}

